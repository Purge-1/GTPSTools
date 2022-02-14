using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GTPSTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Text box is empty, please input in the field!");
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Text box is empty, please input in the field!");
            }
            else
            {
                var fileName = @"server_data.php";
                FileStream fs = File.OpenWrite(fileName);

                var data = "server|" + textBox1.Text + "\nport|" + textBox2.Text + "\ntype|1\n#maint|{mainmsg}\n\nbeta_server|127.0.0.1\nbeta_port|17091\n\nbeta_type|1\nmeta|localhost\nRTENDMARKERBS1001";
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
                MessageBox.Show("Server data has been created!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Text box is empty, please input in the field!");
            }
            else
            {
                var fileName = @"hosts.txt";
                FileStream fs = File.OpenWrite(fileName);

                var data = textBox1.Text + " growtopia1.com\n" + textBox1.Text + " growtopia2.com";
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
                MessageBox.Show("Host has been created!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Purge-1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to GTPS Tools Made by Purge\nThis is a remake from Kali.");
        }

    }
}
