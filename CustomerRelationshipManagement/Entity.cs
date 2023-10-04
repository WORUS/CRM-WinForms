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
    class Entity : CustomerBase
    {
        public int staff;
        public static string customerType = "Организация";

        public Entity(string customerName, string importance, string region, int deals, DateTime fstDeal, int staff) : base(customerName, importance, region, deals, fstDeal)
        {
            this.staff = staff;
        }
        public Entity()
        {
        }

        ~Entity()
        {

        }

        static public void SetDataInList()
        {

            List<string> tableData = new List<string>();

            int colCount = Program.f1.dataGridView1.Columns.Count - 1;

            

            GetDataFromTable(ref tableData, customerType);
            string infoCustomer ="0";
            DBMS.ConnectToCustomerInfoBase();
            for (int i = 0; i < tableData.Count / colCount ; i++)
            {
                for (int ix = 0; ix < Program.f1.dataGridView1.Rows.Count - 1; ix++)
                {
                    if( (Program.f1.dataGridView1.Rows[ix].Cells[2].Value.ToString() == tableData[i * 6 + 1]))
                    {
                        infoCustomer = Program.f1.dataGridView1.Rows[ix].Cells[1].Value.ToString();
                        break;
                    }

                }

                Entity element = new Entity(tableData[i * 6+1], tableData[i * 6 + 2], tableData[i * 6 + 3],
                        Int32.Parse(tableData[i * 6 + 4]), DateTime.Parse(tableData[i * 6 + 5]), Int32.Parse(infoCustomer));
                entityList.Add(element);
                CustomerBase.customerList.Add(tableData[i*6+1], infoCustomer);
                //storeProductsSum += cheeseList[i].foodQuantity * cheeseList[i].foodPrice * 10;
            }
            DBMS.ConnectToCustomerBase("Customers");


            //MessageBox.Show(entityList[0].region);
            // MessageBox.Show(entityList[1].region);

        }


    }
}
