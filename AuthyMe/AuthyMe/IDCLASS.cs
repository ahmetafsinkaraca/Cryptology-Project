using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SQLite;

namespace AuthyMe
{
    public class IDCLASS 
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
    }
}