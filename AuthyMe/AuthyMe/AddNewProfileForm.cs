using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using SQLite;

namespace AuthyMe
{
    public partial class AddNewProfileForm : Form
    {
        HomePage home= new HomePage();

        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string password;
        public string username;
        public string SQLSymetricKey;
        public string encryptedText;
   
        public AddNewProfileForm()
        {
            InitializeComponent();
            
        }
        SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
        SqlConnection conn4 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");

        private void SubmitNewProfileButton_Click(object sender, EventArgs e)
        {
            conn2.Open();
            conn4.Open();
            username=NewProfileUsernameTextbox.Text;   
            password = NewProfilePasswordTextbox.Text;

            SqlCommand cmd2 = new SqlCommand("select SymetricKey from AuthyMe.dbo.MasterPasswordTable", conn2);
            SqlDataReader sdr2 = cmd2.ExecuteReader();

            while (sdr2.Read())
            {
                SQLSymetricKey = sdr2.GetString(0);
            }
            conn2.Close();

            try
            {
                Encrypt(NewProfilePasswordTextbox.Text, SQLSymetricKey, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            encryptedText = Encrypt(NewProfilePasswordTextbox.Text, SQLSymetricKey, IV);
            SqlCommand cmd4 = new SqlCommand("INSERT INTO AuthyMe.dbo.AESLoginTable (username, password, encryptedText) VALUES(@username, @password, @encryptedText)", conn4);
            
            cmd4.Parameters.AddWithValue("@username", username);
            //cmd4.Parameters.AddWithValue("@id", idclass.ID);
            cmd4.Parameters.AddWithValue("@password", password);
            cmd4.Parameters.AddWithValue("@encryptedText", encryptedText);
            cmd4.ExecuteNonQuery();
            conn4.Close();

            if(MessageBox.Show("Set succeed", "succeed", MessageBoxButtons.OK) ==DialogResult.OK)
            {
                home.LoadProduct();
            }

            NewProfileUsernameTextbox.Text = "";
            NewProfilePasswordTextbox.Text = "";
        }

        private string Encrypt(string plainText, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);

   
            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;


            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Encoding.UTF8.GetBytes(plainText);
            cryptoStream.Write(InputBytes, 0, InputBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] Encrypted = memoryStream.ToArray();

            return Convert.ToBase64String(Encrypted);
        }

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

        private void buttonhidepassword_Click(object sender, EventArgs e)
        {
            if (NewProfilePasswordTextbox.PasswordChar == '\0')
            {
                buttonshowpassword.BringToFront();
                NewProfilePasswordTextbox.PasswordChar = '*';
            }
        }

        private void buttonshowpassword_Click(object sender, EventArgs e)
        {
            if (NewProfilePasswordTextbox.PasswordChar == '*')
            {
                buttonhidepassword.BringToFront();
                NewProfilePasswordTextbox.PasswordChar = '\0';
            }
        }

        private void AddNewProfileForm_Load(object sender, EventArgs e)
        {
            buttonshowpassword.BringToFront();
            NewProfilePasswordTextbox.PasswordChar = '*';
        }
    }
}
