using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace triggerrrrr
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static string Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string strResult = "No Result";
            string strConn = "Server=citizen.manukautech.info,6305;Database=CCQ3_Team2_Project;UID=CCQ3_Team2;PWD=fBit$34290;encrypt=true;trustservercertificate=true";
            
            try
            {
                //Create SQL Connection object
                using (SqlConnection SQLConn = new SqlConnection(strConn))
                {
                    // Open the Connection (Test to makesure it works)
                    SQLConn.Open();
                    var sqlQuery = "Select * from VidG;";
                    var sqlCommand = new SqlCommand(sqlQuery, SQLConn);
                    if (sqlCommand.Connection.State == System.Data.ConnectionState.Open)
                    {
                        sqlCommand.Connection.Close();
                    }

                    sqlCommand.Connection.Open();
                    SqlDataReader SQLReader = sqlCommand.ExecuteReader();
                    var tb = new DataTable();
                    tb.Load(SQLReader);
                    strResult = tb.Rows.Count.ToString();
                }
            }

            catch (Exception e)
            {
                strResult = e.Message; //result error message to the caller 
            }

            return strResult;
        }
    }
}
