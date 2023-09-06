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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddItems item=new AddItems();
            item.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchItems item=new SearchItems();
            item.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AboutUs item = new AboutUs();
            item.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thanks for using Our System,\nYou are about to Exit\nWould you like to Continue?","Appreciation",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                this.Close();
                return;
            }
            MessageBox.Show("We got you Covered!, Enjoy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
