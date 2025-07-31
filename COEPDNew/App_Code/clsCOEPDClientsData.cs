using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsCOEPDClientsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCOEPDClients obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClients_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@COEPDClientsId", obj.COEPDClientsId);
                    objCmd.Parameters.AddWithValue("@COEPDClientsName", obj.COEPDClientsName);
                    objCmd.Parameters.AddWithValue("@ImagePath", obj.ImagePath);
                    objCmd.Parameters.AddWithValue("@ImageThumbPath", obj.ImageThumbPath);
                    objCmd.Parameters.AddWithValue("@Website", obj.Website);
                    objCmd.Parameters.AddWithValue("@IsFeatured", obj.IsFeatured);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsCOEPDClients Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClients_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@COEPDClientsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCOEPDClients objInfo = new clsCOEPDClients();
                            objInfo.COEPDClientsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.COEPDClientsName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ImageThumbPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsFeatured = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsCOEPDClients> LoadAll(clsCOEPDClients obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClients_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsFeatured", obj.IsFeatured);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCOEPDClients> objList = new List<clsCOEPDClients>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCOEPDClients objInfo = new clsCOEPDClients();
                                objInfo.SNo = cnt + 1;
                                objInfo.COEPDClientsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.COEPDClientsName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ImageThumbPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.IsFeatured = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsCOEPDClients> LoadAllClients(clsCOEPDClients obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClientss_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsFeatured", obj.IsFeatured);
                    
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCOEPDClients> objList = new List<clsCOEPDClients>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCOEPDClients objInfo = new clsCOEPDClients();
                                objInfo.SNo = cnt + 1;
                                objInfo.COEPDClientsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.COEPDClientsName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ImageThumbPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.IsFeatured = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public clsCOEPDClients LoadTotalCOEPDClients(clsCOEPDClients Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClients_Total", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCOEPDClients objInfo = new clsCOEPDClients();
                            objInfo.TotalCOEPDClients = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("COEPDClients_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@COEPDClientsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}