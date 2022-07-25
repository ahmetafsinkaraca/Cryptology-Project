
namespace AuthyMe
{
    partial class MasterPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPasswordForm));
            this.MasterPassTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MasterPassSubmitButton = new System.Windows.Forms.Button();
            this.buttonshowmaster = new System.Windows.Forms.Button();
            this.buttonhidemaster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MasterPassTextbox
            // 
            this.MasterPassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasterPassTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MasterPassTextbox.Location = new System.Drawing.Point(128, 139);
            this.MasterPassTextbox.Name = "MasterPassTextbox";
            this.MasterPassTextbox.Size = new System.Drawing.Size(191, 20);
            this.MasterPassTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(134, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter MasterPassword";
            // 
            // MasterPassSubmitButton
            // 
            this.MasterPassSubmitButton.BackColor = System.Drawing.Color.Red;
            this.MasterPassSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MasterPassSubmitButton.FlatAppearance.BorderSize = 0;
            this.MasterPassSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MasterPassSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MasterPassSubmitButton.ForeColor = System.Drawing.Color.White;
            this.MasterPassSubmitButton.Location = new System.Drawing.Point(178, 165);
            this.MasterPassSubmitButton.Name = "MasterPassSubmitButton";
            this.MasterPassSubmitButton.Size = new System.Drawing.Size(76, 27);
            this.MasterPassSubmitButton.TabIndex = 2;
            this.MasterPassSubmitButton.Text = "Submit";
            this.MasterPassSubmitButton.UseVisualStyleBackColor = false;
            this.MasterPassSubmitButton.Click += new System.EventHandler(this.MasterPassSubmitButton_Click);
            // 
            // buttonshowmaster
            // 
            this.buttonshowmaster.BackColor = System.Drawing.Color.Gray;
            this.buttonshowmaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonshowmaster.Image = ((System.Drawing.Image)(resources.GetObject("buttonshowmaster.Image")));
            this.buttonshowmaster.Location = new System.Drawing.Point(325, 139);
            this.buttonshowmaster.Name = "buttonshowmaster";
            this.buttonshowmaster.Size = new System.Drawing.Size(41, 20);
            this.buttonshowmaster.TabIndex = 3;
            this.buttonshowmaster.UseVisualStyleBackColor = false;
            this.buttonshowmaster.Click += new System.EventHandler(this.buttonshowmaster_Click);
            // 
            // buttonhidemaster
            // 
            this.buttonhidemaster.BackColor = System.Drawing.Color.Gray;
            this.buttonhidemaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhidemaster.Image = ((System.Drawing.Image)(resources.GetObject("buttonhidemaster.Image")));
            this.buttonhidemaster.Location = new System.Drawing.Point(325, 139);
            this.buttonhidemaster.Name = "buttonhidemaster";
            this.buttonhidemaster.Size = new System.Drawing.Size(41, 20);
            this.buttonhidemaster.TabIndex = 4;
            this.buttonhidemaster.UseVisualStyleBackColor = false;
            this.buttonhidemaster.Click += new System.EventHandler(this.buttonhidemaster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Please set a master password (if you already set a master password please enter)" +
    "";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(431, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 35);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MasterPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(474, 270);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonhidemaster);
            this.Controls.Add(this.buttonshowmaster);
            this.Controls.Add(this.MasterPassSubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasterPassTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(474, 270);
            this.Name = "MasterPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterPasswordForm";
            this.Load += new System.EventHandler(this.MasterPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MasterPassTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MasterPassSubmitButton;
        private System.Windows.Forms.Button buttonshowmaster;
        private System.Windows.Forms.Button buttonhidemaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
    }
}