using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;

namespace bestbuypractices2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string conn = config.GetConnectionString("DefaultConnection");
            DapperDepartmentsRepository repo = new DapperDepartmentsRepository(conn);
            var depos = repo.GetAllDeparments();
            Console.WriteLine("Press enter");
            Console.ReadLine();
            foreach (var depo in depos)
            {
                Console.WriteLine($"ID:{depo.DepartmentID}Name:{depo.Name}");
            }
            //IDbConnection conn = new MySqlConnection(connString);
            #endregion
        }
    }
}
