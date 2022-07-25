using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AuthyMe
{
    public partial class SteganographyPage : UserControl
    {
        public SteganographyPage()
        {
            InitializeComponent();

        }

        public string usernameLink;
        public string passwordLink;

        private Bitmap bmp = null; 

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png,*.bmp,*.jpg)|*.png;*.bmp;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)sourceImage.Image;
            string extract = LSB.Extract(bmp);
            textBox1.Text = "";
            textBox1.Text = extract;
        }


        private void sourceImage_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
           textBox1.PasswordChar = '*';    
           textBox1.MaxLength = 30;

            Console.WriteLine("Text");

            if(textBox1.Text == "")
            {
                MessageBox.Show("Please Type Password");
            }
            else
            {
                bmp = (Bitmap)sourceImage.Image;
                string text = textBox1.Text;
                bmp = LSB.textEmbed(text, bmp);

                SaveFileDialog save_dialog = new SaveFileDialog();
                save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

                if (save_dialog.ShowDialog() == DialogResult.OK)
                {
                    switch (save_dialog.FilterIndex)
                    {
                        case 0:
                            {
                                bmp.Save(save_dialog.FileName, ImageFormat.Png);
                            }
                            break;
                        case 1:
                            {
                                bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                            }
                            break;
                    }
                }

                MessageBox.Show("Progress Complete");
                textBox1.Text = "";

            }

        }


        private void buttonshowpassword_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*') 
            { 
                buttonhidepassword.BringToFront(); 
                textBox1.PasswordChar = '\0'; 
            }
        }

        private void buttonhidepassword_Click(object sender, EventArgs e)
        {
            if(textBox1.PasswordChar == '\0')
            {
                buttonshowpassword.BringToFront();
                textBox1.PasswordChar = '*';
            }
        }

        private void SteganographyPage_Load(object sender, EventArgs e)
        {
            buttonshowpassword.BringToFront();
            textBox1.PasswordChar= '*';

            sourceImage.AllowDrop = true;
        }


        private void buttonLinkedin_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)sourceImage.Image;
            string extract = LSB.Extract(bmp);
            textBox1.Text = "";
            textBox1.Text = extract;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.linkedin.com/login/tr");
            var title_field2 = driver.FindElementByCssSelector("#password");

            if (title_field2 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field2);
                actions.Click();
                actions.SendKeys(extract);
                actions.Build().Perform();
            }
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)sourceImage.Image;
            string extract = LSB.Extract(bmp);
            textBox1.Text = "";
            textBox1.Text = extract;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/login");
            var title_field = driver.FindElementByCssSelector("#password");

            if (title_field != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field);
                actions.Click();
                actions.SendKeys(extract);
                actions.Build().Perform();
            }
        }

        private void buttonStackoverflow_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)sourceImage.Image;
            string extract = LSB.Extract(bmp);
            textBox1.Text = "";
            textBox1.Text = extract;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://stackoverflow.com/users/login");
            var title_field3 = driver.FindElementByCssSelector("#password");

            if (title_field3 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field3);
                actions.Click();
                actions.SendKeys(extract);
                actions.Build().Perform();
            }
        }

        private void sourceImage_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    sourceImage.Image = Image.FromFile(fileNames[0]);
            }
        }
    }
}
