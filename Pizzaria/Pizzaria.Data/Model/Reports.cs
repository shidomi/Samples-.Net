using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Pizzaria.Data.Model
{
    public class Reports
    {
        public DataTable GetReport()
        {
            string connectionString = WebConfigurationManager.AppSettings["ConnectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand(Resources.Resource.Report, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dt.Load(reader);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                    connection.Close();
                }

                return null;
            }
        }
    }
}