using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avtosalon
{
    public partial class Form1 : Form
    {
        int carPrice = 20000;
        double discount = 0.1;
        public Form1()
        {
            InitializeComponent();
            LoadCars();
        }
        private void LoadCars()
        {
            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("Mazda");
            comboBox1.Items.Add("Mercedes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                double sum = carPrice - (carPrice * discount);
                MessageBox.Show($"Цената с отстъпка е: {sum} лв.");
            }
            else
            {
                MessageBox.Show($"Цената е: {carPrice} лв.");
            }
        }
    }
}
