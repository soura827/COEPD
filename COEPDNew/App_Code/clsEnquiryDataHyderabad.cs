using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using BusinessLayer;


namespace DataAccessLayerHelper
{

    public class clsEnquiryDataHyderabad
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs7"].ConnectionString.ToString();
        public void AddUpdate(clsEnquiryHyderabad obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", obj.EnquiryId);
                    objCmd.Parameters.AddWithValue("@Name", obj.Name);
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.Email1);
                    objCmd.Parameters.AddWithValue("@SecondaryEmail", obj.Email2);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.Phone1);
                    objCmd.Parameters.AddWithValue("@SecondaryMobile", obj.Phone2);
                    objCmd.Parameters.AddWithValue("@Expectationsgoal", obj.Message1);
                    objCmd.Parameters.AddWithValue("@TimeFramegoal", obj.Message2);
                    objCmd.Parameters.AddWithValue("@City", obj.City);
                    objCmd.Parameters.AddWithValue("@State", obj.State);
                    objCmd.Parameters.AddWithValue("@CourseName", obj.CourseName);
                    objCmd.Parameters.AddWithValue("@Domain", obj.Domain);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objCmd.Parameters.AddWithValue("@Qualification", obj.Qualification);
                    objCmd.Parameters.AddWithValue("@SMS", obj.SMS);
                    objCmd.Parameters.AddWithValue("@Friend", obj.Friend);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@Website", obj.Website);
                    objCmd.Parameters.AddWithValue("@SocialNetworking", obj.SocialNetworking);
                    objCmd.Parameters.AddWithValue("@WalkIn", obj.WalkIn);
                    objCmd.Parameters.AddWithValue("@Agree", obj.Agree);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@TimeRequired", obj.TimeRequired);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);

                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsEnquiryHyderabad Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEnquiryHyderabad objInfo = new clsEnquiryHyderabad();
                            objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Email1 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Email2 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Phone1 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Phone2 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.City = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.State = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            
                            objInfo.Message1 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Message2 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.TimeRequired = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.SMS = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.Friend = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.Email = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.Website = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.SocialNetworking = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.WalkIn = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.Agree = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[21]);
                            
                            objInfo.PlanId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.CourseId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[23]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEnquiryHyderabad> LoadAll(clsEnquiryHyderabad obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_List", objConn))
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
                            List<clsEnquiryHyderabad> objList = new List<clsEnquiryHyderabad>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEnquiryHyderabad objInfo = new clsEnquiryHyderabad();
                                objInfo.SNo = cnt + 1;
                                objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Email2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Phone1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Phone2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Message1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Message2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.SMS = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Friend = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Email = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Website = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.SocialNetworking = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.WalkIn = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Agree = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                
                                
                                //objInfo.TimeRequired = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
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
                using (SqlCommand objCmd = new SqlCommand("Enquiry_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsEnquiryHyderabad> LoadAllReports(clsEnquiryHyderabad obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_List_Reports", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@PlanId", obj.PlanId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEnquiryHyderabad> objList = new List<clsEnquiryHyderabad>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEnquiryHyderabad objInfo = new clsEnquiryHyderabad();
                                objInfo.SNo = cnt + 1;
                                objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Email2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Phone1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Phone2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Message1 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Message2 = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.SMS = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Friend = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Email = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Website = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.SocialNetworking = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.WalkIn = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Agree = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);


                                objInfo.TimeRequired = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadEnquiryValidation(clsEnquiryHyderabad obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("Enquiry_Validation", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@PrimaryEmail", obj.Email1);
                    objcmd.Parameters.AddWithValue("@PrimaryMobile", obj.Phone1);
                    int count = Convert.ToInt32(objcmd.ExecuteScalar());
                    return count;
                }
            }
        }



    }
}