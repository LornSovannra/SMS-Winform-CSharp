﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace SalesMGS
{
    class DBConnection
    {
        //Data Member
        private static OracleConnection conn;

        //Static Method
        public static OracleConnection Connect()
        {
            try
            {
                conn = new OracleConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectToDB"].ToString();
                conn.Open();

                //MessageBox.Show("Connected to DB!");

                return conn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                return null;
            }
        }
    }
}
