using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You are about to Exit the Page!\nWould you like to Continue?","Alert!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
                return;
            }
            MessageBox.Show("We Got You Covered");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.groupBox1.Enabled = true;
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Mandatory to fill the Product ID Number");
                return;
            }
            this.toolStripButton1.Enabled = true;
            this.toolStripButton2.Enabled = false;
            this.groupBox1.Enabled = false;

            string filePath;
            filePath = "D:\\A-PROJECTS\\";
            string masterPath;
            masterPath = filePath + this.textBox1.Text + "_two.txt";
            System.IO.File.WriteAllText(masterPath, this.textBox2.Text, Encoding.UTF8);

            masterPath = filePath + this.textBox1.Text + "_three.txt";
            System.IO.File.WriteAllText(masterPath, this.textBox3.Text, Encoding.UTF8);

            masterPath = filePath + this.textBox1.Text + "_four.txt";
            System.IO.File.WriteAllText(masterPath, this.textBox4.Text, Encoding.UTF8);

            masterPath = filePath + this.textBox1.Text + "_five.txt";
            System.IO.File.WriteAllText(masterPath, this.textBox5.Text, Encoding.UTF8);

            masterPath = filePath + this.textBox1.Text + "_six.txt";
            System.IO.File.WriteAllText(masterPath, this.textBox6.Text, Encoding.UTF8);
            MessageBox.Show("Product Details Saved Successfully");
        }
    }
}
