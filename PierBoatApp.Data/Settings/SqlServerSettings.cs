using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierBoatApp.Data.Settings
{
    public class SqlServerSettings
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDPierBoatApp;Integrated Security=True";
        }
    }
}
