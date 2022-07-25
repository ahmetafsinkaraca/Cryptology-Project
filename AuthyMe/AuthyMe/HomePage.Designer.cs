
namespace AuthyMe
{
    partial class HomePage
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonStackoerflow;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.AddNewButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testDataGridview = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonGithub = new System.Windows.Forms.Button();
            this.buttonLinkedin = new System.Windows.Forms.Button();
            this.textTestId = new System.Windows.Forms.TextBox();
            this.testUsernameSQL = new System.Windows.Forms.TextBox();
            this.testPasswordSQL = new System.Windows.Forms.TextBox();
            this.textBoxDcryptPassword = new System.Windows.Forms.TextBox();
            buttonStackoerflow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStackoerflow
            // 
            buttonStackoerflow.BackColor = System.Drawing.Color.WhiteSmoke;
            buttonStackoerflow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStackoerflow.BackgroundImage")));
            buttonStackoerflow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonStackoerflow.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonStackoerflow.FlatAppearance.BorderSize = 0;
            buttonStackoerflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonStackoerflow.Location = new System.Drawing.Point(512, 253);
            buttonStackoerflow.Name = "buttonStackoerflow";
            buttonStackoerflow.Size = new System.Drawing.Size(48, 44);
            buttonStackoerflow.TabIndex = 16;
            buttonStackoerflow.UseVisualStyleBackColor = false;
            buttonStackoerflow.Click += new System.EventHandler(this.buttonStackoerflow_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddNewButton.Location = new System.Drawing.Point(83, 40);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(116, 23);
            this.AddNewButton.TabIndex = 0;
            this.AddNewButton.Text = "+ Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // testDataGridview
            // 
            this.testDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridview.Location = new System.Drawing.Point(32, 69);
            this.testDataGridview.Name = "testDataGridview";
            this.testDataGridview.Size = new System.Drawing.Size(244, 128);
            this.testDataGridview.TabIndex = 2;
            this.testDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testDataGridview_CellClick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonGithub
            // 
            this.buttonGithub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGithub.BackgroundImage")));
            this.buttonGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGithub.FlatAppearance.BorderSize = 0;
            this.buttonGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGithub.Location = new System.Drawing.Point(458, 253);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(48, 44);
            this.buttonGithub.TabIndex = 18;
            this.buttonGithub.UseVisualStyleBackColor = true;
            this.buttonGithub.Click += new System.EventHandler(this.buttonGithub_Click);
            // 
            // buttonLinkedin
            // 
            this.buttonLinkedin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLinkedin.BackgroundImage")));
            this.buttonLinkedin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLinkedin.FlatAppearance.BorderSize = 0;
            this.buttonLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLinkedin.Location = new System.Drawing.Point(404, 252);
            this.buttonLinkedin.Name = "buttonLinkedin";
            this.buttonLinkedin.Size = new System.Drawing.Size(48, 44);
            this.buttonLinkedin.TabIndex = 17;
            this.buttonLinkedin.UseVisualStyleBackColor = true;
            this.buttonLinkedin.Click += new System.EventHandler(this.buttonLinkedin_Click);
            // 
            // textTestId
            // 
            this.textTestId.Location = new System.Drawing.Point(32, 224);
            this.textTestId.Name = "textTestId";
            this.textTestId.Size = new System.Drawing.Size(100, 20);
            this.textTestId.TabIndex = 19;
            this.textTestId.Visible = false;
            // 
            // testUsernameSQL
            // 
            this.testUsernameSQL.Location = new System.Drawing.Point(32, 298);
            this.testUsernameSQL.Name = "testUsernameSQL";
            this.testUsernameSQL.Size = new System.Drawing.Size(100, 20);
            this.testUsernameSQL.TabIndex = 20;
            this.testUsernameSQL.Visible = false;
            // 
            // testPasswordSQL
            // 
            this.testPasswordSQL.Location = new System.Drawing.Point(32, 324);
            this.testPasswordSQL.Name = "testPasswordSQL";
            this.testPasswordSQL.Size = new System.Drawing.Size(100, 20);
            this.testPasswordSQL.TabIndex = 21;
            this.testPasswordSQL.Visible = false;
            // 
            // textBoxDcryptPassword
            // 
            this.textBoxDcryptPassword.Location = new System.Drawing.Point(156, 324);
            this.textBoxDcryptPassword.Name = "textBoxDcryptPassword";
            this.textBoxDcryptPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxDcryptPassword.TabIndex = 22;
            this.textBoxDcryptPassword.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBoxDcryptPassword);
            this.Controls.Add(this.testPasswordSQL);
            this.Controls.Add(this.testUsernameSQL);
            this.Controls.Add(this.textTestId);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.buttonLinkedin);
            this.Controls.Add(buttonStackoerflow);
            this.Controls.Add(this.testDataGridview);
            this.Controls.Add(this.AddNewButton);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(652, 414);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewButton;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView testDataGridview;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonGithub;
        private System.Windows.Forms.Button buttonLinkedin;
        private System.Windows.Forms.TextBox textTestId;
        private System.Windows.Forms.TextBox testUsernameSQL;
        private System.Windows.Forms.TextBox testPasswordSQL;
        private System.Windows.Forms.TextBox textBoxDcryptPassword;
    }
}
