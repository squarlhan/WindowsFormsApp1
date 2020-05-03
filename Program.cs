using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using DBTestCs;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

         //   Util u = new Util();
           // u.init();
          //  Oil obj = u.GetOilFromDB(1);
           // Console.WriteLine(obj.toString());

           // u.SetOilToDB(obj);
        }
    }
}
