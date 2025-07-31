using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsBranchData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsBranch obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Branch_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@Code", obj.Code);
                    objCmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    objCmd.Parameters.AddWithValue("@Address1", obj.Address1);
                    objCmd.Parameters.AddWithValue("@Address2", obj.Address2);
                    objCmd.Parameters.AddWithValue("@City", obj.City);
                    objCmd.Parameters.AddWithValue("@StateName", obj.StateName);
                    objCmd.Parameters.AddWithValue("@Country", obj.Country);
                    objCmd.Parameters.AddWithValue("@Zipcode", obj.Zipcode);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@Langitude", obj.Langitude);
                    objCmd.Parameters.AddWithValue("@Latitude", obj.Latitude);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsBranch Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Branch_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BranchId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBranch objInfo = new clsBranch();
                            objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Address1 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Address2 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.City = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.StateName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Country = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Zipcode = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.Langitude = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.Latitude = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            //objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            //objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[16]);
                            //objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[17]);
                            //objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[18]);
                            //objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[19]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsBranch> LoadAll(clsBranch obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Branch_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objCmd.Parameters.AddWithValue("@Modifiedname", obj.Modifiedname);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsBranch> objList = new List<clsBranch>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsBranch objInfo = new clsBranch();
                                objInfo.SNo = cnt + 1;
                                objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Address1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Address2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.StateName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Country = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Zipcode = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[16] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objList.Add(objInfo);
                            }
                            return objList;
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
                using (SqlCommand objCmd = new SqlCommand("Branch_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BranchId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}