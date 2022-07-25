
namespace AuthyMe
{
    partial class AddNewProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProfileForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewProfileUsernameTextbox = new System.Windows.Forms.TextBox();
            this.NewProfilePasswordTextbox = new System.Windows.Forms.TextBox();
            this.SubmitNewProfileButton = new System.Windows.Forms.Button();
            this.buttonhidepassword = new System.Windows.Forms.Button();
            this.buttonshowpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // NewProfileUsernameTextbox
            // 
            this.NewProfileUsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProfileUsernameTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewProfileUsernameTextbox.Location = new System.Drawing.Point(150, 85);
            this.NewProfileUsernameTextbox.Name = "NewProfileUsernameTextbox";
            this.NewProfileUsernameTextbox.Size = new System.Drawing.Size(146, 19);
            this.NewProfileUsernameTextbox.TabIndex = 1;
            // 
            // NewProfilePasswordTextbox
            // 
            this.NewProfilePasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProfilePasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewProfilePasswordTextbox.Location = new System.Drawing.Point(150, 120);
            this.NewProfilePasswordTextbox.Name = "NewProfilePasswordTextbox";
            this.NewProfilePasswordTextbox.Size = new System.Drawing.Size(146, 19);
            this.NewProfilePasswordTextbox.TabIndex = 1;
            // 
            // SubmitNewProfileButton
            // 
            this.SubmitNewProfileButton.BackColor = System.Drawing.Color.Blue;
            this.SubmitNewProfileButton.FlatAppearance.BorderSize = 0;
            this.SubmitNewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitNewProfileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SubmitNewProfileButton.ForeColor = System.Drawing.Color.White;
            this.SubmitNewProfileButton.Location = new System.Drawing.Point(175, 158);
            this.SubmitNewProfileButton.Name = "SubmitNewProfileButton";
            this.SubmitNewProfileButton.Size = new System.Drawing.Size(88, 27);
            this.SubmitNewProfileButton.TabIndex = 2;
            this.SubmitNewProfileButton.Text = "Submit";
            this.SubmitNewProfileButton.UseVisualStyleBackColor = false;
            this.SubmitNewProfileButton.Click += new System.EventHandler(this.SubmitNewProfileButton_Click);
            // 
            // buttonhidepassword
            // 
            this.buttonhidepassword.BackColor = System.Drawing.Color.Navy;
            this.buttonhidepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhidepassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonhidepassword.Image")));
            this.buttonhidepassword.Location = new System.Drawing.Point(293, 120);
            this.buttonhidepassword.Name = "buttonhidepassword";
            this.buttonhidepassword.Size = new System.Drawing.Size(37, 21);
            this.buttonhidepassword.TabIndex = 14;
            this.buttonhidepassword.UseVisualStyleBackColor = false;
            this.buttonhidepassword.Click += new System.EventHandler(this.buttonhidepassword_Click);
            // 
            // buttonshowpassword
            // 
            this.buttonshowpassword.BackColor = System.Drawing.Color.Navy;
            this.buttonshowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonshowpassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonshowpassword.Image")));
            this.buttonshowpassword.Location = new System.Drawing.Point(293, 120);
            this.buttonshowpassword.Name = "buttonshowpassword";
            this.buttonshowpassword.Size = new System.Drawing.Size(37, 20);
            this.buttonshowpassword.TabIndex = 13;
            this.buttonshowpassword.UseVisualStyleBackColor = false;
            this.buttonshowpassword.Click += new System.EventHandler(this.buttonshowpassword_Click);
            // 
            // AddNewProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.buttonhidepassword);
            this.Controls.Add(this.buttonshowpassword);
            this.Controls.Add(this.SubmitNewProfileButton);
            this.Controls.Add(this.NewProfilePasswordTextbox);
            this.Controls.Add(this.NewProfileUsernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(485, 348);
            this.Name = "AddNewProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewProfileForm";
            this.Load += new System.EventHandler(this.AddNewProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewProfileUsernameTextbox;
        private System.Windows.Forms.TextBox NewProfilePasswordTextbox;
        private System.Windows.Forms.Button SubmitNewProfileButton;
        private System.Windows.Forms.Button buttonhidepassword;
        private System.Windows.Forms.Button buttonshowpassword;
    }
}