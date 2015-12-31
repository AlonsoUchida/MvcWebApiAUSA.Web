using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MvcWebApiAUSA.DataModel.IDALs;

namespace MvcWebApiAUSA.DataModel.DALs
{
    public class NotasDAL : INotasDAL
    {
        private const string pathToSave = @"C:\TELERIK\Notas\Audio{0}.wav";
        //private const string pathToSave = @"C:\Inetpub\wwwroot\Notas\Audio{0}.wav";
        private string newPath = "";         

        public string ReadNotaUrl(string id, string not_str_archivo) 
        {
            /* using (var client = new WebClient())
             {
                 newPath = String.Format(pathToSave, id);
                 File.WriteAllBytes(newPath, client.DownloadData(not_str_archivo));
             }

             using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AUSACnn"].ToString()))
             {
                 using (SqlCommand cmd = new SqlCommand("PA_MOV_NOTA_UPDATE_2", con))
                 {
                     con.Open();
                     cmd.CommandType = CommandType.StoredProcedure;
                     SqlDataAdapter da = new SqlDataAdapter(cmd);
                     cmd.Parameters.AddWithValue("not_str_archivo", not_str_archivo);
                     cmd.Parameters.AddWithValue("new_str_archivo", newPath);
                     cmd.ExecuteNonQuery();

                     return newPath;
                 }
             }    */
            return "";
          
        }

        public string ReadNotaUrlWithEntityFramework(string id, string not_str_archivo)
        {
            /*  using (var client = new WebClient())
              {
                  newPath = String.Format(pathToSave, id);
                  File.WriteAllBytes(newPath, client.DownloadData(not_str_archivo));
              }

              using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AUSACnn"].ToString()))
              {
                  using (SqlCommand cmd = new SqlCommand("PA_MOV_NOTA_UPDATE_2", con))
                  {
                      con.Open();
                      cmd.CommandType = CommandType.StoredProcedure;
                      SqlDataAdapter da = new SqlDataAdapter(cmd);
                      cmd.Parameters.AddWithValue("not_str_archivo", not_str_archivo);
                      cmd.Parameters.AddWithValue("new_str_archivo", newPath);
                      cmd.ExecuteNonQuery();

                      return newPath;
                  }
              }*/
            return "";
        }
    }
}
