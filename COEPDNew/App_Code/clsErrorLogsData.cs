using BusinessLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsErrorLogsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //This method is used to Add and Update  <<<TableName>>> From <<<TableName>>>_AddUpdate StoredProcedure
        public void AddUpdate(clsErrorLogs obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ErrorLogs_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;

                    //Add parameter values appropriately

                    objcmd.Parameters.AddWithValue("@ErrorId", obj.ErrorId);
                    objcmd.Parameters.AddWithValue("@smallDescription1", obj.smallDescription1);
                    objcmd.Parameters.AddWithValue("@smallDescription2", obj.smallDescription2);
                    objcmd.Parameters.AddWithValue("@smallDescription3", obj.smallDescription3);
                    objcmd.Parameters.AddWithValue("@smallDescription4", obj.smallDescription4);
                    objcmd.Parameters.AddWithValue("@smallDescription5", obj.smallDescription5);
                    objcmd.Parameters.AddWithValue("@mediumDescription1", obj.mediumDescription1);
                    objcmd.Parameters.AddWithValue("@mediumDescription2", obj.mediumDescription2);
                    objcmd.Parameters.AddWithValue("@mediumDescription3", obj.mediumDescription3);
                    objcmd.Parameters.AddWithValue("@mediumDescription4", obj.mediumDescription4);
                    objcmd.Parameters.AddWithValue("@mediumDescription5", obj.mediumDescription5);
                    objcmd.Parameters.AddWithValue("@largeDescription1", obj.largeDescription1);
                    objcmd.Parameters.AddWithValue("@largeDescription2", obj.largeDescription2);
                    objcmd.Parameters.AddWithValue("@largeDescription3", obj.largeDescription3);
                    objcmd.Parameters.AddWithValue("@largeDescription4", obj.largeDescription4);
                    objcmd.Parameters.AddWithValue("@largeDescription5", obj.largeDescription5);

                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        //This method is used to get Selected  <<<TableName>>> record  From <<<TableName>>>_Get StoredProcedure
        public clsErrorLogs Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ErrorLogs_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ErrorId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsErrorLogs objInfo = new clsErrorLogs();

                            //Fill the object information appropriately

                            //objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            //objInfo.ActivityCategory=Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            //objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            //objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
    }

}