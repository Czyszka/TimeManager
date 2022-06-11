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
        public static void CreateProject(Project project)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Project (Id, Name, Description, WorkTimeSpanSec) VALUES (@Id, @Name, @Description, @WorkTimeSpanSec)", project);
            }
        }
        public static List<Project> ReadProjects()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Project>("SELECT Id, Name, Description, WorkTimeSpanSec FROM Project", new DynamicParameters());//todo check solutions for better performance from Dapper Github
                return output.ToList();
            }
        }
        public static void UpdateProject(Project project)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Project SET Name = @Name, Description = @Description, WorkTimeSpanSec = @WorkTimeSpanSec WHERE Id = @Id", project);
            }
        }

        public static void DeleteProject(Project project)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Project WHERE Id = @Id", project);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
