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

namespace LINQ_to_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            Task1 task1 = new Task1();
            string [] lines = task1.OpenTxt(filename);
            var XML = task1.ConvertToXML(lines);
            textBox3.Text= XML.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            var XML = task1.ConvertToXML(textBox2.Text.Split(Environment.NewLine));
            textBox3.Text = XML.ToString();
        }
    }
}
