using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginForm
{
    public partial class ForgetPassword : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=bilgi.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        public ForgetPassword()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        char? none = null;

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ForgetPassword_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ForgetPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string ad = textBox1.Text;
            string parola = textBox2.Text;

            con.Open();
            cmd=new OleDbCommand("UPDATE bilgi SET kullanici='"+ad+"', sifre='"+parola+ "'where kullanici='"+ad+"' ",con);
            cmd.ExecuteReader();
            MessageBox.Show("Şifre Güncellendi");
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = Convert.ToChar(none);
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
