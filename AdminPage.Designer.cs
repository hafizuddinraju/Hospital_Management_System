namespace Hospital_Manament_Final_Project
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdminID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxAdminID
            // 
            this.textBoxAdminID.Location = new System.Drawing.Point(341, 148);
            this.textBoxAdminID.Name = "textBoxAdminID";
            this.textBoxAdminID.Size = new System.Drawing.Size(185, 20);
            this.textBoxAdminID.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(341, 213);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(185, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(202, 308);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(112, 33);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "SignUp";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(364, 308);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(112, 33);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(532, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(228, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(334, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "I Hospital Ltd.";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAdminID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

