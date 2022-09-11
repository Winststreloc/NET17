using System;
using System.Collections.Generic;
using System.Text;

namespace Homewok_5
{
    public class Parse
    {
        public static double ParseCalculator(string s)
        {
            s = s.Trim(' ');
            Stack<string> stack = new Stack<string>();
            char[] arr = s.ToCharArray();

            StringBuilder sb = new StringBuilder();
            List<string> t = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= '0' && arr[i] <= '9')
                {
                    sb.Append(arr[i]);

                    if (i == arr.Length - 1)
                    {
                        stack.Push(sb.ToString());
                    }
                    else
                    {
                        if (sb.Length > 0)
                        {
                            stack.Push(sb.ToString());
                            sb = new StringBuilder();
                        }
                    }
                    if (arr[i] != ')')
                    {
                        stack.Push(new String(new char[] { arr[i] }));
                    }
                    else
                    {
                        // when meet ')', pop and calculate
                        
                        while (stack.Count != 0)
                        {
                            String top = stack.Pop();
                            if (top.Equals("("))
                            { 
                                break;
                            }
                            else
                            {
                                t.Add(top);
                            }
                        }

                        double _temp = 0;
                        if (t.Count == 1)
                        {
                            _temp = double.Parse(t[0]);
                        }
                        else
                        {
                            for (int j = t.Count - 1; j > 0; j -= 2)
                            {
                                if (t[j - 1].Equals("-"))
                                {
                                    _temp += 0 - double.Parse(t[j]);
                                }
                                else
                                {
                                    _temp += double.Parse(t[j]);
                                }
                            }
                            _temp += double.Parse(t[0]);
                        }
                        stack.Push(Convert.ToString(_temp));
                    }
                }
            }
            
            while (stack.Count != 0)
                {
                string elem = stack.Pop();
                t.Add(elem);
            }

            double temp = 0;
            for (int k = t.Count - 1; k > 0; k -= 2)
            {
                if (t[k - 1].Equals("-"))
                {
                    temp += 0 - double.Parse(t[k]);
                }
                else
                {
                    temp += double.Parse(t[k]);
                }
            }
            temp += double.Parse(t[0]);

            return temp;
        }
    }
}
