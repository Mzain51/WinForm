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

namespace WinFormTutorial
{
    public partial class FileHandling : Form
    {
        public FileHandling()
        {
            InitializeComponent();
        }
        string path = Environment.CurrentDirectory + "/" + "MyFiletxt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                MessageBox.Show("File Created");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello World");
                MessageBox.Show("Data Written");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadLine();
                textBox1.Text = text;
                MessageBox.Show(text);
            }
        
    }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (File.Exists(path))
            {
                if (MessageBox.Show("Are you sure you want to delete the file?", "Delete File", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(path);
                    MessageBox.Show("File Deleted");
                }
            }
        }
    }
    



}
