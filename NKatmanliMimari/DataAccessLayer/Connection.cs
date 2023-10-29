using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    // DataAccessLayer projesinde baglantiların class'ı
    public class Connection
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DEVRAN-PC\SQLEXPRESS;Initial Catalog=DBPersonNMimari;Integrated Security=True");

    }

}





// CTRL + K + D  == EDIT