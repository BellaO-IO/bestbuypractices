using Dapper;
using IntroSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace bestbuypractices2
{
    class DapperDepartmentsRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        private string conn;

        //Constructor
        public DapperDepartmentsRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public DapperDepartmentsRepository(string conn)
        {
            this.conn = conn;
        }

        public IEnumerable<Department> GetAllDeparments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
        public void InsertDepartment()
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);");
            
        }
    }
}
