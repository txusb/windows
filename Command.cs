using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionMethods;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using static SerialConnect.Form1;

namespace SerialConnect
{
    class Command
    {
        public String Appver = "";
        public String AppverInspire = "";
        public String Boover = "";
        public string tmprx = "";
        public ArrayList FALSE_CHANNEL = new ArrayList();
        public ArrayList BLANK_CHANNEL = new ArrayList();
        public ArrayList CHANNEL_BLE = new ArrayList();
        public System.IO.Ports.SerialPort serialPort;
        public String Rx = "";
        public static String updateData = "";
        public String SensorModel = "nodata";
        public String AppVersion = "nodata";
        public String Lib = "nodata";
        public static String FileData = "";
        public int IC = 0;
        public String ID = "";
        public int check = 11;
        public void SendData(string data, int chk)
        {
            
            Console.WriteLine("Tx:" + data);  
            check = chk;
            tmprx = "";
            Rx = "";
            if (serialPort.IsOpen)
            {
                byte[] a = Getbytes(data);
                serialPort.Write(a, 0, a.Length);
                Console.WriteLine("serialPort:" + serialPort.BytesToWrite);
            }
        }
        
        private byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
          
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }
        protected byte[] Getbytes(string HexString)
        {
         
            int byteLength = HexString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { HexString[j], HexString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }
        public static string ToHexString(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    str.Append(bytes[i].ToString("X2"));
                }
                hexString = str.ToString();
            }
            return hexString;
        }
        public String getCRC16(String source)
        {
            int crc = 0x0000;            // 初始值
            int polynomial = 0x1021;             // 校验公式 0001 0000 0010 0001
            byte[] bytes = Getbytes(source.substring(2, source.Length - 6));  //把普通字符串转换成十六进制字符串

            foreach (byte b in bytes)
            {
                for (int i = 0; i < 8; i++)
                {
                    Boolean bit = ((b >> (7 - i) & 1) == 1);
                    Boolean c15 = ((crc >> 15 & 1) == 1);
                    crc <<= 1;
                    if (c15 ^ bit)
                        crc ^= polynomial;
                }
            }
            crc &= 0xffff;
            String result = crc.ToString("X");
            while (result.Length < 4)
            {        //CRC检验一般为4位，不足4位补0
                result="0"+result;
            }
            return source.Replace("XXXX", result.ToUpper());
        }
        public  String addcheckbyte(String com)
        {
            byte[] a = Getbytes(com);
            byte checkbyte = a[0];
            for (int i = 1; i < a.Length - 2; i++)
            {
                checkbyte ^= a[i];
            }
            a[a.Length - 2] = checkbyte;
            return ToHexString(a);
        }
        public bool A0xEB()
        {
            try
            {
                SendData("0AFEEB000D4F52414E474554504D533A72F5", 0);
                DateTime past = DateTime.Now;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 5) { return false; }
                    if ((Rx.Equals("F5FEEB0005C0003B480A") || Rx.Equals("F5FEEB0007C000A001597F0A")))
                    {
                        return true;
                    }
                }
            }
            catch (Exception e) {Console.WriteLine(e.Message); return false; }
        }
        public bool Command01()
        {
            try
            {
                SendData("0A000100094F52414E4745ACF3F5", 32);
                DateTime past = DateTime.Now;
                int fal = 0;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 2)
                    {
                        SendData("0A000100094F52414E4745ACF3F5", 32);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal > 3) { return false; }
                    if (Rx.Length == 32)
                    {
                        Appver = Rx.substring(20, 24);
                        Boover = Rx.substring(16, 20);
                        return true;
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }
        public int HandShake(String mpass)
        {
            //0代表失敗
            //1模組在Boot loader流程
            //2模組在主程式流程
            //3在app中
            try
            {
                String command = addcheckbyte("0A" + mpass + "000030000F5");
                SendData(command, 0);
                DateTime past = DateTime.Now;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 0.5) { return -1; }
                    if (Rx.Length == 14 && Rx.Equals("F5" + mpass + "0000311E70A"))
                    {
                        return 0;
                    }
                    if (Rx.Length == 14 && Rx.Equals(addcheckbyte("F5" + mpass + "0000321000A")))
                    {
                        return 1;
                    }
                    if (Rx.Length == 22)
                    {
                        return 2;
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); return -1; }
        }
        public Boolean GoProgram(String mcpass)
        {
            try
            {
                String a = "0A" + mcpass + "300030000F5";
                SendData(addcheckbyte(a), 14);
                DateTime past = DateTime.Now;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 3) { return false; }
                    if (Rx.Length == 14 && Rx.Equals(addcheckbyte("F5" + mcpass + "1000300E70A"))) { return true; }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }
        public Boolean checker(String data, String mcpass,String len,bool islatest)
        {
            while (len.Length < 4) {
                len = "0" + len;
            }
            int check = 18;
            if (islatest) { check = 14; }
            SendData(addcheckbyte(data), check);
            string compare = addcheckbyte("F5" + mcpass + "20005" + len + "00F20A");
            ////F5020005000000F20A
            //Console.WriteLine(compare+"是否一樣"+ "F5020005000000F20A".Equals(compare));
            try
            {
                DateTime past = DateTime.Now;
                int fal = 0;
                while (fal < 5)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 0.5)
                    {
                        past = DateTime.Now;
                        SendData(addcheckbyte(data), check);
                        fal++;
                    }
                    if ( Rx.Equals(compare)||Rx.Equals("F50B000300FD0A")|| Rx.Equals(addcheckbyte("F51B000300FD0A")))
                    {
                        return true;
                    }
                    Thread.Sleep(20);
                }
                return false;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }

            public Boolean WriteFlash( int Ind,  String mcpass, Update u,Form1 fo)
        {
           
            try
            {
                int Long = 0;
                if (updateData.Length % Ind == 0)
                {
                    Long = updateData.Length / Ind;
                }
                else { Long = updateData.Length / Ind + 1; }
                Console.WriteLine("總行數" + Long);
                for (int i = 0; i < Long; i++)
                {
                    if (i == Long - 1)
                    {
                        Console.WriteLine("行數" + i);
                        String data = ToHexString(System.Text.Encoding.Default.GetBytes(updateData.substring(i * Ind, updateData.Length)));
                        int length = Ind + 4;
                        checker(Convvvert(data, length.ToString("X"), mcpass, i.ToString("X")), mcpass, i.ToString("X"),true);
                        if (mcpass.Equals("0")) { fo.BeginInvoke(u, new Object[] { true,50 }); } else { fo.BeginInvoke(u, new Object[] { true,100 }); }
                        return true;
            }else
            {
                String data = ToHexString(System.Text.Encoding.Default.GetBytes(updateData.substring(i * Ind, i * Ind + Ind)));
                        Console.WriteLine("行數" + i);
                        int length = Ind + 4;
                float finalI = i;
                float finalLong = Long;
                        if (mcpass.Equals("0")) { fo.BeginInvoke(u, new Object[] { true, (int)(finalI / finalLong * 50) }); } else { fo.BeginInvoke(u, new Object[] { true, (int)(finalI / finalLong * 50+50) }); }
                       
                        if (!checker(Convvvert(data, length.ToString("X"), mcpass, i.ToString("X")), mcpass, i.ToString("X"), false))
            {
                return false;
            }
        }
    }
            return true;
        }catch(Exception e){ Console.WriteLine(e.Message); return false;}
    }

 

        public String Convvvert(String data, String length, String mcpass,String place)
        {
            String command = "0A" + mcpass + "2LYX00F5";
            while (place.Length<4) {
                place = "0" + place;
            }
            while (length.Length < 4)
            {
                length = "0" + length;
            }
            command = addcheckbyte(command.Replace("L", length).Replace("X", data).Replace("Y",place));
            return command;
        }
        public Boolean Command03()
        {
                int check = 22;
                Rx = "";
                SendData((getCRC16("0AFE03000754504D53XXXXF5")), check);
            DateTime past = DateTime.Now;
            int fal = 0;
                while (true)
                {
                DateTime now = DateTime.Now;
                double time = (now - past).TotalSeconds;
                    if (time > 1)
                    {
                        SendData((getCRC16("0AFE03000754504D539CC8F5")), check);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal == 1) { return false; }
                    if (Rx.Length == check)
                    {
                        IC = ((int)Getbytes(Rx.substring(12, 14))[0]) / 2;
                        return true;
                    }
                }
            }
        public SensorBean Command_11(int ic, int channel, String version)
        {
            SensorBean sensorBean = new SensorBean();
            int check = 30;
                ID = "Unlinked";
                Rx = "";
            String CC = "";
            if (version.Equals(SensorBean._315))
            {
                CC = "1" + channel;
            }
            else if (version.Equals(SensorBean._433))
            {
                CC = "0" + channel;
            }
            String commeand = "0ASS110004CCXXXXF5".Replace("SS", ToHexString(new byte[] { (byte)ic })).Replace("CC", CC);
                SendData((getCRC16(commeand)), 0);
             
                DateTime past = DateTime.Now;
                int fal = 0;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 2)
                    {
                        SendData((getCRC16(commeand)), 0);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal == 1) { return sensorBean; }
                    if (Rx.Length >= check)
                    {
                    sensorBean.id = Rx.substring(14, 22);
                    if (Rx.substring(24, 25).Equals("0"))
                    {
                        sensorBean.boot_var = SensorBean._433;
                    }
                    else if (Rx.substring(24, 25).Equals("1"))
                    {
                        sensorBean.boot_var = SensorBean._315;
                    }
                    else if (Rx.substring(24, 25).Equals("A"))
                    {
                        sensorBean.boot_var = SensorBean._雙頻;
                    }
                    sensorBean.canPr = version.Equals(sensorBean.boot_var) || sensorBean.boot_var.Equals(SensorBean._雙頻);
                    sensorBean.result = !sensorBean.id.Equals("00018001");
                    return sensorBean;
                }
                }
            }
        public Boolean checkcommand(String a)
        {
            if (getBit(Getbytes(a)[0]).substring(7, 8).Equals("0")) {
                return true; } else { return false;  }
        }
        public static String getBit(byte by)
        {
            String sb ="";
            sb= sb + ((by >> 7) & 0x1);
            sb = sb + ((by >> 6) & 0x1);
            sb = sb + ((by >> 5) & 0x1);
            sb = sb + ((by >> 4) & 0x1);
            sb = sb + ((by >> 3) & 0x1);
            sb = sb + ((by >> 2) & 0x1);
            sb = sb + ((by >> 1) & 0x1);
            sb =sb + ((by >> 0) & 0x1);
            return sb;
        }
        public String writeid = "";
        public Boolean writesensorID(String id)
        {
                Rx = "nodata";
                SendData((getCRC16("0A0012000801IDXXXXF5".Replace("ID", id))), 30);
                DateTime past = DateTime.Now;
                while (true)
                {
                    if (Rx.Length == 30 && Rx.substring(14, 22).Equals(id))
                    {
                        writeid = Rx.substring(14, 22);
                        break;
                    }
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 5)
                    {
                        return false;
                    }
                }
                return true;
            }
        public Boolean ReadSensorId()
        {
                SendData((getCRC16("0A0010000754504D53XXXXF5")), 42);
                return true;
        }
        public Boolean ClearSensor()
        {
                SendData((getCRC16("0A0014000D4F52414E474554504D53XXXXF5")), 34);
                DateTime past = DateTime.Now;
                int fal = 0;
                while (!Rx.substring(4, 6).Equals("14"))
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 1)
                    {
                        SendData((getCRC16("0A0014000D4F52414E474554504D53XXXXF5")), 34);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal > 3) { return false; }
                }
                return true;
            }
        public Boolean ProgramSensor( String Lf)
        {
                SendData((getCRC16("0A00150008LF154504D53XXXXF5".Replace("LF", Lf))), 30);
            DateTime past = DateTime.Now;
            while (true)
                {
                    if (Rx.Length > 8 && Rx.substring(Rx.Length - 8, Rx.Length - 8 + 2).Equals("3E")) { return true; }
                    if (Rx.Length > 12 && Rx.substring(12, 14).Equals("01") || Rx.Length > 12 && Rx.substring(12, 14).Equals("02") || Rx.Length > 12 && Rx.substring(12, 14).Equals("03"))
                    {
                        ClearSensor();
                        return false;
                    }
                DateTime now = DateTime.Now;
                double time = (now - past).TotalSeconds;
                if (time > 10)
                    {
                        return false;
                    }
                }
            }
        public String AddCommand(String data, int Long)
        {
            String length = (data.Length / 2 + 5).ToString("X");
            while (length.Length < 4)
            {        //CRC检验一般为4位，不足4位补0
                length= "0"+length;
            }
            String row = Long.ToString("X"); 
            while (row.Length < 2)
            {
                row = "0" + row;
            }
            String TmpCommand = "0A0013" + length + row + data + data.substring(18, 20) + "XXXXF5";
            return getCRC16(TmpCommand);
        }
        public Boolean LogData()
        {
            Rx = "nodata";
                int ln = 2048;
           
                int Long = 0;
                if (FileData.Length % ln == 0)
                {
                    Long = FileData.Length / ln;
                }
                else { Long = FileData.Length / ln + 1; }
                for (int i = 0; i < Long; i++)
                {
                    Rx = "nodata";
              
                if (i == Long - 1)
                    {
                        String a = FileData.substring(i * ln, FileData.Length);
                        if (a.Length >= 20) { SendData((AddCommand(a, i)), 34); }
                    }
                    else
                    {
                        SendData((AddCommand(FileData.substring(i * ln, i * ln + ln), i)), 34);
                    }
                    DateTime past = DateTime.Now;
                    while (true)
                    {
                        if (Rx.Length > 12 && checkcommand(Rx.substring(10, 12)))
                        {
                            break;
                        }
                        DateTime now = DateTime.Now;
                        double time = (now - past).TotalSeconds;
                        if (time > 3)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        public Boolean CheckS19()
        {
                
                if (SensorModel.Equals(FileData.substring(4, 8)) && AppVersion.Equals(FileData.substring(8, 10)) && Lib.Equals(FileData.substring(0, 2)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public Boolean ProgramStep(String filename, String Lf)
        {
            ClearChech();
            Rx = "nodata";
                ReadSensorId();
            DateTime past = DateTime.Now;
                while (SensorModel.Equals("nodata") && AppVersion.Equals("nodata") && Lib.Equals("nodata"))
                {
                DateTime now = DateTime.Now;
                double time = (now - past).TotalSeconds;
                if (time > 10)
                    {
                        return false;
                    }
                }
                if (CheckS19())
                {
                    if (ProgramSensor(Lf)) { return true; } else { return false; }
                }
                else
                {
                    if (!ClearSensor()) { return false; }
                    if (!LogData()) { return false; }
                    if (ProgramSensor(Lf)) { return true; } else { return false; }
                }
        }
        public void ClearChech()
        {
            FALSE_CHANNEL = new ArrayList();
            CHANNEL_BLE = new ArrayList();
            BLANK_CHANNEL = new ArrayList();
            SensorModel = "nodata";
            AppVersion = "nodata";
            Lib = "nodata";
            Rx = "nodata";
        }
        public Boolean Command14()
        {
                int check = (8 + 6 * IC) * 2;
                SendData((getCRC16("0AFE14000D4F52414E474554504D53XXXXF5")), check);
                DateTime past = DateTime.Now;
                int fal = 0;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 2)
                    {
                        SendData((getCRC16("0AFE14000D4F52414E474554504D53XXXXF5")), check);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal > 3) { return false; }
                    if (Rx.Length == check)
                    {
                        Boolean g = true;
                        for (int i = 0; i < IC; i++)
                        {
                            String tmp = Rx.substring(10, Rx.Length - 6);
                            if (checkcommand(tmp.substring(i * 12, i * 12 + 2))) { g = false; }
                        }
                        return g;
                    }
                }
            }
        public Boolean ProgramAll(String Lf)
        {
            ClearChech();
                if (!Command03()) { return false; }
                if (!Command10_FE()) { return false; }
                if (CheckS19())
                {
                    if (Command15(Lf)) { return true; } else { return false; }
                }
                else
                {
                    if (!Command14()) { return false; }
                    if (!LogData()) { return false; }
                    if (!Command17()) { return false; }
                    if (Command15(Lf)) { return true; } else { return false; }
            }
        }
        public Boolean Command17()
        {
                int check = (8 + 10 * (IC - 1)) * 2;
                SendData((getCRC16("0AFE1700094F52414E4745A7C4F5")), check);
                DateTime past = DateTime.Now;
                int fal = 0;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 10)
                    {
                        SendData((getCRC16("0AFE1700094F52414E4745A7C4F5")), check);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal > 1) { return false; }
                    if (Rx.Length == check)
                    {
                        Boolean g = true;
                        for (int i = 0; i < IC - 1; i++)
                        {
                            String tmp = Rx.substring(10, Rx.Length - 6);
                            if (!checkcommand(tmp.substring(i * 14, i * 14 + 2)))
                            {
                                g = false;
                            }
                        }
                        return g;
                    }
                }
        }
        public Boolean Command15(String Lf)
        {
                Rx = "";
                FALSE_CHANNEL = new ArrayList();
                CHANNEL_BLE = new ArrayList();
                BLANK_CHANNEL = new ArrayList();
                int check = (8 + (7 * 2 * IC)) * 2;
                SendData((getCRC16("0AFE150008LF154504D53XXXXF5".Replace("LF", Lf))), check);
                DateTime past = DateTime.Now;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 15)
                    {
                        return false;
                    }
                    if (Rx.Length == check)
                    {
                        Boolean g = true;
                        for (int i = 0; i < IC * 2; i++)
                        {
                            String tmp = Rx.substring(10, Rx.Length - 6);
                            if (!checkcommand(tmp.substring(i * 14, i * 14 + 2)))
                            {
                                g = false;
                                Console.WriteLine("失敗channel" + tmp.substring(i * 14 + 2, i * 14 + 4));
                                if (tmp.substring(i * 14 + 4, i * 14 + 12).Equals("00018001"))
                                {
                                    BLANK_CHANNEL.Add(tmp.substring(i * 14 + 2, i * 14 + 4));
                                }
                                else
                                {
                                    FALSE_CHANNEL.Add(tmp.substring(i * 14 + 2, i * 14 + 4));
                                }
                            }
                            else
                            {
                                CHANNEL_BLE.Add(tmp.substring(i * 14 + 2, i * 14 + 4) + "." + tmp.substring(i * 14 + 4, i * 14 + 12));
                            }
                        }
                        return g;
                    }
                }
        }
        public Boolean Command10_FE()
        {
                int check = (14 * IC + 8) * 2;
                SendData((getCRC16("0AFE10000754504D537331F5")), check);
                DateTime past = DateTime.Now;
                int fal = 0;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 2)
                    {
                        SendData((getCRC16("0AFE10000754504D537331F5")), check);
                        past = DateTime.Now;
                        fal++;
                    }
                    if (fal > 3) { return false; }
                    if (Rx.Length == check && !SensorModel.Equals("nodata") && !AppVersion.Equals("nodata") && !Lib.Equals("nodata"))
                    {
                        return true;
                    }
                }
        }
        public Boolean ProgramAll( String ID1, String ID2, String ID3, String ID4, String Lf)
        {
            ClearChech();
                if (!Command03()) { return false; }
                if (!Command10_FE()) { return false; }
                if (CheckS19())
                {
                    if (Command25(ID1, ID2, ID3, ID4, Lf)) { return true; } else { return false; }
                }
                else
                {
                    if (!Command14()) { return false; }
                    if (!LogData()) { return false; }
                    if (!Command17()) { return false; }
                    if (Command25(ID1, ID2, ID3, ID4, Lf)) { return true; } else { return false; }
                }   
        }
        public Boolean Command25(String ID1, String ID2, String ID3, String ID4, String Lf)
        {
                Rx = "";
                FALSE_CHANNEL = new ArrayList();
                CHANNEL_BLE = new ArrayList();
                BLANK_CHANNEL = new ArrayList();
                String command = "0AFE250017LF1ID1LF2ID2LF3ID3LF4ID4XXXXF5".Replace("LF", Lf);
        
            int check = 72;
                command = command.Replace("ID1", ID1).Replace("ID2", ID2).Replace("ID3", ID3).Replace("ID4", ID4);
            Console.WriteLine("HEX:" + command);
            SendData((getCRC16(command)), check);
                DateTime past = DateTime.Now;
                while (true)
                {
                    DateTime now = DateTime.Now;
                    double time = (now - past).TotalSeconds;
                    if (time > 15)
                    {
                        return false;
                    }
                    if (Rx.Length == check)
                    {
                        Boolean g = true;
                        for (int i = 0; i < 4; i++)
                        {
                            String tmp = Rx.substring(10, Rx.Length - 6);
                            if (!checkcommand(tmp.substring(i * 14, i * 14 + 2)))
                            {
                                g = false;
                            
                                Console.WriteLine(" 失敗channel" + tmp.substring(i * 14 + 2, i * 14 + 4));
                                if (tmp.substring(i * 14 + 4, i * 14 + 12).Equals("00018001"))
                                {
                                    BLANK_CHANNEL.Add(tmp.substring(i * 14 + 2, i * 14 + 4));
                                }
                                else
                                {
                                    FALSE_CHANNEL.Add(tmp.substring(i * 14 + 2, i * 14 + 4));
                                }
                            }
                            else
                            {
                                Console.WriteLine("成功channel" + tmp.substring(i * 14 + 2, i * 14 + 4));
                                CHANNEL_BLE.Add(tmp.substring(i * 14 + 2, i * 14 + 4) + "." + tmp.substring(i * 14 + 4, i * 14 + 12));
                            }
                        }
                        return g;
                    }
                }
        }
     
 
    }

}

