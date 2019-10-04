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
    public partial class ResetPs : Form
    {
        public delegate void regis(bool Condition);
        String email = "";
        public ResetPs()
        {
            InitializeComponent();
            Setlan();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Setlan() {
            label1.Text = Language.setlan(1);
            label2.Text = Language.setlan(80);
            label3.Text = Language.setlan(81);
            pro.Text = Language.setlan(82);
            button1.Text = Language.setlan(78);
            label5.Text = Language.setlan(83);
        }

        private void Pro_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;
            if (email.Length==0) { return; }
            new Thread(register).Start();
        }
        public void register()
        {
            bool a = HttpRequest.SysResetPwd(email);
            regis mi = new regis(enter);
            BeginInvoke(mi, new Object[] { a });
        }
        public void enter(bool condition)
        {
            if (condition)
            {
                MessageBox.Show(Language.setlan(79), "success", MessageBoxButtons.OK);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(Language.setlan(47), "false", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
