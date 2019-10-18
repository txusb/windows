using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SerialConnect
{
    class SqlHelper
    {
        public static void SelectMake(System.Windows.Forms.ComboBox box)
        {
            box.Items.Clear();
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            string sql = "select distinct Make , Make_Img from `Summary table` where `Direct Fit` not in('NA') and `Make`  IS NOT NULL and `Make_Img` not in('NA') order by Make asc";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader["Make"]);
                Console.WriteLine("Make: " + reader["Make"]);
            }
        }
        public static void SelectModel(System.Windows.Forms.ComboBox box, String make)
        {
            box.Items.Clear();
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            string sql = "select distinct Model from `Summary table` where Make = '" + make + "' and  `Direct Fit` not in('NA') order by Model asc";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader["Model"]);
                Console.WriteLine("Model: " + reader["Model"]);
            }
        }
        public static void SelectYear(System.Windows.Forms.ComboBox box, String make, String model)
        {
            box.Items.Clear();
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            string sql = "select distinct Year from `Summary table` where Model = '" + model + "' and Make = '" + make + "' and  `Direct Fit` not in('NA') order by Year asc";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                box.Items.Add(reader["Year"]);
                Console.WriteLine("Year: " + reader["Year"]);
            }
        }
        public static String GetS19(String make,String model,String year)
        {
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            string sql = "select  `Direct Fit` from `Summary table` where Make = '"+ make+"' and Model='"+model+"' and Year='"+year+ "' and `Direct Fit` not in('NA') limit 0,1";
            Console.WriteLine("sql: " + sql);
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine("Direct Fit: " + reader["Direct Fit"]);
                return reader["Direct Fit"].ToString();
            }
            return "nodata";
        }
        public static int Idcount(String s19) {
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            string sql = "select `ID_Count` from `Summary table` where `Direct Fit`='"+s19+ "' and `Make_Img` not in('NA') limit 0,1";
            Console.WriteLine("sql: " + sql);
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("ID_Count: " + reader["ID_Count"]);
                String t = reader["ID_Count"].ToString();
                return int.Parse(t);
            }
            return 8;
        }
        public static void getrelarm(TextBox a,string make,string model,string year) {
            string databaseFileName = "usb_tx_mmy.db";
            string connectionString = "data source = " + databaseFileName;
            string colname = "English";
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            switch(FormMain.language){
                case "繁體中文":
                    colname = "Relearn Procedure (Traditional Chinese)";
                    break;
                case "简体中文":
                    colname = "Relearn Procedure (Jane)";
                    break;
                case "Deutsch":
                    colname = "Relearn Procedure (German)";
                    break;
                case "English":
                    colname = "Relearn Procedure (English)";
                    break;
                case "Italiano":
                    colname = "Relearn Procedure (Italian)";
                    break;
            }
            string sql = "select `"+ colname+"` from `Summary table` where make='"+make+"' and model='"+ model+"' and year='"+year+"' limit 0,1";
            Console.WriteLine("sql: " + sql);
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("relarm: " + reader[colname]);
                String t = reader[colname].ToString().Replace("\n","\r\n");
                a.Text = t;
            }
            if (a.Text.Replace(" ","").Length==0) {
                switch (FormMain.language)
                {
                    case "繁體中文":
                        a.Text = "學碼流程尚未完成，請耐心等待，我們會儘快更新";
                        break;
                    case "简体中文":
                        a.Text = "学码流程尚未完成，请耐心等待，我们会尽快更新";
                        break;
                    case "Deutsche":
                        a.Text = "Im Bau";
                        break;
                    case "English":
                        a.Text = "Under construction";
                        break;
                    case "Italiano":
                        a.Text = "Apprendimento in fase di Controllo.";
                        break;
                }
            };
        }
    }
}
