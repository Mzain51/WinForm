using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTutorial
{
    public partial class ControlsExample : Form
    {
        private TextBox txtBox = new TextBox();
        private Button button = new Button();
        private Button button3 = new Button();

        public ControlsExample()
        {
            InitializeComponent();
            this.txtBox.BackColor = Color.Beige;
            this.txtBox.Text = "MY TEXTBOX";
            this.txtBox.Location = new Point(90, 25);
            this.txtBox.Size = new Size(100, 25);

            this.button.BackColor = Color.Aqua;
            this.button.Text = "Click Me";
            this.button.Location = new Point(550, 25);
            this.button.Size = new Size(100, 25);

            this.button3.BackColor = Color.Brown;
            this.button3.Text = "Click Me";
            this.button3.Location = new Point(450, 60);
            this.button3.Size = new Size(400, 25);

            this.button.Click += new EventHandler(this.button_Click);
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button3.Click += new EventHandler(this.button1_Click);


            this.Controls.Add(txtBox);
            this.Controls.Add(button);
            this.Controls.Add(button3);
        }

        private void Namelbl_Click(object sender, EventArgs e)
        {
        }

        private void ControlsExample_Load(object sender, EventArgs e)
        {
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button FirstButton = sender as Button;
            MessageBox.Show(txtBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button SecondButton = sender as Button;
            MessageBox.Show("CLicked ME");
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBox.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountryList.Items.Add("PK");
            CountryList.SelectionMode = SelectionMode.MultiSimple;
            CountryList.SelectedIndex = 2;
            resultlbl.Text = CountryList.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hello World", "Direct Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You clicked Yes");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("You clicked No");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You clicked Cancel");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 formObject = new Form1();
            formObject.Show();
        }
    }
}
