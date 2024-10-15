using OBS.Interface;
using OBS.Models;
using OBS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Extensions
{
    public class LogCode
    {
        private ILogs _ILogs = new LogsRepository();
        private string clientExternalIP;
        private string getExternalIP()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    return client.DownloadString("https://api.ipify.org/");
                }
                catch (Exception)
                {
                    MessageBox.Show("İnternet bağlantınızı kontrol ediniz. Program kapatılıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                    return "";
                }
            }
        }

        private static LogCode instance;

        private LogCode()
        {
            clientExternalIP = getExternalIP();
        }

        public static LogCode Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogCode();
                }
                return instance;
            }
        }

        StreamWriter sw = new StreamWriter(AppContext.BaseDirectory + "\\logs\\" + DateTime.Now.ToString("yyyy-dd-M") + ".log", true, Encoding.ASCII);
        private string[] priorityArray = { "Error", "Warning", "Info", "Debug" };

        public void printLog(UInt16 priority, string user, string message)
        {
            if (priority < 4)
            {
                try
                {
                    Logs log = new Logs()
                    {
                        Date = DateTime.Now,
                        Status = priorityArray[priority],
                        Ip = clientExternalIP,
                        PCName = System.Environment.MachineName,
                        User = user,
                        Message = message
                    };

                    _ILogs.AddLog(log);
                    sw.WriteLineAsync(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + " | " + priorityArray[priority] + " | Machine Name : " + System.Environment.MachineName + " | IP : " + clientExternalIP + " | Log : " + message);
                    sw.FlushAsync();
                }
                catch (Exception e)
                {
                    throw new Exception("Writing log failed. " + e.Message);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(priority), "Argument must be less than 4.");
            }
        }

        public void closeLogWriter() { sw.Close(); }
    }
}
