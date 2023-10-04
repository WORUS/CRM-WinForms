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

namespace CustomerRelationshipManagement
{
    public partial class Form5 : Form
    {
        public string pwdText = "";
        public string logText = "";
        public TextBox txtPubLog;
        public TextBox txtPubPwd;
        public Label globLab;

        public Form5()
        {
            Program.f5 = this;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Program.f4.BackColor;

            TextBox loginBox = new TextBox();
            TextBox passwordBox = new TextBox();
            PictureBox pctBox = new PictureBox();
            PictureBox eyePass = new PictureBox();
            Label lblError = new Label();
            Button btnReg = new Button();

            pctBox.Image = CustomerRelationshipManagement.Properties.Resources.loginicon;
            pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBox.Size = new Size(200, 200);
            eyePass.Image = CustomerRelationshipManagement.Properties.Resources.hide;
            eyePass.SizeMode = PictureBoxSizeMode.StretchImage;
            eyePass.Size = new Size((int)(passwordBox.Height * 1.5), passwordBox.Height);
            eyePass.Dock = DockStyle.Right;
            loginBox.Size = new Size(300, 40);
            passwordBox.Size = new Size(300, 40);
            btnReg.Size = new Size(140, 40);
            loginBox.Font = new Font(loginBox.Font.FontFamily, loginBox.Size.Height);
            passwordBox.Font = new Font(passwordBox.Font.FontFamily, passwordBox.Size.Height);
            lblError.AutoSize = true;
            //loginBox.BorderStyle = BorderStyle.Fixed3D;
            loginBox.Text = "Create username";
            passwordBox.Text = "Create password";
            loginBox.ForeColor = Color.Gray;
            passwordBox.ForeColor = Color.Gray;
           
            btnReg.BackColor = SystemColors.Control;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.ForeColor = Color.Gray;
            btnReg.Font = new Font(btnReg.Font.FontFamily, 19);
            btnReg.Text = "Registry";


            lblError.BringToFront();

            btnReg.Click += new EventHandler(AddNewUserF5);



            loginBox.Location = new Point(this.Width / 2 - loginBox.Width / 2, 220);
            passwordBox.Location = new Point(this.Width / 2 - passwordBox.Width / 2, loginBox.Location.Y + (int)(loginBox.Height * 1.5));
            //btnLog.Location = new Point(/*this.Width / 2 - btnLog.Width / 2*/passwordBox.Location.X, loginBox.Location.Y + (int)(loginBox.Height * 3));
            btnReg.Location = new Point(this.Width / 2 - btnReg.Width / 2, loginBox.Location.Y + (int)(loginBox.Height * 3));
            pctBox.Location = new Point(this.Width / 2 - pctBox.Width / 2, loginBox.Location.Y - 175);
            lblError.Location = new Point(loginBox.Location.X, loginBox.Location.Y + 98);

            this.Controls.Add(loginBox);
            this.Controls.Add(passwordBox);
            this.Controls.Add(pctBox);
           // this.Controls.Add(btnLog);
            this.Controls.Add(btnReg);
            this.Controls.Add(lblError);
            passwordBox.Controls.Add(eyePass);

            txtPubLog = loginBox;
            txtPubPwd = passwordBox;
            globLab = lblError;


        }

        public async void AddNewUserF5(object sender, EventArgs eventHandler) {
            if (txtPubLog.Text == "Create username" || txtPubLog.Text.Contains(" ") || txtPubLog.Text.Length < 8)
            {
                globLab.Text = "Login is not valid";
                globLab.ForeColor = Color.Red;
            }
            else if (txtPubPwd.Text == "Create password" || txtPubPwd.Text.Contains(" ") || txtPubPwd.Text.Length < 8) {
                globLab.Text = "Password is not valid";
                globLab.ForeColor = Color.Red;
            }
            else
            {
                StreamWriter authStrm = new StreamWriter("Users.txt");
                authStrm.WriteLine(txtPubLog.Text + ":" + txtPubPwd.Text);
                authStrm.Close();
                globLab.Text = "Registration successful";
                globLab.ForeColor = Color.GreenYellow;
                await Task.Delay(1000);
                this.Close();
            }

        }

    }
}
