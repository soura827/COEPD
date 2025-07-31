using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsSessionDetailsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs9"].ConnectionString.ToString();
        public void AddUpdate(clsSessionDetails obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("SessionDetails_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;

                    objcmd.Parameters.AddWithValue("@SessionTypeId", obj.SessionTypeId);
                    objcmd.Parameters.AddWithValue("@SessionName", obj.SessionName);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsSessionDetails> LoadAll(clsSessionDetails obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("SessionDeatails_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                   
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsSessionDetails> objList = new List<clsSessionDetails>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsSessionDetails objInfo = new clsSessionDetails();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.SessionTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.SessionName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }


        public clsSessionDetails Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("sessionDetails_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SessionTypeId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsSessionDetails objInfo = new clsSessionDetails();
                           
                            objInfo.SessionTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.SessionName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                          
                        

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }



        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("SessionDetails_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SessionTypeId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}