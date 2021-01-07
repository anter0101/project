
namespace Patient
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.closeee = new System.Windows.Forms.PictureBox();
            this.framee = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.closeee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // closeee
            // 
            this.closeee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeee.Image = global::Patient.Properties.Resources.cancel_48px;
            this.closeee.Location = new System.Drawing.Point(732, 12);
            this.closeee.Name = "closeee";
            this.closeee.Size = new System.Drawing.Size(31, 31);
            this.closeee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeee.TabIndex = 0;
            this.closeee.TabStop = false;
            this.closeee.Click += new System.EventHandler(this.closeee_Click);
            this.closeee.MouseLeave += new System.EventHandler(this.closeee_MouseLeave);
            this.closeee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closeee_MouseMove);
            // 
            // framee
            // 
            this.framee.Image = global::Patient.Properties.Resources.hospital_48px;
            this.framee.Location = new System.Drawing.Point(26, 20);
            this.framee.Name = "framee";
            this.framee.Size = new System.Drawing.Size(49, 54);
            this.framee.TabIndex = 0;
            this.framee.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logo.Location = new System.Drawing.Point(-6, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1125, 31);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(102, 220);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(129, 27);
            this.Username.TabIndex = 2;
            this.Username.Text = "Usename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Location = new System.Drawing.Point(234, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox2.Location = new System.Drawing.Point(234, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(244, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Control;
            this.Login.BorderColor = System.Drawing.SystemColors.Control;
            this.Login.ButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login.Location = new System.Drawing.Point(234, 359);
            this.Login.Name = "Login";
            this.Login.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.Login.OnHoverButtonColor = System.Drawing.SystemColors.HighlightText;
            this.Login.OnHoverTextColor = System.Drawing.SystemColors.ControlText;
            this.Login.Size = new System.Drawing.Size(256, 32);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.TextColor = System.Drawing.SystemColors.HighlightText;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 444);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeee);
            this.Controls.Add(this.framee);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox framee;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox closeee;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ePOSOne.btnProduct.Button_WOC Login;
    }
}