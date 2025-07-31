using BusinessLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsPlacementDashboardData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();
        public clsPlacementDashboard PlacementDashboardCount(clsPlacementDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementDashboard objInfo = new clsPlacementDashboard();
                            objInfo.TotalResumesFinalized = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalMovetoPlacementWing = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalJobsPosted = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalNewFAQsAdded = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalResumesSubmitted = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.PendingSeviceRequests = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.PendingEscalations = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.PendingDataSheets = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            objInfo.AssignedProfileOwner = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
                            objInfo.PendingHRMocks = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
                            objInfo.PendingRequestFAQs = Convert.ToInt32(objDset.Tables[0].Rows[10].ItemArray[0]);
                            objInfo.PendingReviseFAQs = Convert.ToInt32(objDset.Tables[0].Rows[11].ItemArray[0]);
                            objInfo.PendingInterviewSupport = Convert.ToInt32(objDset.Tables[0].Rows[12].ItemArray[0]);
                            objInfo.TotalProfileOwnerResumes = Convert.ToInt32(objDset.Tables[0].Rows[13].ItemArray[0]);

                            return objInfo;
                        }
                    }
                    return null;

                }

            }
        }





        public clsPlacementDashboard PlacementDashboardAdminCount(clsPlacementDashboard obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementDashboardAdmin_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementDashboard objInfo = new clsPlacementDashboard();
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalJobsApplied = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalJobsAppliedStatus = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalInterviewRound1 = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalInterviewRound2 = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalInterviewRound3 = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalOffersReleased = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalOffersAccepted = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalJobsPosted = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[7].ItemArray[0]);

                            return objInfo;
                        }
                    }
                    return null;

                }

            }
        }





        public clsPlacementDashboard PlacementDashboardAdminCountAll(clsPlacementDashboard obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementDashboardAdminAll_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementDashboard objInfo = new clsPlacementDashboard();
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalJobsAppliedAll = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalJobsAppliedStatusAll = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalInterviewRound1All = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalInterviewRound2All = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalInterviewRound3All = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalOffersReleasedAll = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalOffersAcceptedAll = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalJobsPostedAll = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[7].ItemArray[0]);

                            return objInfo;
                        }
                    }
                    return null;

                }

            }
        }





        public clsPlacementDashboard PlacementDashboardAppliedThrough(clsPlacementDashboard obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementDashboardAppliedThoughStatus_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementDashboard objInfo = new clsPlacementDashboard();
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalJobsAppliedAll = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ThoughJobPortal = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.Reference = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.CoepdPortal = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.CoepdPlacementWing = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                           
                            //objInfo.SpecialNotes = Convert.ToString(objDset.Tables[0].Rows[7].ItemArray[0]);

                            return objInfo;
                        }
                    }
                    return null;

                }

            }
        }



















    }

}











































