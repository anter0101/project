using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            patient f = new patient();



           
            this.Font=f.Font ;
            this.FormBorderStyle = f.FormBorderStyle;

            this.Font = f.Font;
            
        }

        private void closeee_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeee_MouseMove(object sender, MouseEventArgs e)
        {
            closeee.Image = Properties.Resources.cancel_40px;
            
        }

        private void closeee_MouseLeave(object sender, EventArgs e)
        {
            closeee.Image = Properties.Resources.cancel_48px;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (textBox1.Text == "admin" && textBox2.Text == "102030")
            {
                patient p = new patient();
                this.Hide();
                p.Show();
            }
            else
            {
                
                MessageBox.Show("enter the coteect  credentials");
            }


                
                
            }
           
        }
    }

