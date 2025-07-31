using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsExamCategoryAssignmentData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        //This method is used to Add and Update ExamCategory from ExamCategoryAssignment_AddUpdate StoredProcedure.

        public void AddUpdate(clsExamCategoryAssignment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@ExamCategoryAssignmentId", obj.ExamCategoryAssignmentId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        //This method is not used now, In Future it will use.
        //This method is used to get Exam category from ExamCategoryAssignment_Get.
        //public clsExamCategoryAssignment Load(int Id)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_Get", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@ExamCategoryAssignmentId", Id);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsExamCategoryAssignment objInfo = new clsExamCategoryAssignment();
        //                    objInfo.ExamCategoryAssignmentId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
        //                    objInfo.CategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}

        // This Method is used to Get Assigned ExamCategoeries to Participant based on selected Participant from ExamCategoryAssignment_List StoredProcedure.
        //Keywords are not using in this method.
        public List<clsExamCategoryAssignment> LoadAll(clsExamCategoryAssignment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsExamCategoryAssignment> objList = new List<clsExamCategoryAssignment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsExamCategoryAssignment objInfo = new clsExamCategoryAssignment();
                                objInfo.SNo = cnt + 1;
                                objInfo.ExamCategoryAssignmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        //This method is used to Load  Examcategories data that are not assigned  to Particular Participant  from  ExamCategoryAssignment_NotAssigned StoredProcedure.
        public List<clsExamCategoryAssignment> LoadAllAssign(clsExamCategoryAssignment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_NotAssigned", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsExamCategoryAssignment> objList = new List<clsExamCategoryAssignment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsExamCategoryAssignment objInfo = new clsExamCategoryAssignment();
                                objInfo.SNo = cnt + 1;
                                objInfo.CategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        //This method is used to delete ExamCategory from ExamCategoryAssignment_Remove StoredProcedure.
        public void Remove(clsExamCategoryAssignment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        //This Method is used to send mail Assigned Examcategory to  Participant from ParticipantAssignedExamCategories_SendEmail StoredProcedure.
        public virtual clsExamCategoryAssignment LoadByParticipantAssignedCategories(int ParticipantId1)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantAssignedExamCategories_SendEmail", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ParticipantId", ParticipantId1);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsExamCategoryAssignment objInfo = new clsExamCategoryAssignment();
                            objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;

                }
            }
        }

        public int Validation(clsExamCategoryAssignment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamCategoryAssignment_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }

    }
}
