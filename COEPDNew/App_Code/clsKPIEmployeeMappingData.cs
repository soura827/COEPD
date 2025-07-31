using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsKPIEmployeeMappingData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsKPIEmployeeMapping obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIEmployeeMapping_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@KPIEmployeeMappingId", obj.KPIEmployeeMappingId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@KPIId", obj.KPIId);
                    objcmd.Parameters.AddWithValue("@TargetForMonth", obj.TargetForMonth);
                    objcmd.Parameters.AddWithValue("@createdBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsKPIEmployeeMapping Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIEmployeeMapping_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("KPIEmployeeMappingId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsKPIEmployeeMapping objInfo = new clsKPIEmployeeMapping();
                            objInfo.KPIEmployeeMappingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.KPIId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.TargetForMonth = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public int LoadKPIEmployeeValidation(clsKPIEmployeeMapping obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIEmployeeMapping_Validation", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@KPIId", obj.KPIId);
                    int count = Convert.ToInt32(objcmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public List<clsKPIEmployeeMapping> LoadAll(clsKPIEmployeeMapping obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIEmployeeMapping_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@KPIName", obj.KPIName);
                    objcmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objcmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objcmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsKPIEmployeeMapping> objList = new List<clsKPIEmployeeMapping>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsKPIEmployeeMapping objInfo = new clsKPIEmployeeMapping();
                                objInfo.SNO = cnt + 1;
                                objInfo.KPIEmployeeMappingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.TargetForMonth = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CreatedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }

                }
                return null;
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("KPIEmployeeMapping_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("KPIEmployeeMappingId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}