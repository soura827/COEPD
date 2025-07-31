using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsEnrollData
    {
        public string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public void AddUpdate(clsEnroll obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enroll_AddUpdate", objCon))
                {
                    objCon.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnrollId", obj.EnrollId);
                    objCmd.Parameters.AddWithValue("@Name", obj.Name);
                    objCmd.Parameters.AddWithValue("@EmailId", obj.EmailId);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsEnroll Load(int Id)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enroll_Get", objCon))
                {
                    objCon.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnrollId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEnroll objInfo = new clsEnroll();
                            objInfo.EnrollId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.CourseId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsEnroll> LoadAll(clsEnroll obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enroll_List", objCon))
                {
                    objCon.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEnroll> objList = new List<clsEnroll>();

                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEnroll objInfo = new clsEnroll();
                                objInfo.SNo = cnt + 1;
                                objInfo.EnrollId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CourseId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
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
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enroll_Remove", objCon))
                {
                    objCon.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnrollId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}