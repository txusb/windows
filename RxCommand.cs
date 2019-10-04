using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ExtensionMethods;
namespace SerialConnect
{
    class RxCommand
    {
        public  string ToHexString(byte[] bytes)
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
            while (hexString.substring(hexString.Length-1,hexString.Length).Equals("0")&& hexString.Length>0) { hexString = hexString.substring(0, hexString.Length-2); }
            return hexString;
        }
        public  ArrayList A0X10(byte[] data)
        {
            if (data.Length > 21)
            {
                String a = ToHexString(data);
                a = a.substring(10, a.Length - 6);
                ArrayList re = new ArrayList();
                for (int i = 0; i < a.Length / 28; i++)
                {
                    String SENSOR_MODEL = a.substring(i * 28 + 2, i * 28 + 6);
                    String APP_VERSION = a.substring(i * 28 + 6, i * 28 + 8);
                    String LIB_VERSION = a.substring(i * 28 + 12, i * 28 + 14);
                    String STATION = a.substring(i * 28 + 26, i * 28 + 28);
                    re.Add(SENSOR_MODEL);
                    re.Add(APP_VERSION);
                    re.Add(LIB_VERSION);
                    re.Add(STATION);
                }
                return re;
            }
            else
            {
                String a = ToHexString(data);
                String SENSOR_MODEL = a.substring(12, 16);
                String APP_VERSION = a.substring(16, 18);
                String LIB_VERSION = a.substring(22, 24);
                ArrayList re = new ArrayList();
                re.Add(SENSOR_MODEL);
                re.Add(APP_VERSION);
                re.Add(LIB_VERSION);
                return re;
            }
        }
        public  String RX(byte[] data, Command command)
        {
            command.Rx = ToHexString(data);
            if (data.Length == 21 && data[2] == 0x10 && data[20] == 0x0A)
            {
                ArrayList aox = A0X10(data);
                String spn = "SensorModel:" + aox[0] + "\nAppVersion:" + aox[1] + "\nLib:" + aox[2];
                command.SensorModel = (string)aox[0];
                command.AppVersion = (string)aox[1];
                command.Lib = (string)aox[2];
                return spn;
            }
            if (data.Length > 21 && data[1] == (byte)0xFE && data[data.Length - 1] == (byte)0x0A && data[2] == 0x10)
            {
                ArrayList aox = A0X10(data);
                String spn = "";
                String tmpSensorModel = "";
                String tmpAppVersion = "";
                String tmpLib = "";
                for (int i = 0; i < aox.Count / 4; i++)
                {
                    spn = spn + "SensorModel:" + aox[i * 4] + "\nAppVersion:" + aox[i * 4 + 1] + "\nLib:" + aox[i * 4 + 2]+ "\n" + "Station:" + aox[i * 4 + 3] + "\n\n";
                    if (i == 0)
                    {
                        tmpSensorModel = (string)aox[0];
                        tmpAppVersion = (string)aox[1];
                        tmpLib = (string)aox[2];
                    }
                    else
                    {
                        if (!tmpSensorModel.Equals(aox[i * 4]) && !tmpAppVersion.Equals(aox[i * 4 + 1]) && !tmpLib.Equals(aox[i * 4 + 2]))
                        {
                            tmpSensorModel = "noequal";
                            tmpAppVersion = "noequal";
                            tmpLib = "noequal";
                            spn = spn + "SensorModel:" + aox[i * 4] + "\nAppVersion:" + aox[i * 4 + 1] + "\nLib:" + aox[i * 4 + 2] + "\n" + "Station:" + aox[i * 4 + 3] + "\n不一樣\n";
                        }
                    }
                }
                command.SensorModel = tmpSensorModel;
                command.AppVersion = tmpAppVersion;
                command.Lib = tmpLib;
                return spn;
            }

            return ToHexString(data);
        }
    }
}
