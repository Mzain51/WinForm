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
using System.Xml.Serialization;
using WinFormTutorial.Models;

namespace WinFormTutorial
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> person = new List<Person>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>)); 
            person.Add(new Person(){ Id=1, Name="Tarun"});
            person.Add(new Person() { Id = 2, Name = "Anuj" });
            person.Add(new Person() { Id = 3, Name = "Jinx" });
            string path = Environment.CurrentDirectory + "/" + "edward.xml";
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write)) ;
            //{
            //    serializer.Serialize(fileStream, person);
            //    MessageBox.Show("XML File Created With Person Data");
            //}


        }
    }
}
