using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class ClsChangePasswordData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(ClsChangePassword obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ChangePassword_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ResetId", obj.ResetId);
                    objcmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objcmd.Parameters.AddWithValue("@OldPassword", obj.OldPassword);
                    objcmd.Parameters.AddWithValue("@NewPassword", obj.NewPassword);
                    objcmd.Parameters.AddWithValue("@ConfirmPassword", obj.ConfirmPassword);

                    objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public List<ClsChangePassword> LoadAllChangePwdEmployee(ClsChangePassword obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ChangePwdEmployee_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@OldPassword", obj.OldPassword);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<ClsChangePassword> objList = new List<ClsChangePassword>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                ClsChangePassword objInfo = new ClsChangePassword();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.OldPassword = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
        public ClsChangePassword Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("User_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            ClsChangePassword objInfo = new ClsChangePassword();
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Pwd = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


        public List<ClsChangePassword> LoadAll(ClsChangePassword obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ChangePassword_List", objConn))
                {
                    objConn.Open();
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<ClsChangePassword> objList = new List<ClsChangePassword>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                ClsChangePassword objInfo = new ClsChangePassword();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.ResetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[1] != DBNull.Value)
                                    objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NewPassword = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                    objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);


                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }

    }
}