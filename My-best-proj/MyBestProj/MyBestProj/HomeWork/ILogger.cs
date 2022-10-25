

using System.IO;

namespace MyBestProj.HomeWork
{
    public interface ILogger
    {
        void WriteLog(Line<string, int, Gun> strValue, string action);
    }
}