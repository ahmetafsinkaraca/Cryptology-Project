using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthyMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PasswordsManageButton_Click(object sender, EventArgs e)
        {
            homePage1.BringToFront();
        }


        private void steganographyPage1_Load(object sender, EventArgs e)
        {
            homePage1.BringToFront();
        }

        private void steganographyButton_Click(object sender, EventArgs e)
        {
            steganographyPage1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            welcomePage1.BringToFront();
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            welcomePage1.BringToFront();
        }
    }
}
