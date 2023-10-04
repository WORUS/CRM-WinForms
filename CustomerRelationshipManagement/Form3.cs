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
    public partial class Form3 : Form
    {

        public static int x, y;

        public Form3()
        {
            Program.f3 = this;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            CustomerBase.ConsiderSubstring(textBox1.Text);
            if (checkedListBox1.Items.Count > 0)
            {
                string strRgs = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    strRgs += checkedListBox1.CheckedItems[i].ToString();
                }
                CustomerBase.ConsiderRegion(strRgs);
            }
            if (!(textBox2.Text == "" && textBox3.Text == "") && Int32.TryParse(textBox2.Text,out a) && Int32.TryParse(textBox3.Text, out a)) CustomerBase.ConsiderDeals(Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            if (radioButton1.Checked || radioButton2.Checked) CustomerBase.ConsiderFstDeal();
            if ((checkBox1.Checked == false && checkBox2.Checked == true) || (checkBox1.Checked == true && checkBox2.Checked == false))
            {
                if(checkBox1.Checked)
                CustomerBase.ConsiderClientType("Физ. лицо");
                else 
                CustomerBase.ConsiderClientType("Организация");
            }
            if (checkedListBox2.Items.Count > 0 && checkBox1.Checked)
            {
                string strInfo = "";
                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    strInfo += checkedListBox2.CheckedItems[i].ToString();
                }
                CustomerBase.ConsiderIndividualType(strInfo);
            }
            if (!(textBox4.Text == "" && textBox5.Text == "") && Int32.TryParse(textBox4.Text, out a) 
                && Int32.TryParse(textBox5.Text, out a) && checkBox2.Checked) CustomerBase.ConsiderEntityType(Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text));
            Close();
            Program.f1.button11.Enabled = true;
            Program.f1.button10.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                bool mod = true;
                for (int j = 0; j < checkedListBox1.Items.Count - 1; j++)
                {
                    
                    if (checkedListBox1.Items[j].ToString() == Program.f1.dataGridView1.Rows[i].Cells[3].Value.ToString()){
                        mod = false;
                    }

                }
                if(mod)checkedListBox1.Items.Add(Program.f1.dataGridView1.Rows[i].Cells[3].Value.ToString());  
            }
            DBMS.ConnectToCustomerInfoBase();
            for (int i = 0; i < CustomerBase.individualList.Count; i++)
            {
                bool mod = true;
                for (int j = 0; j < checkedListBox2.Items.Count - 1; j++)
                {

                    if (checkedListBox2.Items[j].ToString() == CustomerBase.customerList[CustomerBase.individualList[i].customerName])
                    {
                        mod = false;
                    }

                }
                if (mod)checkedListBox2.Items.Add(CustomerBase.customerList[CustomerBase.individualList[i].customerName]);
            }
            DBMS.ConnectToCustomerBase("Customers");
            textBox4.Visible = false;
            textBox5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            checkedListBox2.Visible = false;
            x = Program.f3.checkedListBox2.Location.X;
            y = Program.f3.checkedListBox2.Location.Y;
            Program.f1.dataGridView1.CurrentCell = null;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkedListBox2.Visible = true;
            }
            else {
                checkedListBox2.Visible = false;
            }
            if (checkBox1.Checked && checkBox2.Checked) checkedListBox2.Location = new Point(checkedListBox2.Location.X, checkedListBox2.Location.Y + 50);
            else { checkedListBox2.Location = new Point(x, y); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;


            }
            else {
                textBox4.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
                label8.Visible = false;
            }
            if (checkBox1.Checked && checkBox2.Checked) checkedListBox2.Location = new Point(checkedListBox2.Location.X, checkedListBox2.Location.Y + 50);
            else { checkedListBox2.Location = new Point(x, y); }
        }
    }
}
