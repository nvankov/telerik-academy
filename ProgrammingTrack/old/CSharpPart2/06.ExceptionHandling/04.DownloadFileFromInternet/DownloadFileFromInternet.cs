using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Timers;

namespace _04.DownloadFileFromInternet
{
    class DownloadFileFromInternet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading, please wait...");
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    System.Timers.Timer t = new System.Timers.Timer();
                    t.Interval = 1000;
                    t.Elapsed += t_Elapsed;
                    t.Start();

                    //WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += webClient_DownloadCompleted;
                    webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
                    webClient.DownloadFileAsync(new Uri("http://www.devbg.org/img/Logo-BASD.jpg"), "download.jpg");

                    Console.ReadKey();
                }
                catch (WebException)
                {
                    Console.WriteLine("Invalid address or an error occured while downloading.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("The local copy is used by another program. Could not save to the specific local file.");
                }

             }
        }

        private static void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Write("\r");
        }

        static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //Event is triggered when new bytes are received
            Console.WriteLine("{0} of {1} byted download ({2}%)", e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage);
            Thread.Sleep(50);
        }

        static void webClient_DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Console.WriteLine("Download finished successfully!");
                Console.Write("Press any key to quit.");
            }
            else
            {
                Console.WriteLine("Could not download file: " + e.Error.Message);
            }
        }

    }
}
