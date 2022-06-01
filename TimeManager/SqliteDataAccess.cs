using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManager.Models;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace TimeManager
{
    public class SqliteDataAccess
    {
        public static List<Project> LoadProjects()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Project>("select * from Project", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveProject(Project project)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Project (Name, Description, WorkTimeSpanSec) values (@Name, @Description, @WotkTimeSpanSec)", project);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
