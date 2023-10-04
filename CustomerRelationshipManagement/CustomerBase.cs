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

    class CustomerBase 
    {
        public string customerName;
        public string importance;
        public string region;
        public int deals;
        public DateTime fstDeal;
        int ident;
        public static Dictionary<string,string> customerList = new Dictionary<string,string>();
        public static List<Entity> entityList = new List<Entity>();
        public static List<Individual> individualList = new List<Individual>();

        public CustomerBase(string customerName, string importance, string region, int deals, DateTime fstDeal)
        {
            this.customerName = customerName;
            this.importance = importance;
            this.region = region;
            this.deals = deals;
            this.fstDeal = fstDeal;
        }
        public CustomerBase()
        {
        }

        ~CustomerBase()
        { 
            
        }


        public static void GetDataFromTable(ref List<string> table, string customerType)
        {
            for (int j = 0; j < Program.f1.dataGridView1.RowCount - 1; j++)
            {
                for (int i = 0; i < Program.f1.dataGridView1.ColumnCount-1; i++)
                {
                   // MessageBox.Show(customerType+" + " +Program.f1.dataGridView1.Rows[j].Cells[6].Value.ToString());
                    //Program.f1.dataGridView1.Rows[0].Cells[i].Value.ToString();
                    if (Program.f1.dataGridView1.Rows[j].Cells[6].Value.ToString() == customerType)
                        table.Add(Program.f1.dataGridView1.Rows[j].Cells[i].Value.ToString());
                }
            }
        }


        public static void ConsiderSubstring(string fltStr) {
            for (int i = 0; i < Int32.Parse(Program.f1.dataGridView1.RowCount.ToString()) - 1; i++) {
                if (!Program.f1.dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(fltStr) && fltStr != "") 
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;
                
                }
            }
        }


        public static void ConsiderRegion(string fltRg) {
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                if (!fltRg.Contains(Program.f1.dataGridView1.Rows[i].Cells[3].Value.ToString()) && fltRg != "")
                {
                    Program.f1.dataGridView1.CurrentCell = null;
                    Program.f1.dataGridView1.Rows[i].Visible = false;

                }
            }

        }


        public static void ConsiderDeals(int fltDlOne, int fltDlEnd) {
            int currentInt = 0;
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                currentInt = Int32.Parse(Program.f1.dataGridView1.Rows[i].Cells[4].Value.ToString());
                if (!(currentInt >= fltDlOne && currentInt <= fltDlEnd))
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;
                }
            }
        }

        public static void ConsiderFstDeal() {
            int fltFstDeal;
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                fltFstDeal = Int32.Parse(Program.f1.dataGridView1.Rows[i].Cells[5].Value.ToString().Substring(6, 4));
                if (Int32.Parse(DateTime.Now.ToString().Substring(6,4)) - fltFstDeal >= 3 && Program.f3.radioButton1.Checked)
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;
                }
                if (Int32.Parse(DateTime.Now.ToString().Substring(6, 4)) - fltFstDeal < 3 && Program.f3.radioButton2.Checked)
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;
                }

            }
        }

        public static void ConsiderClientType(string fltType) {
            for (int i = 0; i < Int32.Parse(Program.f1.dataGridView1.RowCount.ToString()) - 1; i++)
            {
                if (!Program.f1.dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(fltType) && fltType != "")
                {
                    Program.f1.dataGridView1.CurrentCell = null;
                    Program.f1.dataGridView1.Rows[i].Visible = false;

                }
            }

        }

        public static void ConsiderIndividualType(string fltIndType)
        {
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                if (!fltIndType.Contains(CustomerBase.customerList[Program.f1.dataGridView1.Rows[i].Cells[1].Value.ToString()]))
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;

                }
            }

        }

        public static void ConsiderEntityType(int fltETOne, int fltETEnd) {
            int currentInt = 0;
            for (int i = 0; i < Program.f1.dataGridView1.RowCount - 1; i++)
            {
                if (Int32.TryParse(CustomerBase.customerList[Program.f1.dataGridView1.Rows[i].Cells[1].Value.ToString()], out currentInt))
                    currentInt = Int32.Parse(CustomerBase.customerList[Program.f1.dataGridView1.Rows[i].Cells[1].Value.ToString()]);
                if (!(currentInt >= fltETOne && currentInt <= fltETEnd))
                {
                    Program.f1.dataGridView1.Rows[i].Visible = false;
                }
            }

        }

    }
}
