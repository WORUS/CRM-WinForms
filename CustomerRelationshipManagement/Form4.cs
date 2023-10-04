using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRelationshipManagement
{
    public partial class Form4 : Form
    {
        public static byte r_b = 51, g_b = 51, b_b = 67;          //background color
        public static byte r_f = 240, g_f = 240, b_f = 240;       //font color
        public byte r = r_b, g = g_b, b = b_b;
        public bool eyeHided = true;
        public TextBox pubBox;
        public TextBox pubBoxL;
        public Label globlab;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Form4()
        {
            Program.f4 = this;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            while (b <= b_f)
            {
                r += 2;
                g += 2;
                b += 2;
                label1.ForeColor = Color.FromArgb(r, g, b);
                await Task.Delay(5);
            }
            while (b > b_b)
            {
                r -= 2;
                g -= 2;
                b -= 2;
                label1.ForeColor = Color.FromArgb(r, g, b);
                await Task.Delay(10);
            }
            this.Controls.Clear();
            TextBox loginBox = new TextBox();
            TextBox passwordBox = new TextBox();
            PictureBox pctBox = new PictureBox();
            PictureBox userImg = new PictureBox();
            PictureBox passwordImg = new PictureBox();
            PictureBox eyePass = new PictureBox();
            Button btnLog = new Button();
            Button btnReg = new Button();
            Label lblError = new Label();
            pctBox.Image = CustomerRelationshipManagement.Properties.Resources.loginicon;
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox.Size = new Size(200,200);
            userImg.Image = CustomerRelationshipManagement.Properties.Resources.usericon;
            userImg.SizeMode = PictureBoxSizeMode.StretchImage;
            userImg.Size = new Size(40, 40);
            passwordImg.Image = CustomerRelationshipManagement.Properties.Resources.passwordi;
            passwordImg.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordImg.Size = new Size(40, 40);
            eyePass.Image = CustomerRelationshipManagement.Properties.Resources.eye;
            eyeHided = false;
            eyePass.SizeMode = PictureBoxSizeMode.StretchImage;
            eyePass.Size = new Size((int)(passwordBox.Height * 1.5), passwordBox.Height);
            eyePass.Dock = DockStyle.Right;
            loginBox.Size = new Size(300, 40);
            passwordBox.Size = new Size(300, 40);
            btnLog.Size = new Size(140, 40);
            btnReg.Size = new Size(140, 40);
            loginBox.Font = new Font(loginBox.Font.FontFamily, loginBox.Size.Height);
            passwordBox.Font = new Font(passwordBox.Font.FontFamily, passwordBox.Size.Height);
            lblError.AutoSize = true;
            //loginBox.BorderStyle = BorderStyle.Fixed3D;
            loginBox.Text = "Enter username";
            passwordBox.Text = "Password";
            loginBox.ForeColor = Color.Gray;
            passwordBox.ForeColor = Color.Gray;
            btnLog.BackColor = SystemColors.Control;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.ForeColor = Color.Gray;
            btnLog.Font = new Font(btnLog.Font.FontFamily, 19);
            btnLog.Text = "Login";
            btnReg.BackColor = SystemColors.Control;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.ForeColor = Color.Gray;
            btnReg.Font = new Font(btnLog.Font.FontFamily, 19);
            btnReg.Text = "Registry";
            loginBox.Click += new EventHandler(btnLoginClick);
            passwordBox.Click += new EventHandler(btnPasswordClick);
            loginBox.TextChanged += new EventHandler(txtLogChanging);
            eyePass.Click += new EventHandler(clickEye);
            eyePass.Move += new EventHandler(onEye);
            btnReg.Click += new EventHandler(AddNewUser);
            btnLog.Click += new EventHandler(CheckUser_Auth);
            loginBox.Location = new Point(this.Width/2 - loginBox.Width/2, 220);
            passwordBox.Location = new Point(this.Width / 2 - passwordBox.Width / 2, loginBox.Location.Y + (int)(loginBox.Height * 1.5));
            btnLog.Location = new Point(/*this.Width / 2 - btnLog.Width / 2*/passwordBox.Location.X, loginBox.Location.Y + (int)(loginBox.Height * 3));
            btnReg.Location = new Point(/*this.Width / 2 - btnLog.Width / 2*/passwordBox.Location.X + 160, loginBox.Location.Y + (int)(loginBox.Height * 3));
            pctBox.Location = new Point(this.Width / 2 - pctBox.Width / 2, loginBox.Location.Y - 175);
            userImg.Location = new Point(loginBox.Location.X - 50, loginBox.Location.Y);
            passwordImg.Location = new Point(passwordBox.Location.X - 50, passwordBox.Location.Y);
            lblError.Location = new Point(loginBox.Location.X, loginBox.Location.Y + 98);
            this.Controls.Add(loginBox);
            this.Controls.Add(passwordBox);
            this.Controls.Add(pctBox);
            this.Controls.Add(btnLog);
            this.Controls.Add(btnReg);
            this.Controls.Add(lblError);
            passwordBox.Controls.Add(eyePass);
            pubBox = passwordBox;
            pubBoxL = loginBox;
            globlab = lblError;
        }

        public void clickEye(object sender, EventArgs eventHandler) {
            PictureBox pBox = sender as PictureBox;
            if (eyeHided)
            {
                pBox.Image = Properties.Resources.eye;
                eyeHided = false;
                pubBox.UseSystemPasswordChar = false;
                
            }
            else
            {
                pBox.Image = Properties.Resources.hide;
                eyeHided = true;
                pubBox.UseSystemPasswordChar = true;
                if (pubBox.Text == "Password") pubBox.Text = "";
            }

        }

        public void onEye(object sender, EventArgs eventHandler)
        {
            PictureBox pBox = sender as PictureBox;
            pBox.Cursor = Cursors.Hand; 

        }


        public void btnLoginClick(object sender, EventArgs eventHandler) {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.Text = "";
        }
        public void btnPasswordClick(object sender, EventArgs eventHandler)
        {
            TextBox textBox = sender as TextBox;
            textBox.SelectionStart = 0;
            textBox.Text = "";
            pubBox.UseSystemPasswordChar = true;
        }
        public void txtLogChanging(object sender, EventArgs eventHandler)
        {
            TextBox txtBox = sender as TextBox;
         
        }
        public void AddNewUser(object sender, EventArgs eventHandler)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

       
        public async void CheckUser_Auth(object sender, EventArgs eventHandler)
        {
            System.IO.StreamReader authCheck = new System.IO.StreamReader("Users.txt");
            string lineLog = authCheck.ReadLine();
            if (lineLog.Substring(0, lineLog.IndexOf(":")) == pubBoxL.Text 
                && lineLog.Substring(lineLog.IndexOf(":") + 1, lineLog.Length - lineLog.IndexOf(":") - 1) == pubBox.Text)
            {
                globlab.Text = "Login successfull";
                globlab.ForeColor = Color.GreenYellow;
                authCheck.Close();
                await Task.Delay(1000);
                Form1 f1 = new Form1();
                f1.Show();
                this.Visible = false;
            }
            else 
            {
                globlab.Text = "Invalid user";
                globlab.ForeColor = Color.Red;
                authCheck.Close();
            }
           

        }


        private  void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X - 1, panel1.Location.Y);
            

              
            
        }
    }
}
