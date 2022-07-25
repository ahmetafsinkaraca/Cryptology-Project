using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AuthyMe
{
    public partial class MasterPasswordForm : Form
    {
        Form1 form1 = new Form1();
        public string MassPass;
        public string MasterPassword;
        public int SQLMassPass;
        public string SymetricKey;
        public MasterPasswordForm()
        {
            InitializeComponent();
        }

        Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
        SqlConnection conn2 = new SqlConnection(@"Data Source=DESKTOP-5Q4FIHQ\SQLEXPRESS;Initial Catalog=AuthyMe;Integrated Security=True");
        private void MasterPassSubmitButton_Click(object sender, EventArgs e)
        {

            MassPass = SQLMassPass.ToString();
            conn.Open();
            conn2.Open();
            MasterPassword = MasterPassTextbox.Text;
            SqlCommand sqlcommand = new SqlCommand("select MasterPassword from AuthyMe.dbo.MasterPasswordTable",conn2);
            SqlDataReader sdr=sqlcommand.ExecuteReader(); 
            
            while(sdr.Read())
            {
                MassPass =sdr.GetString(0); 
            }
            conn2.Close();

            if (MassPass == "0")
            {
                SymetricKey = RandomString(16);
                string querry = "UPDATE AuthyMe.dbo.MasterPasswordTable SET MasterPassword = @MasterPassword , SymetricKey = @SymetricKey ";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@MasterPassword", MasterPassword);
                cmd.Parameters.AddWithValue("@SymetricKey", SymetricKey);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Hide();
                form1.Show();
            }

            else if (MassPass != "0")
            {
                if (MasterPassword == MassPass)
                {
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Master Password is Wrong");
                    conn.Close();
                }
            }
            
       }

        private void buttonshowmaster_Click(object sender, EventArgs e)
        {
            if (MasterPassTextbox.PasswordChar == '*')
            {
                buttonhidemaster.BringToFront();
                MasterPassTextbox.PasswordChar = '\0';
            }
        }

        private void buttonhidemaster_Click(object sender, EventArgs e)
        {
            if (MasterPassTextbox.PasswordChar == '\0')
            {
                buttonshowmaster.BringToFront();
                MasterPassTextbox.PasswordChar = '*';
            }
        }

        private void MasterPasswordForm_Load(object sender, EventArgs e)
        {
            buttonshowmaster.BringToFront();
            MasterPassTextbox.PasswordChar = '*';

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
