using IntroSQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace bestbuypractices2
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDeparments();
        void InsertDepartment();
    }
}
