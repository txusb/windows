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
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Drive/USB%20PAD/Firmware/MCU/");
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {
                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                        if (strBuf.Contains("HREF=\""))
                        {
                            strBuf = strBuf.substring(strBuf.LastIndexOf("HREF=\"") + 6, strBuf.Length);
                            return strBuf.substring(strBuf.IndexOf(">") + 1, strBuf.IndexOf("<"));
                        }

                    }
                }
                return "nodata";
            }
            catch (Exception e) { Console.WriteLine(e.Message); return "nodata"; }
        }
        public static bool DonloadMcu()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Drive/USB%20PAD/Firmware/MCU/" + mcuname());
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                Command.updateData = reader.ReadToEnd().Replace(" ", "").Replace("\r", "").Replace("\n", "");
                Console.WriteLine($"Download Mcu Complete, status ");
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
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Database/SensorCode/SIII/" + s19 + "/" + S19name(s19));
                WebResponse response = req.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                Command.FileData = reader.ReadToEnd().Replace(" ", "").Replace("\r", "").Replace("\n", "");
                Console.WriteLine($"Download s19 Complete, status");
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
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Database/SensorCode/SIII/" + s19+"/");
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {
                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                        if (strBuf.Contains("HREF=\""))
                        {
                            strBuf = strBuf.substring(strBuf.LastIndexOf("HREF=\"") + 6, strBuf.Length);
                            return strBuf.substring(strBuf.IndexOf(">") + 1, strBuf.IndexOf("<"));
                        }

                    }
                }
                return "nodata";
            }
            catch (Exception e) { Console.WriteLine(e.Message); return "nodata"; }

        }
        public static bool Donloadmmy()
        {
            try
            {
                String ArUrl = "EU";
                switch (FtpManager.GetArea())
                {
                    case "EU":
                        ArUrl = "EU";
                        break;
                    case "North America":
                        ArUrl = "US";
                        break;
                    case "台灣":
                        break;
                    case "中國大陸":
                        break;

                }
                String mmyname = Mmyname(ArUrl);
                StreamReader str = new StreamReader("Mmyversion.txt");
                String ss = str.ReadToEnd();
                if (ss.Contains(mmyname))
                {
                    Console.WriteLine("免下載");
                    str.Close(); return true;
                }
                str.Close();
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Database/MMY/"+ ArUrl + "/" + mmyname);
                String LocalDestinationPath = "usb_tx_mmy.db";
                // This example assumes the FTP site uses anonymous logon.
                WebResponse response = req.GetResponse();
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

                Console.WriteLine($"Download Complete, status ");
                reader.Close();
                response.Close();
                WriteShare(mmyname);
                return true;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }
        public static String Mmyname(String ArUrl)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://bento2.orange-electronic.com/Orange%20Cloud/Database/MMY/"+ ArUrl + "/");
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {
                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                        if (strBuf.Contains("HREF=\"")) {
                            strBuf = strBuf.substring(strBuf.LastIndexOf("HREF=\"") + 6, strBuf.Length);
                            return strBuf.substring(strBuf.IndexOf(">") + 1, strBuf.IndexOf("<"));
                        }
                        
                    }
                }
                return "nodata";
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
        public static void WritrArea(String mmtname)
        {
            string[] lines = { mmtname };

            // Set a variable to the Documents path.


            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("area.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }
        public static string GetArea()
        {
            if (!File.Exists("area.txt"))
            {
                FileStream fs = File.Create("area.txt");
                fs.Close();
                return "EU";
            };
            StreamReader str = new StreamReader("area.txt");
            String ss = str.ReadToEnd().Replace("\r\n", "");
            str.Close();
            if (ss.Length > 2) { return ss; } else { return "EU"; }

        }
    }

}
