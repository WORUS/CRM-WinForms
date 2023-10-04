using System;
using System.Windows.Forms;


namespace CustomerRelationshipManagement
{
    public partial class Form1 : Form
    {
        public static bool checker = false;

        public static int numbrRowsDgv;
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBMS.ConnectToCustomerBase("Customers");
            Individual.SetDataInList();
            Entity.SetDataInList();
            dataGridView1.Columns[0].Visible = false;
            numbrRowsDgv = dataGridView1.Rows.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 addRecord = new Form2();
            Program.f2.button1.Text = "Добавить";
            addRecord.Show();
            Program.f2.textBox5.Text = (DateTime.Today.ToString()).Substring(0,10);
            Program.f2.textBox5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DBMS.DeleteSelectRecordFromBase();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.f1.dataGridView1.CurrentCell == null) MessageBox.Show("Запись не выбрана");
            else
            {
                Form2 changeRecord = new Form2();
                Program.f2.button1.Text = "Изменить";
                changeRecord.Show();
                changeRecord.LoadDataToChange();
                Program.f2.textBox5.Enabled = true;
            }

        }


        private void button8_Click(object sender, EventArgs e)
        {
            DBMS.ConnectToCustomerBase("Customers");
            checker = false;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checker == false)
            {
                int index = 0;
                for (int i = 0; i < CustomerBase.individualList.Count; i++)
                {
                    if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == CustomerBase.individualList[i].customerName) index = i;

                }


                for (int i = 0; i < CustomerBase.entityList.Count; i++)
                {
                    if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == CustomerBase.entityList[i].customerName) index = i;

                }
                switch (dataGridView1.CurrentRow.Cells[6].Value.ToString())
                {
                    case "Физ. лицо":
                        textBox2.Text = "Полное наименование покупателя: ";
                        textBox2.Text += CustomerBase.individualList[index].customerName + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Важность покупателя: " + CustomerBase.individualList[index].importance + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Бизнес регион: " + CustomerBase.individualList[index].region + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Количество успешно совершенных покупок: " + CustomerBase.individualList[index].deals + Environment.NewLine + Environment.NewLine;
                        string correctData = CustomerBase.individualList[index].fstDeal.ToString();
                        textBox2.Text += "Дата первой сделки с клиентом: " + correctData.Substring(0, 10) + Environment.NewLine + Environment.NewLine;
                        if (Int32.Parse(DateTime.Now.ToString().Substring(6, 4)) - Int32.Parse(correctData.Substring(6, 4)) > 1)
                            textBox2.Text += "Степень доверия клиенту: " + "Высокий уровень доверия" + Environment.NewLine + Environment.NewLine;
                        else
                            textBox2.Text += "Степень доверия клиенту: " + "Низкий уровень доверия" + Environment.NewLine + Environment.NewLine;
                        //textBox2.Text += CustomerBase.individualList[0].region + Environment.NewLine;
                        textBox2.Text += "Тип покупателя: " + CustomerBase.individualList[index].contactType + Environment.NewLine + Environment.NewLine;
                        break;
                    case "Организация":
                        textBox2.Text = "Полное наименование организации: " + CustomerBase.entityList[index].customerName + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Важность организации: " + CustomerBase.entityList[index].importance + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Бизнес регион: " + CustomerBase.entityList[index].region + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Количество успешно совершенных сделок: " + CustomerBase.entityList[index].deals + Environment.NewLine + Environment.NewLine;
                        string correctDataEnt = CustomerBase.entityList[index].fstDeal.ToString();
                        textBox2.Text += "Дата начала отношений: " + correctDataEnt.Substring(0, 10) + Environment.NewLine + Environment.NewLine;
                        if (Int32.Parse(DateTime.Now.ToString().Substring(6, 4)) - Int32.Parse(correctDataEnt.Substring(6, 4)) > 1)
                            textBox2.Text += "Степень доверия к организации: " + "Высокий уровень доверия" + Environment.NewLine + Environment.NewLine;
                        else
                            textBox2.Text += "Степень доверия к организации: " + "Низкий уровень доверия" + Environment.NewLine + Environment.NewLine;
                        textBox2.Text += "Количество сотрудников: " + CustomerBase.entityList[index].staff + Environment.NewLine + Environment.NewLine;
                        break;
                }
            }
            else { MessageBox.Show("Данные можно просматривать только в основной таблице"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checker = true;
            DBMS.ConnectToCustomerBase("Info");
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

        }
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbrRowsDgv; i++) dataGridView1.Rows[i].Visible = true;
            button11.Enabled = false;
            button10.Enabled = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form3 filter = new Form3();
            filter.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static void ResetFilterParameters() {
            
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }
    

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
