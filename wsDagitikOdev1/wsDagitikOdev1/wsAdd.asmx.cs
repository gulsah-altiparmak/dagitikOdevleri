using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wsDagitikOdev1
{
    /// <summary>
    /// Summary description for wsAdd
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAdd : System.Web.Services.WebService
    {

   

        [WebMethod]
        public DataSet GetTempValues()
        {
            string cs = "data source=192.168.159.131; INITIAL CATALOG=Generate; UID=sa; PWD=Password1;";
            SqlConnection conn = new SqlConnection(cs);
            string sql = "SELECT TOP 5 * FROM TempInfoes   ORDER BY ID  DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds); 
            return ds;

        }
    }
}
