using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Patient
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
           if (File.Exists(id.Text+"/"+id.Text + ".txt"))
            {
                MessageBox.Show("ID is  exist");
                id.Focus();
                id.SelectAll();
                return;
            }
       

            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                {
                    if (x.Text.Trim() == "") 
                    {
                        MessageBox.Show("Complete All The Form", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }

            Directory.CreateDirectory(id.Text);
            StreamWriter group = new StreamWriter("group.txt",true);
           
            group.WriteLine(
            "National Id: "+id.Text+"."
            +"Frist Name:"+name.Text + "."
            +"Last Name:"+lastname.Text + "."
            +"Age:"+age.Text + "."
            +"Bloodtype:"+blood.Text + "."
            +"regstiration date:"+date.Text + "."
            +"Phone number:"+phone.Text + "."
            +"Case:"+pcase.Text + "."
            +"Address:"+address.Text+"."
            +"Doctor Name:"+doctor.Text + "."
            );group.Close();

            StreamWriter profile = new StreamWriter(id.Text+"/"+ id.Text + ".txt");
            profile.WriteLine(
            "National Id: "+id.Text+"."
            +"Frist Name:"+name.Text + "."
            +"Last Name:"+lastname.Text + "."
            +"Age:"+age.Text + "."
            +"Bloodtype:"+blood.Text + "."
            +"regstiration date:"+date.Text + "."
            +"Phone number:"+phone.Text + "."
            +"Case:"+pcase.Text + "."
            +"Address:"+address.Text+"."
            +"Doctor Name:"+doctor.Text + "."
            );profile.Close();


    

            personpic.Image.Save(id.Text+"/" + id.Text + ".jpg");
           
            foreach(Control x in this.Controls)
            {
                if(x is TextBox || x is ComboBox )
                {
                    x.Text = "";
                }
            }
            
            personpic.Image = global::Patient.Properties.Resources.user_1648810_1401302;
            personpic.SizeMode = PictureBoxSizeMode.StretchImage;
            personpic.Image.Save(id.Text+"/"+ id.Text + ".jpg");

        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images|*.jpg;*.png";
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (open.ShowDialog() == DialogResult.OK)
            {
                personpic.Image = Image.FromFile(open.FileName);
                personpic.SizeMode = PictureBoxSizeMode.StretchImage;
               
               
                
            }
            
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (id.Text.Trim() == "")
            {
                MessageBox.Show("Enter The patient Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id.Focus();
                id.SelectAll();
                return;
            }
            
            
            profilee p = new profilee();
            PictureBox personal = new PictureBox();
            personal.BorderStyle=BorderStyle.Fixed3D;
            string path = id.Text + "/" + id.Text + ".jpg";
            if (File.Exists(path))
            personal.Image = Image.FromFile(path);
            personal.SizeMode = PictureBoxSizeMode.StretchImage;

            personal.Location = personpic.Location;
            personal.Size = personpic.Size;
         


            if (!Directory.Exists(id.Text))
            {
                
                MessageBox.Show("patient ID not found !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                id.Focus();
                id.SelectAll();
                return;
            }


            this.Hide();
         
            p.Show();
            p.Size = this.Size;
            p.Font = this.Font;
            p.FormBorderStyle = this.FormBorderStyle;
            p.StartPosition = this.StartPosition;
           
            try
            {

                StreamReader show = new StreamReader(id.Text+ "/" + id.Text + ".txt");
                string data = show.ReadToEnd();
                show.Close();
                string[] line = data.Split('.');
                StreamWriter outdata = new StreamWriter(id.Text + "/" + id.Text + ".txt");
                string photo_path = "photos/" + id.Text + ".jpg";
                foreach (string x in line)
                {


                    outdata.WriteLine(x);

                }


                outdata.Close();
                StreamReader outdata2 = new StreamReader(id.Text + "/" + id.Text + ".txt");
                string f = outdata2.ReadToEnd();
                outdata2.Close();

                Label data2 = new Label();


                p.Controls.Add(data2);
             
                p.Controls.Add(this.panale);
                p.Controls.Add(this.pictureBox3);

                p.Controls.Add(personal);
                data2.Location = new Point(22, 87);
                data2.Size = new Size(501, 464);
                data2.Text = f;

            }
            catch
            {
                MessageBox.Show("patient ID not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
                
            
           
            
        }

       

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (!File.Exists( "group.txt"))
            {
                File.Create("group.txt");
               MessageBox.Show("NO patient ID Found to Show", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
               
            }
           
          {

                try
                {
                    
                    StreamReader show = new StreamReader("group.txt");
                    string data = show.ReadToEnd();
                    show.Close();
                    string[] line = data.Split('.');
                    StreamWriter outdata = new StreamWriter("all.txt");
                    int counter = 0;
                    int n = 10;
                    foreach (string x in line)
                    {


                        outdata.WriteLine(x);
                        counter++;
                        if (counter == n)
                        {
                            outdata.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            n += 10;
                        }

                    }
                    profilee all = new profilee();
                    this.Hide();
                    all.Show();
                    all.Size = this.Size;
                    all.Font = this.Font;
                    all.Icon = this.Icon;
                    all.FormBorderStyle = this.FormBorderStyle;
                    all.StartPosition = this.StartPosition;
                    outdata.Close();
                    StreamReader outdata2 = new StreamReader("all.txt");
                    string f = outdata2.ReadToEnd();
                    outdata2.Close();
                    TextBox data2 = new TextBox();
                    data2.ReadOnly = true;
                    data2.Width = 700;
                    data2.Height = 566;
                    all.Controls.Add(data2);
                    data2.ScrollBars = ScrollBars.Vertical;
                    data2.Multiline = true;
                    data2.Text = f;


                    data2.Location = new Point(40, 97);
                    all.Controls.Add(data2);

                    all.Controls.Add(this.panale);
                }
                catch 
                {
                    MessageBox.Show("patient ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            
            }
            
           
           


        }
      

        private void button_WOC4_Click(object sender, EventArgs e)
        {

            try
            {
                DirectoryInfo inf = new DirectoryInfo(@id.Text);
                foreach (FileInfo f in inf.GetFiles())
                {
                    f.Delete();
                }
                Directory.Delete(id.Text);
            }
            catch { MessageBox.Show("patient ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            



            
          
           

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            close.Image = Properties.Resources.dooropen;
        }

        private void close_Click(object sender, EventArgs e)
        {

            Hide();
            login_form m = new login_form();
            m.Show();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.doorclose;
        }
    }
}
