
namespace AuthyMe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.steganographyButton = new System.Windows.Forms.Button();
            this.PasswordsManageButton = new System.Windows.Forms.Button();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.welcomePage1 = new AuthyMe.welcomePage();
            this.homePage1 = new AuthyMe.HomePage();
            this.steganographyPage1 = new AuthyMe.SteganographyPage();
            this.MenuPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Purple;
            this.MenuPanel.Controls.Add(this.steganographyButton);
            this.MenuPanel.Controls.Add(this.PasswordsManageButton);
            this.MenuPanel.Controls.Add(this.HomePageButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(158, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // steganographyButton
            // 
            this.steganographyButton.BackColor = System.Drawing.Color.Black;
            this.steganographyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.steganographyButton.FlatAppearance.BorderSize = 0;
            this.steganographyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steganographyButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.steganographyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.steganographyButton.Location = new System.Drawing.Point(0, 221);
            this.steganographyButton.Name = "steganographyButton";
            this.steganographyButton.Size = new System.Drawing.Size(158, 34);
            this.steganographyButton.TabIndex = 1;
            this.steganographyButton.Text = "Steganography";
            this.steganographyButton.UseVisualStyleBackColor = false;
            this.steganographyButton.Click += new System.EventHandler(this.steganographyButton_Click);
            // 
            // PasswordsManageButton
            // 
            this.PasswordsManageButton.BackColor = System.Drawing.Color.Black;
            this.PasswordsManageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordsManageButton.FlatAppearance.BorderSize = 0;
            this.PasswordsManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordsManageButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordsManageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordsManageButton.Location = new System.Drawing.Point(0, 119);
            this.PasswordsManageButton.Name = "PasswordsManageButton";
            this.PasswordsManageButton.Size = new System.Drawing.Size(158, 34);
            this.PasswordsManageButton.TabIndex = 0;
            this.PasswordsManageButton.Text = "AES Login";
            this.PasswordsManageButton.UseVisualStyleBackColor = false;
            this.PasswordsManageButton.Click += new System.EventHandler(this.PasswordsManageButton_Click);
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HomePageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePageButton.FlatAppearance.BorderSize = 0;
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomePageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.HomePageButton.Location = new System.Drawing.Point(0, 0);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(158, 57);
            this.HomePageButton.TabIndex = 0;
            this.HomePageButton.Text = "Authy Me";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.welcomePage1);
            this.ContentPanel.Controls.Add(this.homePage1);
            this.ContentPanel.Controls.Add(this.steganographyPage1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(152, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(648, 450);
            this.ContentPanel.TabIndex = 1;
            // 
            // welcomePage1
            // 
            this.welcomePage1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.welcomePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.welcomePage1.Location = new System.Drawing.Point(0, 0);
            this.welcomePage1.Name = "welcomePage1";
            this.welcomePage1.Size = new System.Drawing.Size(650, 455);
            this.welcomePage1.TabIndex = 2;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.homePage1.Location = new System.Drawing.Point(0, 0);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(650, 455);
            this.homePage1.TabIndex = 1;
            // 
            // steganographyPage1
            // 
            this.steganographyPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.steganographyPage1.Location = new System.Drawing.Point(0, 0);
            this.steganographyPage1.Name = "steganographyPage1";
            this.steganographyPage1.Size = new System.Drawing.Size(650, 455);
            this.steganographyPage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthyMe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Button PasswordsManageButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button steganographyButton;
        private welcomePage welcomePage1;
        private HomePage homePage1;
        private SteganographyPage steganographyPage1;
    }
}

