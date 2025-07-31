using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerHelper
{
    public class clsCareerReplyData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCareerReply obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CareerReply_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerReplyId", obj.CareerReplyId);
                    objCmd.Parameters.AddWithValue("@Name ", obj.Name);
                    objCmd.Parameters.AddWithValue("@FatherName", obj.FatherName);
                    objCmd.Parameters.AddWithValue("@DateOfBirth ", obj.DateOfBirth);
                    objCmd.Parameters.AddWithValue("@Qualification ", obj.Qualification);
                    objCmd.Parameters.AddWithValue("@AppliedFor", obj.AppliedFor);
                    objCmd.Parameters.AddWithValue("@TotalExp ", obj.TotalExp);
                    objCmd.Parameters.AddWithValue("@RelavantExperience ", obj.RelavantExperience);
                    objCmd.Parameters.AddWithValue("@Skills", obj.Skills);
                    objCmd.Parameters.AddWithValue("@Strengths ", obj.Strengths);
                    objCmd.Parameters.AddWithValue("@CurrentDesignation  ", obj.CurrentDesignation);
                    objCmd.Parameters.AddWithValue("@CompanyAddress  ", obj.CompanyAddress);
                    objCmd.Parameters.AddWithValue("@PresentCTC", obj.PresentCTC);
                    objCmd.Parameters.AddWithValue("@ExpectedCTC", obj.ExpectedCTC);
                    objCmd.Parameters.AddWithValue("@NoticePeriod ", obj.NoticePeriod);
                    objCmd.Parameters.AddWithValue("@ReasonForChange", obj.ReasonForChange);
                    objCmd.Parameters.AddWithValue("@ResidentialAddress ", obj.ResidentialAddress);
                    objCmd.Parameters.AddWithValue("@ImagePath ", obj.ImagePath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsCareerReply Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CareerReply_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerReplyId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCareerReply objInfo = new clsCareerReply();
                            objInfo.CareerReplyId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.FatherName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.DateOfBirth = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.AppliedFor = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.TotalExp = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.RelavantExperience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Strengths = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.CurrentDesignation = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.CompanyAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.PresentCTC = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ExpectedCTC = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.NoticePeriod = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.ReasonForChange = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.ResidentialAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[18]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsCareerReply> LoadAll(clsCareerReply obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CareerReply_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCareerReply> objList = new List<clsCareerReply>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCareerReply objInfo = new clsCareerReply();
                                objInfo.SNo = cnt + 1;
                                objInfo.CareerReplyId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.FatherName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.DateOfBirth = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.AppliedFor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TotalExp = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.RelavantExperience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Strengths = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.CurrentDesignation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CompanyAddress = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PresentCTC = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ExpectedCTC = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.NoticePeriod = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReasonForChange = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.ResidentialAddress = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[18]);
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
                using (SqlCommand objCmd = new SqlCommand("CareerReply_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerReplyId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}