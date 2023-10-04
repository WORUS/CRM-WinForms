using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerRelationshipManagement
{
    class DBMS
    {
        public static SqlConnection sqlConnection = null;
        public static SqlCommandBuilder sqlBuilder = null;
        public static SqlDataAdapter sqlDataAdapter = null;
        public static DataSet dataSet = null;
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public static void ConnectToCustomerBase(string baseName) { 
        sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {baseName}", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, $"{baseName}");
                Program.f1.dataGridView1.DataSource = dataSet.Tables[$"{baseName}"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ConnectToCustomerInfoBase()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Info", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Info");
                Program.f1.dataGridView1.DataSource = dataSet.Tables["Info"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static async void AddRecordToCustomerBase() {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int a;
            if (!string.IsNullOrEmpty(Program.f2.textBox1.Text) && !string.IsNullOrEmpty(Program.f2.textBox2.Text) 
                && !string.IsNullOrEmpty(Program.f2.textBox3.Text) && !string.IsNullOrEmpty(Program.f2.textBox4.Text)
                && !string.IsNullOrEmpty(Program.f2.textBox5.Text) && int.TryParse(Program.f2.textBox4.Text,out a))
            {
                
                string cmdStr;
                //if (mode == false)
                //{
                    cmdStr = $"INSERT INTO [Customers] ([{Program.f2.label1.Text}], [{Program.f2.label2.Text}], [{Program.f2.label3.Text}], [{Program.f2.label4.Text}], [{Program.f2.label5.Text}], [{Program.f2.label6.Text}])VALUES(@v1, @v2, @v3, @v4, @v5, @v6)";
                //}
                //else
                //{
                //    cmdStr = $"UPDATE [{Program.f1.dataGridView1.DataSource}] SET [{label1.Text}] = @v1, [{label2.Text}] = @v2, [{label3.Text}] = @v3, [Занято ячеек] = @v5, Производитель = @v6 Where" +
                //         $" [{Program.f1.dataGridView1.Columns[1].HeaderText}] = @v1 ";
                //}
                SqlCommand command = new SqlCommand(cmdStr, sqlConnection);
                command.Parameters.AddWithValue("v1", Program.f2.textBox1.Text);
                command.Parameters.AddWithValue("v2", Program.f2.textBox2.Text);
                command.Parameters.AddWithValue("v3", Program.f2.textBox3.Text);
                //command.Parameters.AddWithValue("v4", Program.f2.currentRack);
                command.Parameters.AddWithValue("v4", Program.f2.textBox4.Text);
                command.Parameters.AddWithValue("v5", DateTime.Today);
                command.Parameters.AddWithValue("v6", Program.f2.comboBox1.SelectedItem);
                await command.ExecuteNonQueryAsync();
                sqlConnection.Close();
                //Program.f1.button2.Enabled = true;
                Program.f2.res = true;

                Program.f2.Close();
            }
            else
            {
                MessageBox.Show("Не все данные заполнены верно.");
                Program.f2.res = false;

            }
        }

        public static async void DeleteSelectRecordFromBase() {
            SqlConnection sqlConnection = null;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DialogResult dlgRes = MessageBox.Show("Вы уверены, что хотите удалить данную строку?", "Удаление записи", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (dlgRes == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand($"DELETE FROM [{Program.f1.dataGridView1.DataSource}] WHERE [{Program.f1.dataGridView1.Columns[1].HeaderText}] = @name", sqlConnection);
                command.Parameters.AddWithValue("name", Program.f1.dataGridView1.CurrentRow.Cells[1].Value);
                await command.ExecuteNonQueryAsync();
                sqlConnection.Close();
                //Program.f1.button2.Enabled = true;
            }
            else if (dlgRes == DialogResult.No)
            {
            }
            else
            {
                MessageBox.Show("Вы заполнили не все данные либо пытаетесь удалить неверную запись.");
            }
            
        }


        static public async void ChangeRecordDataInBase() 
        {
            MessageBox.Show("Изменения работают");

            SqlConnection sqlConnection = null;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int a;
            string dateCheck = Program.f2.textBox5.Text + " 0:00:00";
            string dtachck = "";
            string dtachck1 = "";
            DateTime temp;
            if (int.TryParse(dateCheck.Substring(0, 2), out a) && int.TryParse(dateCheck.Substring(3, 2), out a))
            {
                dtachck = dateCheck.Substring(0, 2);
                dtachck1 = dateCheck.Substring(3, 2);
            }
            else
            {
                dtachck = "32";
                dtachck1 = "13";
            }
            if (dateCheck.Contains(',') || !(DateTime.TryParse(dateCheck, out temp)) || dateCheck == "" || int.Parse(dtachck) > 31 || int.Parse(dtachck1) > 12)
            {
                MessageBox.Show("Неверно заполнено поле <Дата рождения>. \nИспользуйте формат <ДД.ММ.ГГГГ>." + DateTime.TryParse(dateCheck, out temp), "Неверный ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(Program.f2.textBox1.Text) && !string.IsNullOrEmpty(Program.f2.textBox2.Text)
                && !string.IsNullOrEmpty(Program.f2.textBox3.Text) && !string.IsNullOrEmpty(Program.f2.textBox4.Text)
                && !string.IsNullOrEmpty(Program.f2.textBox5.Text) && (Program.f2.comboBox1.Text.ToString()=="Физ. лицо" || Program.f2.comboBox1.Text.ToString() == "Организация"))
            {
                
                string cmdStr = $"UPDATE [Customers] SET [{Program.f2.label1.Text}] = @v1, " +
                    $"[{Program.f2.label2.Text}] = @v2, [{Program.f2.label3.Text}] = @v3, [{Program.f2.label4.Text}] = @v4," +
                    $" [{Program.f2.label5.Text}] = @v5, [{Program.f2.label6.Text}] = @v6 Where" +
                         $" [{Program.f1.dataGridView1.Columns[1].HeaderText}] = @v7 ";
                SqlCommand command = new SqlCommand(cmdStr, sqlConnection);
                command.Parameters.AddWithValue("v1", Program.f2.textBox1.Text);
                command.Parameters.AddWithValue("v2", Program.f2.textBox2.Text);
                command.Parameters.AddWithValue("v3", Program.f2.textBox3.Text);
                //command.Parameters.AddWithValue("v4", Program.f2.currentRack);
                command.Parameters.AddWithValue("v4", Program.f2.textBox4.Text);
                command.Parameters.AddWithValue("v5", DateTime.Parse(dateCheck));
                command.Parameters.AddWithValue("v6", Program.f2.comboBox1.SelectedItem);
                command.Parameters.AddWithValue("v7", Program.f1.dataGridView1.CurrentRow.Cells[1].Value.ToString());

                await command.ExecuteNonQueryAsync();
                sqlConnection.Close();
               // Program.f1.button2.Enabled = true;
                Program.f2.res = true;
                Program.f2.Close();
            }
            else
            {
                MessageBox.Show("Не все данные были заполнены верно.");
                Program.f2.res = false;
            }
        }

        public static async void AddRecordToInfoBase()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int a;
            if (!string.IsNullOrEmpty(Program.f2.textBox1.Text) && !string.IsNullOrEmpty(Program.f2.textBox7.Text))
            {

                string cmdStr;
                //if (mode == false)
                //{
                cmdStr = $"INSERT INTO [Info] ([Информация], [Клиент])VALUES(@v1, @v2)";
                //}
                //else
                //{
                //    cmdStr = $"UPDATE [{Program.f1.dataGridView1.DataSource}] SET [{label1.Text}] = @v1, [{label2.Text}] = @v2, [{label3.Text}] = @v3, [Занято ячеек] = @v5, Производитель = @v6 Where" +
                //         $" [{Program.f1.dataGridView1.Columns[1].HeaderText}] = @v1 ";
                //}
                SqlCommand command = new SqlCommand(cmdStr, sqlConnection);
                command.Parameters.AddWithValue("v1", Program.f2.textBox7.Text);
                command.Parameters.AddWithValue("v2", Program.f2.textBox1.Text);
                await command.ExecuteNonQueryAsync();
                sqlConnection.Close();
                //Program.f1.button2.Enabled = true;
                //Program.f2.res = true;

                Program.f2.Close();
            }
            else
            {
                MessageBox.Show("Не все данные заполнены верно.");
                ////Program.f2.res = false;

            }
        }

        public static async void ChangeRecordInfoBase() {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            int a;
            
            if (!string.IsNullOrEmpty(Program.f2.textBox1.Text) && !string.IsNullOrEmpty(Program.f2.textBox7.Text))
            {

                string cmdStr;
                //if (mode == false)
                //{
                cmdStr = $"UPDATE [Info] SET [Информация] = @v1, [Клиент] = @v2 Where [Клиент] = @v3";
                //}
                //else
                //{
                //    cmdStr = $"UPDATE [{Program.f1.dataGridView1.DataSource}] SET [{label1.Text}] = @v1, [{label2.Text}] = @v2, [{label3.Text}] = @v3, [Занято ячеек] = @v5, Производитель = @v6 Where" +
                //         $" [{Program.f1.dataGridView1.Columns[1].HeaderText}] = @v1 ";
                //}
                SqlCommand command = new SqlCommand(cmdStr, sqlConnection);
                command.Parameters.AddWithValue("v1", Program.f2.textBox7.Text);
                command.Parameters.AddWithValue("v2", Program.f2.textBox1.Text);
                command.Parameters.AddWithValue("v3", Program.f1.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                await command.ExecuteNonQueryAsync();
                sqlConnection.Close();
                //Program.f1.button2.Enabled = true;
                //Program.f2.res = true;
                //ConnectToCustomerBase("Customers");
                Program.f2.Close();
            }
            else
            {
                MessageBox.Show("Не все данные заполнены верно.");
               /// Program.f2.res = false;

            }

        }

    }
}
