﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cursova
{
    class C_DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=SQL8003.site4now.net;Initial Catalog=db_a87899_illiacursov1;User Id=db_a87899_illiacursov1_admin;Password=Qwerty123");

        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
