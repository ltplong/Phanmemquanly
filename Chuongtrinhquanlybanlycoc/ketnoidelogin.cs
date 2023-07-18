using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuongtrinhquanlybanlycoc
{
     class ketnoidelogin
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=baitaplonC#;Integrated Security=True");
        
    }
}
