using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ExtensionMethods;
using System.Threading;
using System.Data.SQLite;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.UI.Xaml.Controls;
using System.IO;
using System.Collections;

namespace SerialConnect
{
    public partial class FormMain : Form
    {
        string serialnum = "99";
        bool isconnect = true;
        bool first = false;
        Command command = new Command();
        string mmynum = "";
        public static string language = "繁體中文";
        string PRORID = "PR";
        string Lf = "0";
        public delegate void MyInvoke(bool CH1, String Id1, bool CH2, String Id2, int i);
        public delegate void Player(String a);
        public delegate void Pauser();
        public delegate void ISCONNN(bool Condition);
        public delegate void Programmer(bool Condition);
        static string StatusText = "";
        static string s19name = "";
        static int idcount = 8;
        public const int PROGRAM_FAULSE = 2;
        public const int PROGRAMMING = 3;
        public const int PROGRAM_SUCCESS = 0;
        public const int PROGRAM_WAIT = 1;
        public const int PROGRAN_INSERT = 9;
        public const int UN_LINK = 4;
        public const int LF = 5;
        public const int RF = 6;
        public const int LR = 7;
        public const int RR = 8;
        string Lfid = "ABCDEF";
        static string admin = "";
        static string password = "";
        string Rfid = "ABCDEF";
        string Lrid = "ABCDEF";
        string Rrid = "ABCDEF";
        string WriteLf = "00000000";
        string WriteLr = "00000000";
        string WriteRf = "00000000";
        string WriteRR = "00000000";
        bool ISPROGRAMMING = false;
        RxCommand rxcommand = new RxCommand();
        static string[] ports;
        public FormMain()
        {
            FtpManager.CreatShare();
            InitializeComponent();
            setla();
            ChangrParent();
            repaint();
            ISid(false);
            //panel22.Visible = false;
            RFL1.TextChanged += textChangedEventHandler;
            LFL1.TextChanged += textChangedEventHandler;
            LRL2.TextChanged += textChangedEventHandler;
            RRL2.TextChanged += textChangedEventHandler;
            this.SizeChanged += new EventHandler(this.SizeChange);
            label1.Parent = panel1;
            //pictureBox3.Parent = pictureBox1;
            this.label1.BackColor = Color.Transparent;
            UpdateUiCondition(PROGRAM_WAIT);
            UpdateUi(LF, UN_LINK);
            UpdateUi(RF, UN_LINK);
            UpdateUi(RR, UN_LINK);
            UpdateUi(LR, UN_LINK);
            new Thread(UdCondition).Start();
        }
        public void NoPR() {
            button1.Enabled = false;
        }
        public void UdCondition()
        {
            try
            {
              
                while (first == false)
                {
                    Thread.Sleep(500);
                }
                ISPROGRAMMING = true;
                for (int i = 0; i < 2; i++)
                {
                    bool CH1 = command.Command_11(i, 1);
                    String Id1 = command.ID;
                    bool CH2 = command.Command_11(i, 2);
                    String Id2 = command.ID;
                    MyInvoke mi = new MyInvoke(UpdateForm);
                    BeginInvoke(mi, new Object[] { CH1, Id1, CH2, Id2, i });

                }
                ISPROGRAMMING = false;
                Thread.Sleep(3000);
                UdCondition();
            }catch (Exception e)
            {
                ISPROGRAMMING = false;
            }


        }
        public void UpdateForm(bool CH1, String Id1, bool CH2, String Id2, int i)
        {
            button1.Enabled = true;
            if (CH1)
            {
                if (mmynum.Equals("RN1628") || mmynum.Equals("SI2048"))
                {
                    String WriteTmp = Id1.substring(0, 2) + "XX" + Id1.substring(4, 6) + "YY";
                    Id1 = WriteTmp.Replace("XX", Id1.substring(6, 8)).Replace("YY", Id1.substring(2, 4));
                }
                Id1 = Id1.substring(8 - idcount, 8);
                if (i == 0)
                {
                    Lfid = Id1;
                    if (first) { UpdateUi(LF, PROGRAM_WAIT); }
                    LFL2.Text = Lfid;
                }
                else
                {
                    Rfid = Id1;
                    if (first) { UpdateUi(RF, PROGRAM_WAIT); }
                    RFL2.Text = Rfid;
                }
            }
            else
            {
                if (i == 0)
                {
                    Lfid = Language.setlan(48); 
                    if (first) { UpdateUi(LF, UN_LINK); }
                    LFL2.Text = Lfid;
                }
                else
                {
                    Rfid = Language.setlan(48); ;
                    if (first) { UpdateUi(RF, UN_LINK); }
                    RFL2.Text = Rfid;
                }

            }
            if (CH2)
            {
                if (mmynum.Equals("RN1628") || mmynum.Equals("SI2048"))
                {
                    String WriteTmp = Id2.substring(0, 2) + "XX" + Id2.substring(4, 6) + "YY";
                    Id2 = WriteTmp.Replace("XX", Id2.substring(6, 8)).Replace("YY", Id2.substring(2, 4));
                }
                Id2 = Id2.substring(8 - idcount, 8);
                if (i == 0)
                {
                    Lrid = Id2;
                    if (first) { UpdateUi(LR, PROGRAM_WAIT); }
                    LRL1.Text = Lrid;
                }
                else
                {
                    Rrid = Id2;
                    if (first) { UpdateUi(RR, PROGRAM_WAIT); }
                    RRL1.Text = Rrid;
                }
            }
            else
            {
                if (i == 0)
                {
                    Lrid = Language.setlan(48); ;
                    if (first) { UpdateUi(LR, UN_LINK); }
                    LRL1.Text = Lrid;
                }
                else
                {
                    Rrid = Language.setlan(48); ;
                    if (first) { UpdateUi(RR, UN_LINK); }
                    RRL1.Text = Rrid;
                }
            }
            int tires = 0;
            if (RFL2.Text != Language.setlan(48)) { tires++; }
            if (RRL1.Text != Language.setlan(48)) { tires++; }
            if (LRL1.Text != Language.setlan(48)) { tires++; }
            if (LFL2.Text != Language.setlan(48)) { tires++; }
            numbertires.Text = "" + tires;
            if (tires == 0) { numbertires.BackgroundImage = Properties.Resources.img_Drop_down_menu_gray; } else { numbertires.BackgroundImage = Properties.Resources.img_Drop_down_menu_Blue; }

        }
        private void SizeChange(object sender, System.EventArgs e)
        {
            repaint();
        }
        public void play(String a)
        {
            label4.Text = a;
            panel22.Visible = true;
        }
        public void pause() { panel22.Visible = false; }
        public void noconnect(bool a) { panel20.Visible = a; }
        public void textChangedEventHandler(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox a = (System.Windows.Forms.TextBox)sender;
            char[] lastChar = a.Text.ToCharArray();
            if (lastChar.Length == 0) { a.Text = "Original sensor ID"; }
            String id = "";
            String place = "Original sensor ID";
            if (a.Text.Equals("Original sensor ID")) { return; }
            foreach (int mid in lastChar)
            {
                if (mid >= 48 && mid <= 57)
                {
                    if (place.Contains(((char)mid).ToString()) && a.Text.Length > 10)
                    {
                        place = replace1(place, ((char)mid).ToString());
                    }
                    else { id = id + ((char)mid).ToString(); }
                }
                else if (mid >= 65 && mid <= 70)
                {
                    if (place.Contains(((char)mid).ToString()) && a.Text.Length > 10) { place = replace1(place, ((char)mid).ToString()); } else { id = id + ((char)mid).ToString(); }
                }
                else if (mid >= 97 && mid <= 102)
                {
                    if (place.Contains(((char)mid).ToString()) && a.Text.Length > 10)
                    {
                        place = replace1(place, ((char)mid).ToString());
                    }
                    else { id = id + ((char)mid).ToString(); }
                }
                else
                {
                }
            }

            if (id.Length > idcount) { a.Text = id.substring(0, idcount); } else { a.Text = id; }
            if (a.Text.Length == 0) { a.Text = "Original sensor ID"; }
            a.SelectionStart = a.Text.Length;
            Console.WriteLine(a.Text + a.Tag);
            if (a.Text.Length == idcount)
            {
                switch (a.Tag)
                {
                    case "RR":
                        WriteRR = a.Text;
                        break;
                    case "LR":
                        WriteLr = a.Text;
                        break;
                    case "LF":
                        WriteLf = a.Text;
                        break;
                    case "RF":
                        WriteRf = a.Text;
                        break;
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {   
            Console.WriteLine("close");
            serialPort1.Close();
            System.Environment.Exit(0);
            base.OnClosing(e);
        }
       
        public String replace1(String a, String b)
        {
            if (a.Contains(b))
            {
                Console.WriteLine("replace" + a.substring(0, a.IndexOf(b)) + a.substring(a.IndexOf(b), a.Length));
                return a.substring(0, a.IndexOf(b)) + a.substring(a.IndexOf(b) + 1, a.Length);
            }
            else { return a; }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            new Thread(Donloadmmy).Start();
            new Thread(run).Start();

        }
        public void DonloadS19()
        {
            Player mi = new Player(play);
            BeginInvoke(mi, new Object[] { "Data Loading" });
            bool a = FtpManager.DonloadS19(s19name);
            if (a)
            {
                Pauser p = new Pauser(pause);
                BeginInvoke(p, new Object[] { });
            }
            else { DonloadS19(); }
        }

        public void Donloadmmy()
        {
            Player mi = new Player(play);
            BeginInvoke(mi, new Object[] { "Data Loading" });
            bool a = FtpManager.Donloadmmy();
            if (a)
            {
                Pauser p = new Pauser(pause);
                BeginInvoke(p, new Object[] { });
            }
            else { Donloadmmy(); }
        }
        public void run()
        {
            int ind = 0;
            try
            {
                while (true)
                {
                    while (serialPort1.IsOpen) { ind = 0; }
                    ISCONNN p = new ISCONNN(noconnect);
                    BeginInvoke(p, new Object[] { true });
                    command.tmprx = "";
                    command.check = 22;
                    ports = SerialPort.GetPortNames();

                    if (ports.Length == ind) { ind = 0; }
                    if (ports.Length != 0)
                    {
                        try
                        {
                            foreach (var s in ports)
                            {
                                serialPort1.PortName = s;
                                serialPort1.BaudRate = Convert.ToInt32(115200);
                                serialPort1.Open();
                                //byte[] a = Getbytes("0AFE03000754504D539CC8F5");
                                byte[] a = Getbytes("0A0004000754504D535610F5");
                                serialPort1.Write(a, 0, a.Length);
                                Thread.Sleep(200);
                                if (command.tmprx.Contains("F50004000B"))
                                {
                                    serialnum = command.tmprx.substring(14,26);
                                    Console.WriteLine("Serial"+serialnum);
                                    command.serialPort = serialPort1;
                                    BeginInvoke(p, new Object[] { false });
                                    break;
                                }
                                else { serialPort1.Close(); }
                            }
                        }
                        catch (Exception e) { Console.WriteLine("異常"+e.Message); }
                    }
                    Thread.Sleep(2000);
                    ind++;
                }
            }
            catch (Exception e) { }
        }

        public void Program()
        {
            bool Condition = false;
            if (PRORID.Equals("ID"))
            {
                string startime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Condition = command.ProgramAll(WriteLf, WriteLr, WriteRf, WriteRR, Lf);
                string endtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ArrayList idrecord = new ArrayList();
                if (!WriteLf.Equals("00000000"))
                {
                    SensorRecord a = new SensorRecord();
                    a.Car_SensorID = LFL2.Text;
                    if (command.FALSE_CHANNEL.Contains("01")) { a.IsSuccess = "false"; } else { a.IsSuccess = "true"; }
                    a.SensorID = WriteLf;
                    idrecord.Add(a);
                }
                if (!WriteLr.Equals("00000000"))
                {
                    SensorRecord a = new SensorRecord();
                    a.Car_SensorID = LRL1.Text;
                    if (command.FALSE_CHANNEL.Contains("02")) { a.IsSuccess = "false"; } else { a.IsSuccess = "true"; }
                    a.SensorID = WriteLr;
                    idrecord.Add(a);
                }
                if (!WriteRf.Equals("00000000"))
                {
                    SensorRecord a = new SensorRecord();
                    a.Car_SensorID = RFL2.Text;
                    if (command.FALSE_CHANNEL.Contains("03")) { a.IsSuccess = "false"; } else { a.IsSuccess = "true"; }
                    a.SensorID = WriteRf;
                    idrecord.Add(a);
                }
                if (!WriteRR.Equals("00000000"))
                {
                    SensorRecord a = new SensorRecord();
                    a.Car_SensorID = RRL1.Text;
                    if (command.FALSE_CHANNEL.Contains("04")) { a.IsSuccess = "false"; } else { a.IsSuccess = "true"; }
                    a.SensorID = WriteRR;
                    idrecord.Add(a);
                }
                HttpRequest.Upload_IDCopyRecord(button4.Text, button5.Text, button6.Text, startime, endtime, serialnum, "USBPad", "IDCOPY", idrecord.Count, "ALL", idrecord);
            }
            else
            {
                string startime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Condition = command.ProgramAll(Lf);
                string endtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ArrayList idrecord = new ArrayList();
                for (int i = 0; i < command.CHANNEL_BLE.Count; i++)
                {
                    string a = command.CHANNEL_BLE[i].ToString();
                    if (a.substring(0, 2).Equals("04"))
                    {
                        Rrid = Getid(a);
                        SensorRecord b = new SensorRecord();
                        b.SensorID = Rrid;
                        b.IsSuccess = "true";
                        idrecord.Add(b);
                    }
                    if (a.substring(0, 2).Equals("03"))
                    {
                        Rfid = Getid(a);
                        SensorRecord b = new SensorRecord();
                        b.SensorID = Rfid;
                        b.IsSuccess = "true";
                        idrecord.Add(b);
                    }
                    if (a.substring(0, 2).Equals("02"))
                    {
                        Lrid = Getid(a);
                        SensorRecord b = new SensorRecord();
                        b.SensorID = Lrid;
                        b.IsSuccess = "true";
                        idrecord.Add(b);
                    }
                    if (a.substring(0, 2).Equals("01"))
                    {
                        Lfid = Getid(a);
                        SensorRecord b = new SensorRecord();
                        b.IsSuccess = "true"; 
                        b.SensorID = Lfid;
                        idrecord.Add(b);
                    }
                }
                foreach (string a in command.FALSE_CHANNEL)
                {
                    SensorRecord b = new SensorRecord();
                    b.IsSuccess = "false";
                    b.SensorID = "error";
                    idrecord.Add(b);
                }
                HttpRequest.Upload_ProgramRecord(button4.Text, button5.Text, button6.Text, startime, endtime, serialnum, "USBPad", "Program", idrecord.Count, "ALL", idrecord);
            }
            Programmer mi = new Programmer(ProgramBacker);
            BeginInvoke(mi, new Object[] { Condition });
        }

      
        public string insertz(string text)
        {
            string a = text;
            while (a.Length < 8)
            {
                a = "0" + a;
            }
            return a;
        }

        public byte[] Getbyte()
        {
            byte[] a = new byte[40];
            for (int i = 0; i < a.Length; i++) { a[i] = 0xEE; }
            return a;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            byte[] a = Getbyte();
            serialPort1.Read(a, 0, 40);

            command.tmprx = command.tmprx + ToHexString(a);
            Console.WriteLine("check:" + command.check + " --" + command.tmprx);
            if (command.tmprx.Length == command.check)
            {
                Console.WriteLine("RX:" + command.tmprx);
                rxcommand.RX(Getbytes(command.tmprx), command);
            }

        }
        protected string ToHexString(byte[] bytes)
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
            while (hexString.substring(hexString.Length - 1, hexString.Length).Equals("E") && hexString.Length > 0) { hexString = hexString.substring(0, hexString.Length - 2); }
            return hexString;
        }


        private void TextBoxStatus_TextChanged(object sender, EventArgs e)
        {

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
        private byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            first = false;
            button4.Text = comboBox2.SelectedItem.ToString();
            button5.Text = "Model";
            button6.Text = "Year";
            SqlHelper.SelectModel(comboBox3, button4.Text);
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            SqlHelper.SelectMake(comboBox2);
            comboBox2.DroppedDown = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void ComboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            first = false;
            button5.Text = comboBox3.SelectedItem.ToString();
            button6.Text = "Year";
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            s19name = SqlHelper.GetS19(button4.Text, button5.Text, comboBox4.SelectedItem.ToString());
            if (!s19name.Equals("nodata"))
            {
                first = true;
                new Thread(DonloadS19).Start();
                button6.Text = comboBox4.SelectedItem.ToString();
                UpdateUiCondition(PROGRAM_WAIT);
                idcount = SqlHelper.Idcount(s19name);
                LFL1.Text = "";
                RFL1.Text = "";
                LRL2.Text = "";
                RRL2.Text = "";
                SqlHelper.getrelarm(textBox1, button4.Text, button5.Text, button6.Text);
                pro.PerformClick();
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SqlHelper.SelectYear(comboBox4, button4.Text, button5.Text);
            comboBox4.DroppedDown = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (s19name.Equals("nodata") || ISPROGRAMMING) { return; }
            if (PRORID.Equals("ID"))
            {
                if (RFL1.Text.Length != idcount && RFL1.Enabled) { return; }
                if (RRL2.Text.Length != idcount && RRL2.Enabled) { return; }
                if (LFL1.Text.Length != idcount && LFL1.Enabled) { return; }
                if (LRL2.Text.Length != idcount && LRL2.Enabled) { return; }
                WriteLf = insertz(WriteLf);
                WriteLr = insertz(WriteLr);
                WriteRf = insertz(WriteRf);
                WriteRR = insertz(WriteRR);
            }
            first = false;
            ISPROGRAMMING = true;
            UpdateUiCondition(PROGRAMMING);
            new Thread(Program).Start();
        }





        private void Pro_Click_1(object sender, EventArgs e)
        {
            IDCOPY.Image = Properties.Resources.whitw;
            pro.Image = Properties.Resources.button_normal;
            pro.ForeColor = Color.White;
            IDCOPY.ForeColor = Color.FromArgb(22, 59, 87);
            ISid(false);
            repaint();
            PRORID = "PR";
        }

        private void IDCOPY_Click(object sender, EventArgs e)
        {
            pro.Image = Properties.Resources.whitw;
            IDCOPY.Image = Properties.Resources.button_normal;
            IDCOPY.ForeColor = Color.White;
            pro.ForeColor = Color.FromArgb(22, 59, 87);
            ISid(true);
            repaint();
            PRORID = "ID";
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
