using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        List<Countries> countries = new List<Countries>();

        public Form1()
        {
            InitializeComponent();
            countries.Add(new Countries("Ukraine"));
            comboBox1.DisplayMember = "Country";
            comboBox1.Items.AddRange(countries.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countries[0].Cities.Add(textBox1.Text);
            Show();
        }
        public void Show()
        {
            //listBox1.Items.Clear();
            foreach (var item in countries)
            {                
                 listBox1.Items.AddRange(item.Cities.ToArray());
                 
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            countries[0].Cities.Remove(listBox1.Text);
            Show();  
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
