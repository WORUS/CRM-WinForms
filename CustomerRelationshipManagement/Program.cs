using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRelationshipManagement
{
    static class Program
    {
        public static Form1 f1;
        public static Form2 f2;
        public static Form3 f3;
        public static Form4 f4;
        public static Form5 f5;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
        }
    }
}
