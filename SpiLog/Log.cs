using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace SpiLog
{
    public class LoggerService : ISpiloggerService
    {

      
        private readonly IHostingEnvironment _env;
        private StringBuilder Logs;
        public LoggerService(IHostingEnvironment env)
        {
            _env = env;
            Logs = new StringBuilder();
            Logs.AppendLine(DateTime.Now.ToLongDateString());
        }
        public async Task CreateLogAsync(ReportFolder reportFolder, string Filename)
        {
            
            var path = Path.Combine(_env.WebRootPath, $@"Reports/{reportFolder}").ToLower();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, $"{DateTime.Now.ToLongDateString()} {Filename}.txt")))
            {
                await outputFile.WriteLineAsync(Logs.ToString());
            }

        }

        public string GetLogsExistInMemmory()
        {
            if (Logs.Length > 0)
            return Logs.ToString();
            return "NotAnyLog";
        }

        public void Write(string Message, string Value = null)
        {

            if (string.IsNullOrWhiteSpace(Value))
            {
                Logs.AppendLine($"#{DateTime.Now.ToLongTimeString()} : {Message}");

            }
            else
            {
                Logs.AppendLine($"#{DateTime.Now.ToLongTimeString()} : {Message} - {Value}");

            }
        }
    }

    public enum ReportFolder
    {
        instagarm,
        Facebook,
        Twitter,
        Blgfa,
    }
}
