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
    public partial class Form2 : Form
    {

        public bool res;
        public Form2()
        {
            Program.f2 = this;
            InitializeComponent();
        }

        public void LoadDataToChange() {
           
                Program.f2.textBox1.Text = Program.f1.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.f2.textBox2.Text = Program.f1.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Program.f2.textBox3.Text = Program.f1.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Program.f2.textBox4.Text = Program.f1.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Program.f2.textBox5.Text = Program.f1.dataGridView1.CurrentRow.Cells[5].Value.ToString().Substring(0, 10);
                Program.f2.textBox7.Text = CustomerBase.customerList[Program.f1.dataGridView1.CurrentRow.Cells[1].Value.ToString()];

                switch (Program.f1.dataGridView1.CurrentRow.Cells[6].Value.ToString())
                {
                    case "Физ. лицо":
                        comboBox1.SelectedItem = comboBox1.Items[0];
                        break;
                    case "Организация":
                        comboBox1.SelectedItem = comboBox1.Items[1];

                        break;
                }
                comboBox1.Enabled = false;
                //Program.f2.textBox5.Text = Program.f1.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            comboBox1.Items.Add("Физ. лицо");
            comboBox1.Items.Add("Организация");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) {
                case 0:
                    label7.Text = "*Тип контакта";
                    textBox7.Enabled = true;
                    label8.Visible = true;
                    break;
                case 1:
                    label7.Text = "Кол-во сотрудников";
                    textBox7.Enabled = true;
                    label8.Visible = false;
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool tmp = res;
            
            if (button1.Text == "Добавить") 
            {
                DBMS.AddRecordToCustomerBase();
                if (comboBox1.SelectedIndex == 0 && res) {
                    Individual element = new Individual(textBox1.Text, textBox2.Text, textBox3.Text,
                        int.Parse(textBox4.Text), DateTime.Parse(textBox5.Text+" 0:00:00"), textBox7.Text);
                    CustomerBase.individualList.Add(element);
                   // CustomerBase.customerList.Add();
                }
                if (comboBox1.SelectedIndex == 1 && res)
                {
                    Entity element = new Entity(textBox1.Text, textBox2.Text, textBox3.Text,
                        int.Parse(textBox4.Text), DateTime.Parse(textBox5.Text + " 0:00:00"), int.Parse(textBox7.Text));
                    CustomerBase.entityList.Add(element);
                    MessageBox.Show(CustomerBase.entityList[CustomerBase.entityList.Count - 1].region);
                }
                DBMS.AddRecordToInfoBase();
            }


            //public Individual(string customerName, string importance, string region, string contactType, int deals, DateTime fstDeal) : base(customerName, importance, region, deals, fstDeal)

            if (button1.Text == "Изменить")
            {
                DBMS.ChangeRecordDataInBase();
                //if (comboBox1.SelectedIndex == 0)
                //{
                //    Entity element;
                //
                DBMS.ChangeRecordInfoBase();
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Необходимо заполнить поле <" + label7.Text + ">");
                }
                CustomerBase.customerList.Remove(Program.f1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                CustomerBase.customerList.Add(Program.f2.textBox1.Text, textBox7.Text);
            }
            res = tmp;
        }
    }
}
