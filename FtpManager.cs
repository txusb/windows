using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SerialConnect
{
    class FtpManager
    {
        public static string mcuname()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Drive/USB PAD/Firmware/MCU/");
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                String file = reader.ReadToEnd();
                Console.WriteLine(file);
                
                Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
                char[] delimiterChars = { ' ' };

                String[] spi = file.Split(delimiterChars);
                reader.Close();
                response.Close();
                SensorRecord.SensorCode_Version = spi[spi.Length - 1];
                return spi[spi.Length - 1];
            }
            catch (Exception e) { Console.WriteLine(e.Message); return "nodata"; }
        }
        public static bool DonloadMcu()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Drive/USB PAD/Firmware/MCU/" + mcuname());
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                Command.updateData = reader.ReadToEnd().Replace(" ", "").Replace("\r", "").Replace("\n", "");
                Console.WriteLine($"Download Mcu Complete, status {response.StatusDescription}");
                reader.Close();
                response.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); return false;
            }
        }
        public static bool DonloadS19(String s19)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Database/SensorCode/SIII/" + s19 + "/" + S19name(s19));
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                Command.FileData = reader.ReadToEnd().Replace(" ", "").Replace("\r", "").Replace("\n", "");
                Console.WriteLine($"Download s19 Complete, status {response.StatusDescription}");
                reader.Close();
                response.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); return false;
            }

        }
        public static String S19name(String s19)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Database/SensorCode/SIII/" + s19 + "/");
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                String file = reader.ReadToEnd();
                Console.WriteLine(file);
                Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
                char[] delimiterChars = { ' ' };

                String[] spi = file.Split(delimiterChars);
                reader.Close();
                response.Close();
                SensorRecord.SensorCode_Version = spi[spi.Length - 1];
                return spi[spi.Length - 1];
            }
            catch (Exception e) { Console.WriteLine(e.Message); return "nodata"; }

        }
        public static bool Donloadmmy()
        {
            try
            {
                String mmyname = Mmyname();
                StreamReader str = new StreamReader("Mmyversion.txt");
                String ss = str.ReadToEnd();
                if (ss.Contains(mmyname))
                {
                    Console.WriteLine("免下載");
                    str.Close(); return true;
                }
                str.Close();
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Database/MMY/EU/" + mmyname);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                String LocalDestinationPath = "usb_tx_mmy.db";
                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                using (FileStream writer = new FileStream(LocalDestinationPath, FileMode.Create))
                {

                    long length = response.ContentLength;
                    int bufferSize = 8192;
                    int readCount;
                    byte[] buffer = new byte[8192];

                    readCount = responseStream.Read(buffer, 0, bufferSize);
                    while (readCount > 0)
                    {
                        writer.Write(buffer, 0, readCount);
                        readCount = responseStream.Read(buffer, 0, bufferSize);
                    }
                }

                Console.WriteLine($"Download Complete, status {response.StatusDescription}");

                reader.Close();
                response.Close();
                WriteShare(mmyname);
                return true;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }
        public static String Mmyname()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://35.240.51.141:21/Database/MMY/EU/");
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("orangerd", "orangetpms(~2");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                String file = reader.ReadToEnd();
                Console.WriteLine(file);

                Console.WriteLine($"Directory List Complete, status {response.StatusDescription}");
                char[] delimiterChars = { ' ' };

                String[] spi = file.Split(delimiterChars);
                reader.Close();
                response.Close();
                SensorRecord.DB_Version = spi[spi.Length - 1];
                return spi[spi.Length - 1];
            }
            catch (Exception e) { Console.WriteLine(e.Message); return "nodata"; }

        }
        public static void CreatShare()
        {
            if (!File.Exists("Mmyversion.txt"))
            {
                FileStream fs = File.Create("Mmyversion.txt");
                fs.Close();
            };
        }
        public static void WriteShare(String mmtname)
        {
            string[] lines = { mmtname };

            // Set a variable to the Documents path.


            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("Mmyversion.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }
        public static void Writrlanguage(String mmtname)
        {
            string[] lines = { mmtname };

            // Set a variable to the Documents path.


            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("language.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }
        public static string GetLanguage()
        {
            if (!File.Exists("language.txt"))
            {
                FileStream fs = File.Create("language.txt");
                fs.Close();
                return "English";
            };
            StreamReader str = new StreamReader("language.txt");
            String ss = str.ReadToEnd().Replace("\r\n", "");
            str.Close();
            if (ss.Length > 2) { return ss; } else { return "English"; }

        }
    }
}
