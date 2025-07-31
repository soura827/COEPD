using BusinessLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsParticipantStatusDashboardData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public virtual void AddUpdate(clsParticipantStatusDashboard obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_Addupdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantStatusDashboardId", obj.ParticipantStatusDashboardId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@StatusCode", obj.StatusCode);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsParticipantStatusDashboard Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusCode_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantStatusDashboardId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.ParticipantStatusDashboardId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.StatusStartedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsStatusStart = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsStatusExit = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.StatusExitOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        //public List<clsParticipantStatusDashboard>LoadAll(clsParticipantStatusDashboard obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("ParticipantStatusCode_List", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;

        //            objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
        //            objCmd.Parameters.AddWithValue("@Modifiedname", obj.Modifiedname);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    List<clsParticipantStatusDashboard> objList = new List<clsParticipantStatusDashboard>();
        //                    for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
        //                    {
        //                        clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
        //                        objInfo.SNo = cnt + 1;
        //                        objInfo.ParticipantStatusDashboardId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
        //                        objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
        //                        objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
        //                        objInfo.StatusStartedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
        //                        objInfo.IsStatusStart = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[4]);
        //                        objInfo.IsStatusExit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
        //                        objInfo.StatusExitOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
        //                        if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
        //                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
        //                        if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
        //                            objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
        //                        objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
        //                        objInfo.Modifiedname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);

        //                        objList.Add(objInfo);
        //                    }
        //                    return objList;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}

        public int LoadParticipantStatusDashboardValidation(clsParticipantStatusDashboard obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@StatusCode", obj.StatusCode);


                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public virtual clsParticipantStatusDashboard LoadGetDuration(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_GetDuration", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.StatusStartedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalCount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalPreparation = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalLiveProjectsIdentify = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            objInfo.TotalMocks = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
                            objInfo.TotalResume = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
                            objInfo.TotalIIBACertificate = Convert.ToInt32(objDset.Tables[0].Rows[10].ItemArray[0]);
                            objInfo.TotalNotYetStartedParticipants = Convert.ToInt32(objDset.Tables[0].Rows[11].ItemArray[0]);
                            objInfo.TotalActiveParticipants = Convert.ToInt32(objDset.Tables[0].Rows[12].ItemArray[0]);
                            objInfo.TotalParticipantPlacements = Convert.ToInt32(objDset.Tables[0].Rows[13].ItemArray[0]);
                            //objInfo.TotalPlacements = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalOfferRelesed = Convert.ToInt32(objDset.Tables[0].Rows[14].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusPreparationDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusPreparationDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalPreparation = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalToolsInstallation = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalYouTubeAccessConfirmation = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusRevisionDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusRevisionDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep1 = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep2 = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep3 = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep4 = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep5 = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep6 = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep7 = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep8 = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep9 = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep10 = Convert.ToInt32(objDset.Tables[0].Rows[10].ItemArray[0]);
                            objInfo.TotalBusinessAnalystPrep11 = Convert.ToInt32(objDset.Tables[0].Rows[11].ItemArray[0]);
                            objInfo.TotalSDLCMETHODOLOGIES = Convert.ToInt32(objDset.Tables[0].Rows[12].ItemArray[0]);
                            objInfo.TotalObjectOrientedApproach = Convert.ToInt32(objDset.Tables[0].Rows[13].ItemArray[0]);
                            objInfo.TotalUseCases = Convert.ToInt32(objDset.Tables[0].Rows[14].ItemArray[0]);
                            objInfo.TotalActivityDiagrams = Convert.ToInt32(objDset.Tables[0].Rows[15].ItemArray[0]);
                            objInfo.TotalSequenceDiagramsandDomainModeling = Convert.ToInt32(objDset.Tables[0].Rows[16].ItemArray[0]);
                            objInfo.TotalUAT = Convert.ToInt32(objDset.Tables[0].Rows[17].ItemArray[0]);
                            objInfo.TotalStakeHolderAnalysis1 = Convert.ToInt32(objDset.Tables[0].Rows[18].ItemArray[0]);
                            objInfo.TotalStakeHolderAnalysis2 = Convert.ToInt32(objDset.Tables[0].Rows[19].ItemArray[0]);
                            objInfo.TotalRequirements1 = Convert.ToInt32(objDset.Tables[0].Rows[20].ItemArray[0]);
                            objInfo.TotalRequirements2 = Convert.ToInt32(objDset.Tables[0].Rows[21].ItemArray[0]);
                            objInfo.TotalRequirementElicitationTechniques = Convert.ToInt32(objDset.Tables[0].Rows[22].ItemArray[0]);
                            objInfo.TotalPrioritizationandValidation = Convert.ToInt32(objDset.Tables[0].Rows[23].ItemArray[0]);
                            objInfo.TotalMSVisioRose = Convert.ToInt32(objDset.Tables[0].Rows[24].ItemArray[0]);
                            objInfo.TotalAxureBalsamiq = Convert.ToInt32(objDset.Tables[0].Rows[25].ItemArray[0]);
                            objInfo.TotalSupportingTools = Convert.ToInt32(objDset.Tables[0].Rows[26].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusCapstoneProjectsDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusCapstoneProjectsDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalProjPrep1Case = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalProjPrep2Case = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalProjPrep3Case = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusLiveProjectsIdentifyDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusLiveProjectsIdentifyDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalLiveProjectsIdentify = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalPrevExperienceDocument = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusWaterfallModelDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusWaterfallModelDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalWaterfallProjectScopePPT = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalWaterfallProjectBAImplementation = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusAgileScrumModelDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusAgileScrumModelDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalAgileProjectScopePPT = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalAgileProjectBAImplementation = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusBAExposureDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusBAExposureDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalBlogsForumsIntroduction = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalBlogs2 = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalForums20 = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusMocksDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusMocksDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalMocks = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalBAMock1 = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalBAMockvivavoice = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusResumeDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusResumeDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalResume = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalASISResumeStage = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalTOBEResume = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalStableResumeMold = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusIIBACertificateDashboardCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusIIBACertificateDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.TotalIIBACertificate = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Total40PDHoursCertificate = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipantStatusDashboard LoadParticipantStatusPlacementsCount(clsParticipantStatusDashboard Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusPlacement_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();

                            objInfo.TotalParticipantPlacements = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            //objInfo.TotalPlacements = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalOfferRelesed = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public void Exit(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_Exit", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantStatusDashboardId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public virtual clsParticipantStatusDashboard LoadParticipantStatusCodeDashboardId(int ParticipantId, int StatusCode)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantStatusDashboard_GetParticipantStatusDashboardId", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", ParticipantId);
                    objCmd.Parameters.AddWithValue("@StatusCode", StatusCode);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantStatusDashboard objInfo = new clsParticipantStatusDashboard();
                            objInfo.ParticipantStatusDashboardId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

    }
}




