using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialConnect
{
    public partial class Enroll : Form
    {
        public delegate void regis(bool Condition);
        String admin="";
        String password = "";
        String SerialNum = "";
        String storetype = "";
        String companyname = "";
        String firstname = "";
        String lastname = "";
        String phone = "";
        String State = "";
        String city = "";
        String streat = "";
        public String zp="";
        public Enroll()
        {
            InitializeComponent();
            comboBox1.Items.Add("EU");
            comboBox1.Items.Add("North America");
            comboBox1.Items.Add("台灣");
            comboBox1.Items.Add("中國大陸");
            textBox2.Tag = false;
            textBox2.GotFocus += new EventHandler(textBox_GotFocus);
            textBox2.MouseUp += new MouseEventHandler(textBox_MouseUp);
            textBox1.Tag = false;
            textBox1.GotFocus += new EventHandler(textBox_GotFocus1);
            textBox1.MouseUp += new MouseEventHandler(textBox_MouseUp1);
            setlan();
        }
        public void setlan() {
            label1.Text = Language.setlan(1);
            label2.Text = Language.setlan(57); ;
            label3.Text = Language.setlan(58); ;
            textBox1.Text = Language.setlan(59); ;
            label4.Text = Language.setlan(60); ;
            label5.Text = Language.setlan(61); ;
            label6.Text = Language.setlan(62); ;
            label7.Text = Language.setlan(63); ;
            label8.Text = Language.setlan(64); ;
            label9.Text = Language.setlan(65); ;
            label10.Text = Language.setlan(66); 
            label11.Text = Language.setlan(67);
            label12.Text = Language.setlan(68);
            label14.Text = Language.setlan(69);
            label15.Text = Language.setlan(70);
            label16.Text = Language.setlan(71);
            label17.Text = Language.setlan(72);
            label18.Text = Language.setlan(73);
            label19.Text = Language.setlan(74);
            pro.Text = Language.setlan(77);
            button1.Text= Language.setlan(78);
        }
        public void textChangedEventHandler(object sender, EventArgs e)
        {
            //System.Windows.Forms.TextBox a = (System.Windows.Forms.TextBox)sender;
            //char[] lastChar = a.Text.ToCharArray();
            //if (lastChar.Length == 0) { a.Text = Language.setlan(59); } else {
            //    if (a.Text.Contains(Language.setlan(59))) {
            //        if (a.Text.substring()) { }
            //    }
            //    a.Text=a.Text.Replace(Language.setlan(59),"")}
        }
            public void register() {
            bool a = HttpRequest.Register( admin,  password,  SerialNum,  storetype,  companyname,  firstname,  lastname,  phone,  State,  city,  streat,  zp);
            regis mi = new regis(enter);
            BeginInvoke(mi, new Object[] { a });
        }
        public void enter(bool condition)
        {
            if (condition)
            {
                MessageBox.Show(Language.setlan(56), "success", MessageBoxButtons.OK);
                goback();
            }
            else {
                MessageBox.Show(Language.setlan(55), "success", MessageBoxButtons.OK);
            }
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Pro_Click(object sender, EventArgs e)
        {

            admin = textBox1.Text;
            password = textBox2.Text;
            firstname = textBox4.Text;
            lastname = textBox5.Text;
            companyname = textBox6.Text;
            phone= textBox7.Text;
            SerialNum= textBox8.Text;
            State = label20.Text+ textBox11.Text;
            zp = textBox10.Text;
            streat = textBox12.Text;
            city = textBox9.Text;
            storetype = "Retailer";
            if (!password.Equals(textBox3.Text))
            {
                MessageBox.Show(Language.setlan(76), "error", MessageBoxButtons.OK); return;
            }
            if (password.Length<8) {
                MessageBox.Show(Language.setlan(60)+Language.setlan(75), "error", MessageBoxButtons.OK); return;
            }
            if (admin.Length==0) { return; }
            if (password.Length == 0) { return; }
            if (firstname.Length == 0) { return; }
            if (lastname.Length == 0) { return; }
            if (companyname.Length == 0) { return; }
            if (phone.Length == 0) { return; }
            if (SerialNum.Length == 0) { return; }
            if (State.Length == 0) { return; }
            if (zp.Length == 0) { return; }
            if (streat.Length == 0) { return; }
            if (city.Length == 0) { return; }
            if (storetype.Length == 0) { return; }
            new Thread(register).Start();
        }

        public void goback() {
            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;//將Form1隱藏。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label20.Text = comboBox1.SelectedItem.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
       
        }
        void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            //如果鼠标左键操作并且标记存在，则执行全选             
            if (e.Button == MouseButtons.Left && (bool)textBox2.Tag == true)
            {
                textBox2.SelectAll();
            }

            //取消全选标记              
            textBox2.Tag = false;
        }


        void textBox_GotFocus(object sender, EventArgs e)
        {
            textBox2.Tag = true;    //设置标记              
            textBox2.SelectAll();   //注意1         
        }
        void textBox_MouseUp1(object sender, MouseEventArgs e)
        {
            //如果鼠标左键操作并且标记存在，则执行全选             
            if (e.Button == MouseButtons.Left && (bool)textBox1.Tag == true)
            {
                textBox1.SelectAll();
            }

            //取消全选标记              
            textBox1.Tag = false;
        }


        void textBox_GotFocus1(object sender, EventArgs e)
        {
            textBox1.Tag = true;    //设置标记              
            textBox1.SelectAll();   //注意1         
        }
    }
}
