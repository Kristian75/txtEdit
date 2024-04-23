using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtEdit
{
    public partial class Form1 : Form
    {
        public object CreateDirectory { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog d1 = new OpenFileDialog();  
            if (d1.ShowDialog() == DialogResult.OK)
            {
                if ((st = d1.OpenFile()) !=null)
                {
                    string file = d1.FileName;
                    String str = File.ReadAllText(file);
                    richTextBox1.Text = str;
                }
            }

        }

        private void BtnNew_Click(object sender, EventArgs e) => CreateDirectory(new);

        {
            StreamWriter tw = new StreamWriter(@"C:\Users\Admin\Desktop\Hello.txt");
            tw.Write(richTextBox1);
                richTextBox1.Text = "file uspješno spremljen";
                Random r = new Random();
                richTextBox1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
                tw.Close();
        }
    }
}
