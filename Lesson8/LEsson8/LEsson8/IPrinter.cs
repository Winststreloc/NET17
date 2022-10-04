namespace Lesson8
{
    public interface IPrinter
    {
        public delegate void ConsolePrint(string a);
        public delegate void ConsoleSetCursor(int x, int y);
        public delegate void TaskCompletedCallBack(string taskResult);

    }
}
