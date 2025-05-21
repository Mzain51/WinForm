using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTutorial
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CreateContextMenuStrip();

        }

        private void CreateContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Exits");
            menuItem.Name = "Exits";
            menuItem.Click += new EventHandler(Exits_Click);
            contextMenuStrip.Items.Add(menuItem);
            this.ContextMenuStrip = contextMenuStrip;
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem.Name == "Exits")
            {
              Application.Exit();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

 