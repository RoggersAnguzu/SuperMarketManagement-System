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
    public partial class SearchItems : Form
    {
        public SearchItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox7.Text=="")
            {
                MessageBox.Show("Kindly Enter Product ID before proceeding");
                return;
            }
            string filePath;
            filePath = "D:\\A-PROJECTS\\";
            string masterPath;
            string read;
            masterPath = filePath + this.textBox7.Text + "_two.txt";
            if (System.IO.File.Exists(masterPath)==true)
            {
                read=System.IO.File.ReadAllText(masterPath, Encoding.UTF8);
                this.textBox2.Text=read;
            }
            masterPath = filePath + this.textBox7.Text + "_three.txt";
            if (System.IO.File.Exists(masterPath) == true)
            {
                read = System.IO.File.ReadAllText(masterPath, Encoding.UTF8);
                this.textBox3.Text = read;
            }
            masterPath = filePath + this.textBox7.Text + "_four.txt";
            if (System.IO.File.Exists(masterPath) == true)
            {
                read = System.IO.File.ReadAllText(masterPath, Encoding.UTF8);
                this.textBox4.Text = read;
            }
            masterPath = filePath + this.textBox7.Text + "_five.txt";
            if (System.IO.File.Exists(masterPath) == true)
            {
                read = System.IO.File.ReadAllText(masterPath, Encoding.UTF8);
                this.textBox5.Text = read;
            }
            masterPath = filePath + this.textBox7.Text + "_six.txt";
            if (System.IO.File.Exists(masterPath) == true)
            {
                read = System.IO.File.ReadAllText(masterPath, Encoding.UTF8);
                this.textBox6.Text = read;
            }
            this.textBox1.Text = this.textBox7.Text;
        }

        private void SearchItems_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ;
            this.pictureBox1.BackgroundImage = Image.FromFile("D:\\PHOTOS\\FB.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
