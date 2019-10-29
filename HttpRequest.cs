using ExtensionMethods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SerialConnect
{
    class HttpRequest
    {
        public static void Upload_IDCopyRecord(String make, String model, String year, String startime, String Endtime, String SreialNum, String Devicetype, String Mode, int SensorCount, String position
    , ArrayList idrecord)
        {
            try
            {
                string parm = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\n" +
"  <soap12:Body>\n" +
"    <Upload_IDCopyRecord xmlns=\"http://tempuri.org/\">\n" +
"      <SerialNum>" + SreialNum + "</SerialNum>\n" +
"      <data>\n" +
"        <Device_BurnIDCopy>\n" +
"          <DeviceInfo>\n" +
"            <enum_DeviceType>" + Devicetype + "</enum_DeviceType>\n" +
"            <SerialNum>" + SreialNum + "</SerialNum>\n" +
"            <enum_SensorMode>" + Mode + "</enum_SensorMode>\n" +
"            <DateTime_Start>" + startime + "</DateTime_Start>\n" +
"            <DateTime_End>" + Endtime + "</DateTime_End>\n" +
"            <SensorCount>" + SensorCount + "</SensorCount>\n" +
"            <enum_BurnPosition>" + position + "</enum_BurnPosition>\n" +
"          </DeviceInfo>\n" +
"          <CarInfo>\n" +
"            <Type>" + make + "</Type>\n" +
"            <Model>" + model + "</Model>\n" +
"            <Year>" + year + "</Year>\n" +
"            <CarNum>nodata</CarNum>\n" +
"          </CarInfo>\n" +
"          <TireInfo>\n" +
"            <TireBrand>nodata</TireBrand>\n" +
"            <TireModel>nodata</TireModel>\n" +
"            <TireProcDate>nodata</TireProcDate>\n" +
"          </TireInfo>\n" +
"          <ConsumerInfo>\n" +
"            <Name>nodata</Name>\n" +
"            <Age>0</Age>\n" +
"            <Sex>男</Sex>\n" +
"            <Tel>nodata</Tel>\n" +
"            <Email>nodata</Email>\n" +
"            <Continent>nodata</Continent>\n" +
"            <Country>nodata</Country>\n" +
"            <State>nodata</State>\n" +
"            <City>nodata</City>\n" +
"            <Street>nodata</Street>\n" +
"          </ConsumerInfo>\n" +
"          <Record>\n";
                foreach (SensorRecord record in idrecord)
                {
                    parm = parm + "<IDCopy_Record>\n"
                 + " <SensorID>" + record.SensorID + "</SensorID>\n"
                    + " <Car_SensorID>" + record.Car_SensorID + "</Car_SensorID>\n"
                 + "<IsSuccess>" + record.IsSuccess + "</IsSuccess>\n"
                           + "<ModelNo >" + record.ModelNo + "</ModelNo >\n"
                                     + "<enum_BurnResult>" + record.enum_BurnResult + "</enum_BurnResult>\n"
             + "</IDCopy_Record>\n";
                }
                parm = parm + "</Record>\n" +
"        </Device_BurnIDCopy>\n" +
"      </data>\n" +
"    </Upload_IDCopyRecord>\n" +
"  </soap12:Body>\n" +
"</soap12:Envelope>";
                Console.WriteLine(parm);
                byte[] bs = Encoding.UTF8.GetBytes(parm);    //参数转化为ascii码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bento2.orange-electronic.com/App_Asmx/ToolApp.asmx");
                req.Method = "POST";    //确定传值的方式，此处为post方式传值
                req.ContentType = "application/soap+xml; charset=utf-8";
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {

                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("錯誤" + e.Message); }
        }
        public static void Upload_ProgramRecord(String make, String model, String year, String startime, String Endtime, String SreialNum, String Devicetype, String Mode, int SensorCount, String position
  , ArrayList idrecord)
        {
            try
            {
                string parm = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\n" +
"  <soap12:Body>\n" +
"    <Upload_VersionUpdateRecord xmlns=\"http://tempuri.org/\">\n" +
"      <SerialNum>" + SreialNum + "</SerialNum>\n" +
"      <data>\n" +
"        <Device_BurnVersionUpdate>\n" +
"          <DeviceInfo>\n" +
"            <enum_DeviceType>" + Devicetype + "</enum_DeviceType>\n" +
"            <SerialNum>" + SreialNum + "</SerialNum>\n" +
"            <enum_SensorMode>" + Mode + "</enum_SensorMode>\n" +
"            <DateTime_Start>" + startime + "</DateTime_Start>\n" +
"            <DateTime_End>" + Endtime + "</DateTime_End>\n" +
"            <SensorCount>" + SensorCount + "</SensorCount>\n" +
"            <enum_BurnPosition>" + position + "</enum_BurnPosition>\n" +
"          </DeviceInfo>\n" +
"          <CarInfo>\n" +
"            <Type>" + make + "</Type>\n" +
"            <Model>" + model + "</Model>\n" +
"            <Year>" + year + "</Year>\n" +
"            <CarNum>nodata</CarNum>\n" +
"          </CarInfo>\n" +
"          <TireInfo>\n" +
"            <TireBrand>nodata</TireBrand>\n" +
"            <TireModel>nodata</TireModel>\n" +
"            <TireProcDate>nodata</TireProcDate>\n" +
"          </TireInfo>\n" +
"          <ConsumerInfo>\n" +
"            <Name>nodata</Name>\n" +
"            <Age>0</Age>\n" +
"            <Sex>男</Sex>\n" +
"            <Tel>nodata</Tel>\n" +
"            <Email>nodata</Email>\n" +
"            <Continent>nodata</Continent>\n" +
"            <Country>nodata</Country>\n" +
"            <State>nodata</State>\n" +
"            <City>nodata</City>\n" +
"            <Street>nodata</Street>\n" +
"          </ConsumerInfo>\n" +
"          <Record>\n";
                foreach (SensorRecord record in idrecord)
                {
                    parm = parm + "<VersionUpdate_Record>\n"
                  + " <SensorID>" + record.SensorID + "</SensorID>\n"
                 + "<IsSuccess>" + record.IsSuccess + "</IsSuccess>\n"
                           + "<ModelNo >" + record.ModelNo + "</ModelNo >\n"
                                     + "<enum_BurnResult>" + record.enum_BurnResult + "</enum_BurnResult>\n"
                                                + "<DB_Version>" + SensorRecord.DB_Version + "</DB_Version>\n"
                                                           + "<SensorCode_Version>" + SensorRecord.SensorCode_Version + "</SensorCode_Version>\n"
             + "</VersionUpdate_Record>\n";
                }
                parm = parm + "</Record>\n" +
"        </Device_BurnVersionUpdate>\n" +
"      </data>\n" +
"    </Upload_VersionUpdateRecord>\n" +
"  </soap12:Body>\n" +
"</soap12:Envelope>";
                Console.WriteLine(parm);
                byte[] bs = Encoding.UTF8.GetBytes(parm);    //参数转化为ascii码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bento2.orange-electronic.com/App_Asmx/ToolApp.asmx");
                req.Method = "POST";    //确定传值的方式，此处为post方式传值
                req.ContentType = "application/soap+xml; charset=utf-8";
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {

                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("錯誤" + e.Message); }
        }
        public static bool Register(String admin, String password, String SerialNum, String storetype, String companyname, String firstname, String lastname, String phone, String State, String city, String streat, String zp)
        {
            try
            {
                string parm = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                    "<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\n" +
                    "  <soap12:Body>\n" +
                    "    <Register xmlns=\"http://tempuri.org/\">\n" +
                    "      <Reg_UserInfo>\n" +
                    "        <UserID>" + admin + "</UserID>\n" +
                    "        <UserPwd>" + password + "</UserPwd>\n" +
                    "      </Reg_UserInfo>\n" +
                    "      <Reg_StoreInfo>\n" +
                    "        <StoreType>" + storetype + "</StoreType>\n" +
                    "        <CompName>" + companyname + "</CompName>\n" +
                    "        <FirstName>" + firstname + "</FirstName>\n" +
                    "        <LastName>" + lastname + "</LastName>\n" +
                    "        <Contact_Tel>" + phone + "</Contact_Tel>\n" +
                    "        <Continent>" + State + "</Continent>\n" +
                    "        <Country>" + State + "</Country>\n" +
                    "        <State>" + city + "</State>\n" +
                    "        <City>" + city + "</City>\n" +
                    "        <Street>" + streat + "</Street>\n" +
                    "        <CompTel>" + companyname + "</CompTel>\n" +
                    "      </Reg_StoreInfo>\n" +
                    "      <Reg_DeviceInfo>\n" +
                    "        <SerialNum>" + SerialNum + "</SerialNum>\n" +
                    "        <DeviceType>USBPad</DeviceType>\n" +
                    "        <ModelNum>phone</ModelNum>\n" +
                    "        <AreaNo>" + zp + "</AreaNo>\n" +
                    "        <Firmware_1_Copy>EU-1.0</Firmware_1_Copy>\n" +
                    "        <Firmware_2_Copy>EU-1.0</Firmware_2_Copy>\n" +
                    "        <Firmware_3_Copy>EU-1.0</Firmware_3_Copy>\n" +
                    "        <DB_Copy>EU-1.0 </DB_Copy>\n" +
                    "        <MacAddress>0</MacAddress>\n" +
                    "        <IpAddress>00</IpAddress>\n" +
                    "      </Reg_DeviceInfo>\n" +
                    "    </Register>\n" +
                    "  </soap12:Body>\n" +
                    "</soap12:Envelope>";
                Console.WriteLine(parm);
                byte[] bs = Encoding.ASCII.GetBytes(parm);    //参数转化为ascii码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bento2.orange-electronic.com/App_Asmx/ToolApp.asmx");
                req.Method = "POST";    //确定传值的方式，此处为post方式传值
                req.ContentType = "application/soap+xml; charset=utf-8";
                req.ContentLength = bs.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {

                        string strBuf = sr.ReadToEnd().ToString();
                        Console.WriteLine(strBuf);
                        if (strBuf.substring(strBuf.IndexOf("<RegisterResult>") + 16, strBuf.IndexOf("</RegisterResult>")).Equals("true"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e) { return false; }
        }
        public static bool SysResetPwd(String admin)
        {
            try
            {
                string parm = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                    "<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\n" +
                    "  <soap12:Body>\n" +
                    "    <SysResetPwd xmlns=\"http://tempuri.org/\">\n" +
                    "      <UserID>" + admin + "</UserID>\n" +
                    "    </SysResetPwd>\n" +
                    "  </soap12:Body>\n" +
                    "</soap12:Envelope>";
                byte[] bs = Encoding.ASCII.GetBytes(parm);    //参数转化为ascii码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bento2.orange-electronic.com/App_Asmx/ToolApp.asmx");
                req.Method = "POST";    //确定传值的方式，此处为post方式传值
                req.ContentType = "application/soap+xml; charset=utf-8";
                req.ContentLength = bs.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {

                        string strBuf = sr.ReadToEnd().ToString();
                        if (strBuf.substring(strBuf.IndexOf("<SysResetPwdResult>") + 19, strBuf.IndexOf("</SysResetPwdResult>")).Equals("true"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception e) { return false; }
        }
        public static bool ValidateUser(String admin, String password)
        {
            try
            {
                string parm = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\">\n" +
"  <soap12:Body>\n" +
"    <ValidateUser xmlns=\"http://tempuri.org/\">\n" +
"      <UserID>" + admin + "</UserID>\n" +
"      <Pwd>" + password + "</Pwd>\n" +
"    </ValidateUser>\n" +
"  </soap12:Body>\n" +
"</soap12:Envelope>";
                byte[] bs = Encoding.ASCII.GetBytes(parm);    //参数转化为ascii码
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://bento2.orange-electronic.com/App_Asmx/ToolApp.asmx");
                req.Method = "POST";    //确定传值的方式，此处为post方式传值
                req.ContentType = "application/soap+xml; charset=utf-8";
                req.ContentLength = bs.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(bs, 0, bs.Length);
                }
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.Default))
                    {

                        string strBuf = sr.ReadToEnd().ToString();
                        if (strBuf.substring(strBuf.IndexOf("<ValidateUserResult>") + 20, strBuf.IndexOf("</ValidateUserResult>")).Equals("true"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception e) { return false; }
        }
    }
}