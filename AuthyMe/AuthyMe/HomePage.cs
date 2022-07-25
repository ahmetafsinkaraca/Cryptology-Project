using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using System.Data.SqlClient;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography;
using System.IO;


namespace AuthyMe
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public string username = "username";
        public string usernameLink;
        public string passwordLink;

        SqlConnection connSymetric1 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
        SqlConnection connSymetric2 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
        SqlConnection connSymetric3 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");

        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string SQLSymetricKey;


        private string Decrypt(string plaintext, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);


            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Convert.FromBase64String(plaintext);
            cryptoStream.Write(InputBytes, 0, InputBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] Decrypted = memoryStream.ToArray();

            return UTF8Encoding.UTF8.GetString(Decrypted, 0, Decrypted.Length);
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            AddNewProfileForm addnew=new AddNewProfileForm();
            addnew.Show();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void HomePage_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(" SELECT TOP (1000) [ID], [username], [encryptedText]  FROM [AuthyMe].[dbo].[AESLoginTable] ", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            testDataGridview.DataSource = ds.Tables[0];
            LoadProduct();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(" SELECT TOP (1000) [ID], [username], [encryptedText] FROM [AuthyMe].[dbo].[AESLoginTable] ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            testDataGridview.DataSource = ds.Tables[0];
        }

        public void LoadProduct()
        {

            var pro = from s in db.AESLoginTables select s;
            testDataGridview.DataSource = pro;

            //var proId = from sId in db.AESLoginTables select sId;
            //testDataGridview.DataSource = proId;

        }

        private void testDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textTestId.Text = "";
            testUsernameSQL.Text = "";
            testPasswordSQL.Text = "";

            //timer1.Stop();
            int sId = Convert.ToInt32(testDataGridview.Rows[e.RowIndex].Cells[0].Value);
            textTestId.Text = sId.ToString();

            string sId2 = (string)testDataGridview.Rows[e.RowIndex].Cells[1].Value;
            testUsernameSQL.Text = sId2;

            string sId3 = (string)testDataGridview.Rows[e.RowIndex].Cells[2].Value;
            testPasswordSQL.Text = sId3;

            if (MessageBox.Show("are u sure wan to delete?", "record deleted", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                timer1.Stop();
                int prodid = Convert.ToInt32(testDataGridview.Rows[e.RowIndex].Cells[0].Value);
                var prodel = (from s in db.AESLoginTables where s.ID == prodid select s).First();
                db.AESLoginTables.DeleteOnSubmit(prodel);
                db.SubmitChanges();
                MessageBox.Show("success");
                LoadProduct();
            }
            //else
            //{
            //    int sId= Convert.ToInt32(testDataGridview.SelectedRows[0].Cells[0].Value);
            //    textTestId.Text=sId.ToString();
            //}
            textBoxDcryptPassword.Text = "";


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SqlConnection timerconn = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
            SqlDataAdapter tmradapter = new SqlDataAdapter(" SELECT TOP (1000) [ID], [username], [encryptedText] FROM [AuthyMe].[dbo].[AESLoginTable] ", timerconn);
            DataSet dstimer = new DataSet();
            tmradapter.Fill(dstimer);
            testDataGridview.DataSource = dstimer.Tables[0];
        }

        private void buttonStackoerflow_Click(object sender, EventArgs e)
        {
            connSymetric1.Open();
            SqlCommand cmdSymetric = new SqlCommand("select SymetricKey from AuthyMe.dbo.MasterPasswordTable", connSymetric1);
            SqlDataReader sdrSymetric = cmdSymetric.ExecuteReader();

            while (sdrSymetric.Read())
            {
                SQLSymetricKey = sdrSymetric.GetString(0);
            }
            connSymetric1.Close();

            try
            {
                textBoxDcryptPassword.Text = Decrypt(testPasswordSQL.Text, SQLSymetricKey, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string usernamaLink = testUsernameSQL.Text;
            string encryptedText = textBoxDcryptPassword.Text;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://stackoverflow.com/users/login");
            var title_field2 = driver.FindElementByCssSelector("#password");
            var title_field1 = driver.FindElementByCssSelector("#email");

            if (title_field2 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field2);
                actions.Click();
                actions.SendKeys(encryptedText);
                actions.Build().Perform();

                Actions actions2 = new Actions(driver);
                actions.MoveToElement(title_field1);
                actions.Click();
                actions.SendKeys(usernamaLink);
                actions.Build().Perform();
            }

        }

        private void buttonLinkedin_Click(object sender, EventArgs e)
        {
            connSymetric2.Open();
            SqlCommand cmdSymetric2 = new SqlCommand("select SymetricKey from AuthyMe.dbo.MasterPasswordTable", connSymetric2);
            SqlDataReader sdrSymetric = cmdSymetric2.ExecuteReader();

            while (sdrSymetric.Read())
            {
                SQLSymetricKey = sdrSymetric.GetString(0);
            }
            connSymetric2.Close();

            try
            {
                textBoxDcryptPassword.Text= Decrypt(testPasswordSQL.Text, SQLSymetricKey, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string encryptedText = textBoxDcryptPassword.Text;
            string usernamaLink = testUsernameSQL.Text;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.linkedin.com/login");
            var title_field2 = driver.FindElementByCssSelector("#password");
            var title_field1 = driver.FindElementByCssSelector("#username");

            if (title_field2 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field2);
                actions.Click();
                actions.SendKeys(encryptedText);
                actions.Build().Perform();


                Actions actions2 = new Actions(driver);
                actions.MoveToElement(title_field1);
                actions.Click();
                actions.SendKeys(usernamaLink);
                actions.Build().Perform();
            }
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            connSymetric3.Open();
            SqlCommand cmdSymetric3 = new SqlCommand("select SymetricKey from AuthyMe.dbo.MasterPasswordTable", connSymetric3);
            SqlDataReader sdrSymetric = cmdSymetric3.ExecuteReader();

            while (sdrSymetric.Read())
            {
                SQLSymetricKey = sdrSymetric.GetString(0);
            }
            connSymetric3.Close();

            try
            {
                textBoxDcryptPassword.Text = Decrypt(testPasswordSQL.Text, SQLSymetricKey, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string encryptedText = textBoxDcryptPassword.Text;
            string usernamaLink = testUsernameSQL.Text;


            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/login");
            var title_field2 = driver.FindElementByCssSelector("#password");
            var title_field1 = driver.FindElementByCssSelector("#login_field");

            if (title_field2 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field2);
                actions.Click();
                actions.SendKeys(encryptedText);
                actions.Build().Perform();

                Actions actions2 = new Actions(driver);
                actions.MoveToElement(title_field1);
                actions.Click();
                actions.SendKeys(usernamaLink);
                actions.Build().Perform();
            }
        }
    }
}
