
namespace Patient
{
    partial class profilee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilee));
            this.back = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.ButtonColor = System.Drawing.SystemColors.Control;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(491, 679);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.OnHoverTextColor = System.Drawing.Color.Black;
            this.back.Size = new System.Drawing.Size(128, 76);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.TextColor = System.Drawing.Color.Black;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // profilee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 808);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profilee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "profilee";
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC back;
    }
}