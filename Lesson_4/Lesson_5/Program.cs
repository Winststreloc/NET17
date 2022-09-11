using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ParserCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "12* 123/-(-5 + 2)+11";

            double result = Parser.Process(expression);
            Console.WriteLine(result);
            Console.Read();
        }
    }

    public class Parser
    {
        public const char START_ARG = '(';
        public const char END_ARG = ')';
        public const char END_LINE = '\n';

        class Cell
        {
            internal Cell(double value, char action)
            {
                Value = value;
                Action = action;
            }

            internal double Value { get; set; }
            internal char Action { get; set; }
        }

        public static double Process(string data)
        {
            data = data.Replace(".", ",");
            data = data.Replace("-(", "-1*(");
            data = Regex.Replace(data, @"\s", "");
            data = data.Replace("--", "+");
            data = data.Replace("/-1*", "/-1/");
            string expression = Preprocess(data);
            int from = 0;

            return LoadAndCalculate(data, ref from, END_LINE);
        }

        static string Preprocess(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("Loaded empty data");
            }

            int parentheses = 0;
            StringBuilder result = new StringBuilder(data.Length);

            for (int i = 0; i < data.Length; i++)
            {
                char ch = data[i];
                switch (ch)
                {
                    case ' ':
                    case '\t':
                    case '\n': continue;
                    case END_ARG:
                        parentheses--;
                        break;
                    case START_ARG:
                        parentheses++;
                        break;
                }
                result.Append(ch);
            }

            if (parentheses != 0)
            {
                throw new ArgumentException("Uneven parenthesis");
            }

            return result.ToString();
        }

        public static double LoadAndCalculate(string data, ref int from, char to = END_LINE)
        {
            if (from >= data.Length || data[from] == to)
            {
                throw new ArgumentException("Loaded invalid data: " + data);
            }

            List<Cell> listToMerge = new List<Cell>(16);
            StringBuilder item = new StringBuilder();

            do
            { // Main processing cycle of the first part.
                char ch = data[from++];
                if (StillCollecting(item.ToString(), ch, to))
                { // The char still belongs to the previous operand.
                    item.Append(ch);
                    if (from < data.Length && data[from] != to)
                    {
                        continue;
                    }
                }

                // We are done getting the next token. The getValue() call below may
                // recursively call loadAndCalculate(). This will happen if extracted
                // item is a function or if the next item is starting with a START_ARG '('.
                ParserFunction func = new ParserFunction(data, ref from, item.ToString(), ch);
                double value = func.GetValue(data, ref from);

                char action = ValidAction(ch) ? ch
                                              : UpdateAction(data, ref from, ch, to);

                listToMerge.Add(new Cell(value, action));
                item.Clear();

            } while (from < data.Length && data[from] != to);

            if (from < data.Length &&
               (data[from] == END_ARG || data[from] == to))
            { // This happens when called recursively: move one char forward.
                from++;
            }

            Cell baseCell = listToMerge[0];
            int index = 1;

            return Merge(baseCell, ref index, listToMerge);
        }

        static bool StillCollecting(string item, char ch, char to)
        {
            // Stop collecting if either got END_ARG ')' or to char, e.g. ','.
            char stopCollecting = (to == END_ARG || to == END_LINE) ?
                                   END_ARG : to;
            return (item.Length == 0 && (ch == '-' || ch == END_ARG)) ||
                  !(ValidAction(ch) || ch == START_ARG || ch == stopCollecting);
        }

        static bool ValidAction(char ch)
        {
            return ch == '*' || ch == '/' || ch == '+' || ch == '-' || ch == '^';
        }

        static char UpdateAction(string item, ref int from, char ch, char to)
        {
            if (from >= item.Length || item[from] == END_ARG || item[from] == to)
            {
                return END_ARG;
            }

            int index = from;
            char res = ch;
            while (!ValidAction(res) && index < item.Length)
            { // Look for the next character in string until a valid action is found.
                res = item[index++];
            }

            from = ValidAction(res) ? index
                                    : index > from ? index - 1
                                                   : from;
            return res;
        }

        // From outside this function is called with mergeOneOnly = false.
        // It also calls itself recursively with mergeOneOnly = true, meaning
        // that it will return after only one merge.
        static double Merge(Cell current, ref int index, List<Cell> listToMerge,
                     bool mergeOneOnly = false)
        {
            while (index < listToMerge.Count)
            {
                Cell next = listToMerge[index++];

                while (!CanMergeCells(current, next))
                { // If we cannot merge cells yet, go to the next cell and merge
                  // next cells first. E.g. if we have 1+2*3, we first merge next
                  // cells, i.e. 2*3, getting 6, and then we can merge 1+6.
                    Merge(next, ref index, listToMerge, true /* mergeOneOnly */);
                }
                MergeCells(current, next);
                if (mergeOneOnly)
                {
                    return current.Value;
                }
            }

            return current.Value;
        }

        static void MergeCells(Cell leftCell, Cell rightCell)
        {
            switch (leftCell.Action)
            {
                case '^':
                    leftCell.Value = Math.Pow(leftCell.Value, rightCell.Value);
                    break;
                case '*':
                    leftCell.Value *= rightCell.Value;
                    break;
                case '/':
                    if (rightCell.Value == 0)
                    {
                        throw new ArgumentException("Division by zero");
                    }
                    leftCell.Value /= rightCell.Value;
                    break;
                case '+':
                    leftCell.Value += rightCell.Value;
                    break;
                case '-':
                    leftCell.Value -= rightCell.Value;
                    break;
            }
            leftCell.Action = rightCell.Action;
        }

        static bool CanMergeCells(Cell leftCell, Cell rightCell)
        {
            return GetPriority(leftCell.Action) >= GetPriority(rightCell.Action);
        }

        static int GetPriority(char action)
        {
            switch (action)
            {
                case '^': return 4;
                case '*':
                case '/': return 3;
                case '+':
                case '-': return 2;
            }
            return 0;
        }
    }

    public class ParserFunction
    {
        public ParserFunction()
        {
            m_impl = this;
        }

        // A "virtual" Constructor
        internal ParserFunction(string data, ref int from, string item, char ch)
        {
            if (item.Length == 0 && ch == Parser.START_ARG)
            {
                // There is no function, just an expression in parentheses
                m_impl = s_idFunction;
                return;
            }

            if (m_functions.TryGetValue(item, out m_impl))
            {
                // Function exists and is registered (e.g. pi, exp, etc.)
                return;
            }

            // Function not found, will try to parse this as a number.
            s_strtodFunction.Item = item;
            m_impl = s_strtodFunction;
        }

        public static void AddFunction(string name, ParserFunction function)
        {
            m_functions[name] = function;
        }

        public double GetValue(string data, ref int from)
        {
            return m_impl.Evaluate(data, ref from);
        }

        protected virtual double Evaluate(string data, ref int from)
        {
            // The real implementation will be in the derived classes.
            return 0;
        }

        private readonly ParserFunction m_impl;
        private static readonly Dictionary<string, ParserFunction> m_functions = new Dictionary<string, ParserFunction>();

        private static readonly StrtodFunction s_strtodFunction = new StrtodFunction();
        private static readonly IdentityFunction s_idFunction = new IdentityFunction();
    }

    class StrtodFunction : ParserFunction
    {
        protected override double Evaluate(string data, ref int from)
        {
            if (!Double.TryParse(Item, out double num))
            {
                throw new ArgumentException("Could not parse token [" + Item + "]");
            }
            return num;
        }
        public string Item { private get; set; }
    }

    class IdentityFunction : ParserFunction
    {
        protected override double Evaluate(string data, ref int from)
        {
            return Parser.LoadAndCalculate(data, ref from, Parser.END_ARG);
        }
    }
}
