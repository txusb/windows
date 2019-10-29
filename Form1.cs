using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialConnect
{
    public partial class Form1 : Form
    {
        public delegate void Enrol(bool Condition);
        public delegate void Update(bool Condition,int pass);
        public delegate void ISCONNN(bool Condition);
        public delegate void NEEDUPDATER(bool Condition);
        string admin = "";
        string password = "";
        Command command = new Command();
        RxCommand rxcommand = new RxCommand();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(DateTime.Now.Ticks);
            comboBox1.Items.Add("繁體中文");
            comboBox1.Items.Add("简体中文");
            comboBox1.Items.Add("Deutsch");
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Italiano");
            button4.Text = FtpManager.GetLanguage();
            setla();
            noconnect(true);
       
        }
        public void needupdate(bool Condition) {
            panel5.Visible = Condition;
        }
        public void setla() {
            label1.Text = Language.setlan(1);
            label2.Text = Language.setlan(2);
            label3.Text = Language.setlan(43);
            label4.Text = Language.setlan(31);
            label7.Text = Language.setlan(54);
            button1.Text = Language.setlan(5);
            button5.Text = Language.setlan(77);
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void noconnect(bool a) { panel3.Visible = a; }
        public void Updater(bool a,int pass) {
            if (pass == 0) {
                label5.Text = Language.setlan(49);
            } else { label5.Text = Language.setlan(50); }
            panel4.Visible = a; label6.Text = pass + "%"; }
        public byte[] Getbyte()
        {
            byte[] a = new byte[100];
            for (int i = 0; i < a.Length; i++) { a[i] = 0xEE; }
            return a;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            new Thread(run).Start();

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Console.WriteLine("close");
            serialPort1.Close();
            System.Environment.Exit(0);
            base.OnClosing(e);
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] a = Getbyte();
            serialPort1.Read(a, 0, 100);
            command.tmprx = command.tmprx + ToHexString(a);
            Console.WriteLine("check:" + command.check + " --" + command.tmprx);
            if (command.tmprx.Length == command.check|| command.check == 0)
            {
                Console.WriteLine("RX:" + command.tmprx);
                rxcommand.RX(Getbytes(command.tmprx), command);
            }
        }
        static string[] ports;
        bool LOOP = true;
        public void run()
        {
            int ind = 0;
            try
            {
                while (LOOP)
                {
                    while (serialPort1.IsOpen) { ind = 0; }
                    Console.WriteLine("連線中");
                    ISCONNN p = new ISCONNN(noconnect);
                    BeginInvoke(p, new Object[] { true });
                    Update u = new Update(Updater);
                    BeginInvoke(u, new Object[] { false, 0 });
                    command.tmprx = "";
                    command.check = 0;
                    ports = SerialPort.GetPortNames();
                    if (ports.Length == ind) { ind = 0; }
                    if (ports.Length != 0)
                    {
                        try
                        {
                            foreach (var s in ports)
                            {
                                if (!LOOP) { break; }
                                if (serialPort1.IsOpen) { break; }
                                serialPort1.PortName = s;
                                serialPort1.BaudRate = Convert.ToInt32(115200);
                                serialPort1.Open();
                                command.serialPort = serialPort1;
                                switch (command.HandShake("0"))
                                {
                                    case 0:
                                        serialPort1.Close();
                                        break;
                                    case 1:
                                        BeginInvoke(p, new Object[] { false });
                                        if (!update()) { serialPort1.Close(); } ;
                                        break;
                                    case 2:
                                        BeginInvoke(p, new Object[] { false });
                                        UpdateCompare();
                                        break;
                                    case -1:
                                        serialPort1.Close();
                                        break;
                                }
                            }
                        }
                        catch (Exception e) { }
                    }
                    Thread.Sleep(1000);
                    ind++;
                }
            }
            catch (Exception e) { }
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

        public void signin() {
            bool a=HttpRequest.ValidateUser(admin, password);
            FormMain.admin = admin;
            FormMain.password = password;
            Enrol mi = new Enrol(enter);
            BeginInvoke(mi, new Object[] { a });
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            admin = textBox1.Text;
            password = textBox2.Text;
            new Thread(signin).Start();
        }
        public void enter(bool condition){
            if (condition) {
                LOOP = false;
                serialPort1.Close();
                FormMain a = new FormMain();//產生Form2的物件，才可以使用它所提供的Method
                FormMain.language = button4.Text;
                this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
                a.Visible = true;//顯示第二個視窗
                Thread.Sleep(200);
            } else { label3.Visible = true; }
        }
        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Text = comboBox1.SelectedItem.ToString();
            FtpManager.Writrlanguage(button4.Text);
            setla();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateCompare() {
            Update u = new Update(Updater);
            BeginInvoke(u, new Object[] { true, 0 });
            String mcname = FtpManager.mcuname();
            if (mcname.Equals("nodata")|| !command.Command01()) {
                MessageBox.Show(Language.setlan(52), "false", MessageBoxButtons.OK);
                BeginInvoke(u, new Object[] { false, 0 });
            } else {
                command.AppverInspire = mcname.substring(9, 13);
                Console.WriteLine("version:" + command.AppverInspire+"now:"+command.Appver) ;
                BeginInvoke(u, new Object[] { false, 0 });
                if (command.Appver.Equals(command.AppverInspire))
                {
                    NEEDUPDATER a = new NEEDUPDATER(needupdate);
                    BeginInvoke(a, new Object[] { false });
                }
                else{
                    NEEDUPDATER a = new NEEDUPDATER(needupdate);
                    BeginInvoke(a, new Object[] { true });
                }
            }
        }
        public Boolean update() {
            Update u = new Update(Updater);
            BeginInvoke(u, new Object[] { true,0 });
            command.A0xEB();
            if (FtpManager.DonloadMcu()) {
                if (command.GoProgram("0"))
                {
                    bool a = command.WriteFlash(132, "0",u,this);
                    if (a)
                    {
                        Thread.Sleep(20);
                        if (command.GoProgram("1"))
                        {
                            bool b = command.WriteFlash(132, "1",u, this);
                            if (b) {
                              
                                MessageBox.Show(Language.setlan(51), "success", MessageBoxButtons.OK);
                                BeginInvoke(u, new Object[] { false, 0 });
                                return true; }
                            else { return false; }
                        }
                        else
                        {
                            return false;
                        };
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            } else { return false; }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            panel5.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            new Thread(checkupdate).Start();
        }
        public void checkupdate() { if (!update())
            {
                MessageBox.Show(Language.setlan(52), "error", MessageBoxButtons.OK);
                Update u = new Update(Updater);
                BeginInvoke(u, new Object[] { false, 0 });
            }
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (command.Appver.Equals(command.AppverInspire))
            {
                MessageBox.Show(Language.setlan(53), "success", MessageBoxButtons.OK);
            }
            else { new Thread(UpdateCompare).Start(); }
              
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Enroll a = new Enroll();//產生Form2的物件，才可以使用它所提供的Method
            a.Visible = true;//顯示第二個視窗
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            ResetPs a = new ResetPs();//產生Form2的物件，才可以使用它所提供的Method
            a.Visible = true;//顯示第二個視窗
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            ResetPs a = new ResetPs();//產生Form2的物件，才可以使用它所提供的Method
            a.Visible = true;//顯示第二個視窗
        }
    }
}
