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
    class Individual : CustomerBase
    {
        public string contactType;
        public static string customerType = "Физ. лицо";

        public Individual(string customerName, string importance, string region, int deals, DateTime fstDeal, string contactType) : base(customerName, importance, region, deals, fstDeal)
        {
            this.contactType = contactType;
        }
        public Individual()
        {
        }

        ~Individual()
        {
        }

        static public void SetDataInList()
        {

            List<string> tableData = new List<string>();
            List<string> tableDataInfo = new List<string>();

            string infoCustomer = "";
            int colCount = Program.f1.dataGridView1.Columns.Count - 1;


            GetDataFromTable(ref tableData, customerType);
            // DBMS.ConnectToCustomerBase("Info");
            DBMS.ConnectToCustomerInfoBase();
            

            for (int i = 0; i < tableData.Count / colCount; i++)
            {
                //Individual element = new Individual(tableData[i * 5], tableData[i * 5 + 1], tableData[i *5 + 2],
                //tableData[i * 5 + 3], Convert.ToInt32(tableData[4 + i * 5]), DateTime.Parse(tableData[5 + i * 5]));
                for (int ix = 0; ix < Program.f1.dataGridView1.Rows.Count-1; ix++)
                {
                    if (Program.f1.dataGridView1.Rows[ix].Cells[2].Value.ToString() == tableData[i*6+1])
                    {
                        infoCustomer = Program.f1.dataGridView1.Rows[ix].Cells[1].Value.ToString();
                        break;
                    }

                }
                Individual elem = new Individual(tableData[i * 6+1], tableData[i * 6 + 2], tableData[i * 6 + 3],
                        Int32.Parse(tableData[i * 6 + 4]), DateTime.Parse(tableData[i * 6 + 5]), infoCustomer);
                    individualList.Add(elem);
                CustomerBase.customerList.Add(tableData[i*6+1], infoCustomer);
                //storeProductsSum += cheeseList[i].foodQuantity * cheeseList[i].foodPrice * 10;
            }



            //MessageBox.Show(individualList[0].region);
            // MessageBox.Show(individualList[1].region);
            DBMS.ConnectToCustomerBase("Customers");

        }



    }



}
