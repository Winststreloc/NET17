namespace Lesson8.Printer
{
    public interface IPrinter
    {
        public delegate void ConsolePrint(string a);
        public delegate void ConsoleSetCursor(int x, int y);
        public delegate void TaskCompletedCallBack(string taskResult);

        void Write(string text);
        void WriteLine(string text);
        void SetCursor(int x, int y);
    }
}
