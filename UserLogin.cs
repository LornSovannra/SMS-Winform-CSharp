using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMGS
{
    class UserLogin
    {
        private static string EmployeeID;
        private static string EmployeeName;
        private static string UserType;

        public static void setEmployeeID(string id)
        {
            EmployeeID = id;
        }

        public static void setEmployeeName(string employeeName)
        {
            EmployeeName = employeeName;
        }

        public static void setUserTyoe(string userType)
        {
            UserType = userType;
        }

        public static string getEmployeeID()
        {
            return EmployeeID;
        }

        public static string getEmployeeName()
        {
            return EmployeeName;
        }

        public static string getUserType()
        {
            return UserType;
        }
    }
}
