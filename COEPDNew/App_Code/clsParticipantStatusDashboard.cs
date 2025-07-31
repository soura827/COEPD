using System;

namespace BusinessLayer
{

    public class clsParticipantStatusDashboard
    {
        DataAccessLayerHelper.clsParticipantStatusDashboardData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _ParticipantStatusDashboardId;
        private int _ParticipantId;
        private int _StatusCode;
        private DateTime? _StatusStartedOn;
        private bool _IsStatusStart;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;

        private int _TotalBAConceptsRevision;
        private int _TotalCapstoneProjects;
        private int _TotalLiveProjectsIdentify;
        private int _TotalWaterfallModel;
        private int _TotalAgileScrumModel;
        private int _TotalBAExposure;
        private int _TotalMocks;
        private int _TotalResume;
        private int _TotalIIBACertificate;
        private int _TotalPreparation;
        private int _TotalCount;
        private bool _IsStatusExit;
        private DateTime? _StatusExitOn;

        private int _TotalToolsInstallation;
        private int _TotalYouTubeAccessConfirmation;
        private int _TotalBusinessAnalystPrep1;
        private int _TotalBusinessAnalystPrep2;
        private int _TotalBusinessAnalystPrep3;
        private int _TotalBusinessAnalystPrep4;
        private int _TotalBusinessAnalystPrep5;
        private int _TotalBusinessAnalystPrep6;
        private int _TotalBusinessAnalystPrep7;
        private int _TotalBusinessAnalystPrep8;
        private int _TotalBusinessAnalystPrep9;
        private int _TotalBusinessAnalystPrep10;
        private int _TotalBusinessAnalystPrep11;
        private int _TotalSDLCMETHODOLOGIES;
        private int _TotalObjectOrientedApproach;
        private int _TotalUseCases;
        private int _TotalActivityDiagrams;
        private int _TotalSequenceDiagramsandDomainModeling;
        private int _TotalUAT;
        private int _TotalStakeHolderAnalysis1;
        private int _TotalStakeHolderAnalysis2;
        private int _TotalRequirements1;
        private int _TotalRequirements2;
        private int _TotalRequirementElicitationTechniques;
        private int _TotalPrioritizationandValidation;
        private int _TotalMSVisioRose;
        private int _TotalAxureBalsamiq;
        private int _TotalSupportingTools;
        private int _TotalProjPrep1Case;
        private int _TotalProjPrep2Case;
        private int _TotalProjPrep3Case;
        private int _TotalPrevExperienceDocument;
        private int _TotalWaterfallProjectScopePPT;
        private int _TotalWaterfallProjectBAImplementation;
        private int _TotalAgileProjectScopePPT;
        private int _TotalAgileProjectBAImplementation;
        private int _TotalBlogsForumsIntroduction;
        private int _TotalBlogs2;
        private int _TotalForums20;
        private int _TotalBAMock1;
        private int _TotalBAMockvivavoice;
        private int _TotalASISResumeStage;
        private int _TotalTOBEResume;
        private int _TotalStableResumeMold;
        private int _Total40PDHoursCertificate;
        private int _TotalActiveParticipants;
        private int _TotalNotYetStartedParticipants;
        // private int _TotalPlacements;
        private int _TotalOfferRelesed;
        private int _TotalParticipantPlacements;

        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int? ParticipantStatusDashboardId { get => _ParticipantStatusDashboardId; set => _ParticipantStatusDashboardId = value; }
        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public int StatusCode { get => _StatusCode; set => _StatusCode = value; }
        public DateTime? StatusStartedOn { get => _StatusStartedOn; set => _StatusStartedOn = value; }
        public bool IsStatusStart { get => _IsStatusStart; set => _IsStatusStart = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public bool IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public int TotalBAConceptsRevision { get => _TotalBAConceptsRevision; set => _TotalBAConceptsRevision = value; }
        public int TotalCapstoneProjects { get => _TotalCapstoneProjects; set => _TotalCapstoneProjects = value; }
        public int TotalLiveProjectsIdentify { get => _TotalLiveProjectsIdentify; set => _TotalLiveProjectsIdentify = value; }
        public int TotalWaterfallModel { get => _TotalWaterfallModel; set => _TotalWaterfallModel = value; }
        public int TotalAgileScrumModel { get => _TotalAgileScrumModel; set => _TotalAgileScrumModel = value; }
        public int TotalBAExposure { get => _TotalBAExposure; set => _TotalBAExposure = value; }
        public int TotalMocks { get => _TotalMocks; set => _TotalMocks = value; }
        public int TotalResume { get => _TotalResume; set => _TotalResume = value; }
        public int TotalIIBACertificate { get => _TotalIIBACertificate; set => _TotalIIBACertificate = value; }
        public int TotalPreparation { get => _TotalPreparation; set => _TotalPreparation = value; }
        public int TotalCount { get => _TotalCount; set => _TotalCount = value; }
        public bool IsStatusExit { get => _IsStatusExit; set => _IsStatusExit = value; }
        public DateTime? StatusExitOn { get => _StatusExitOn; set => _StatusExitOn = value; }
        public int TotalToolsInstallation { get => _TotalToolsInstallation; set => _TotalToolsInstallation = value; }
        public int TotalYouTubeAccessConfirmation { get => _TotalYouTubeAccessConfirmation; set => _TotalYouTubeAccessConfirmation = value; }
        public int TotalBusinessAnalystPrep1 { get => _TotalBusinessAnalystPrep1; set => _TotalBusinessAnalystPrep1 = value; }
        public int TotalBusinessAnalystPrep2 { get => _TotalBusinessAnalystPrep2; set => _TotalBusinessAnalystPrep2 = value; }
        public int TotalBusinessAnalystPrep3 { get => _TotalBusinessAnalystPrep3; set => _TotalBusinessAnalystPrep3 = value; }
        public int TotalBusinessAnalystPrep4 { get => _TotalBusinessAnalystPrep4; set => _TotalBusinessAnalystPrep4 = value; }
        public int TotalBusinessAnalystPrep5 { get => _TotalBusinessAnalystPrep5; set => _TotalBusinessAnalystPrep5 = value; }
        public int TotalBusinessAnalystPrep6 { get => _TotalBusinessAnalystPrep6; set => _TotalBusinessAnalystPrep6 = value; }
        public int TotalBusinessAnalystPrep7 { get => _TotalBusinessAnalystPrep7; set => _TotalBusinessAnalystPrep7 = value; }
        public int TotalBusinessAnalystPrep8 { get => _TotalBusinessAnalystPrep8; set => _TotalBusinessAnalystPrep8 = value; }
        public int TotalBusinessAnalystPrep9 { get => _TotalBusinessAnalystPrep9; set => _TotalBusinessAnalystPrep9 = value; }
        public int TotalBusinessAnalystPrep10 { get => _TotalBusinessAnalystPrep10; set => _TotalBusinessAnalystPrep10 = value; }
        public int TotalBusinessAnalystPrep11 { get => _TotalBusinessAnalystPrep11; set => _TotalBusinessAnalystPrep11 = value; }
        public int TotalSDLCMETHODOLOGIES { get => _TotalSDLCMETHODOLOGIES; set => _TotalSDLCMETHODOLOGIES = value; }
        public int TotalObjectOrientedApproach { get => _TotalObjectOrientedApproach; set => _TotalObjectOrientedApproach = value; }
        public int TotalUseCases { get => _TotalUseCases; set => _TotalUseCases = value; }
        public int TotalActivityDiagrams { get => _TotalActivityDiagrams; set => _TotalActivityDiagrams = value; }
        public int TotalSequenceDiagramsandDomainModeling { get => _TotalSequenceDiagramsandDomainModeling; set => _TotalSequenceDiagramsandDomainModeling = value; }
        public int TotalUAT { get => _TotalUAT; set => _TotalUAT = value; }
        public int TotalStakeHolderAnalysis1 { get => _TotalStakeHolderAnalysis1; set => _TotalStakeHolderAnalysis1 = value; }
        public int TotalStakeHolderAnalysis2 { get => _TotalStakeHolderAnalysis2; set => _TotalStakeHolderAnalysis2 = value; }
        public int TotalRequirements1 { get => _TotalRequirements1; set => _TotalRequirements1 = value; }
        public int TotalRequirements2 { get => _TotalRequirements2; set => _TotalRequirements2 = value; }
        public int TotalRequirementElicitationTechniques { get => _TotalRequirementElicitationTechniques; set => _TotalRequirementElicitationTechniques = value; }
        public int TotalPrioritizationandValidation { get => _TotalPrioritizationandValidation; set => _TotalPrioritizationandValidation = value; }
        public int TotalMSVisioRose { get => _TotalMSVisioRose; set => _TotalMSVisioRose = value; }
        public int TotalAxureBalsamiq { get => _TotalAxureBalsamiq; set => _TotalAxureBalsamiq = value; }
        public int TotalSupportingTools { get => _TotalSupportingTools; set => _TotalSupportingTools = value; }
        public int TotalProjPrep1Case { get => _TotalProjPrep1Case; set => _TotalProjPrep1Case = value; }
        public int TotalProjPrep2Case { get => _TotalProjPrep2Case; set => _TotalProjPrep2Case = value; }
        public int TotalProjPrep3Case { get => _TotalProjPrep3Case; set => _TotalProjPrep3Case = value; }
        public int TotalPrevExperienceDocument { get => _TotalPrevExperienceDocument; set => _TotalPrevExperienceDocument = value; }
        public int TotalWaterfallProjectScopePPT { get => _TotalWaterfallProjectScopePPT; set => _TotalWaterfallProjectScopePPT = value; }
        public int TotalWaterfallProjectBAImplementation { get => _TotalWaterfallProjectBAImplementation; set => _TotalWaterfallProjectBAImplementation = value; }
        public int TotalAgileProjectScopePPT { get => _TotalAgileProjectScopePPT; set => _TotalAgileProjectScopePPT = value; }
        public int TotalAgileProjectBAImplementation { get => _TotalAgileProjectBAImplementation; set => _TotalAgileProjectBAImplementation = value; }
        public int TotalBlogsForumsIntroduction { get => _TotalBlogsForumsIntroduction; set => _TotalBlogsForumsIntroduction = value; }
        public int TotalBlogs2 { get => _TotalBlogs2; set => _TotalBlogs2 = value; }
        public int TotalForums20 { get => _TotalForums20; set => _TotalForums20 = value; }
        public int TotalBAMock1 { get => _TotalBAMock1; set => _TotalBAMock1 = value; }
        public int TotalBAMockvivavoice { get => _TotalBAMockvivavoice; set => _TotalBAMockvivavoice = value; }
        public int TotalASISResumeStage { get => _TotalASISResumeStage; set => _TotalASISResumeStage = value; }
        public int TotalTOBEResume { get => _TotalTOBEResume; set => _TotalTOBEResume = value; }
        public int TotalStableResumeMold { get => _TotalStableResumeMold; set => _TotalStableResumeMold = value; }
        public int Total40PDHoursCertificate { get => _Total40PDHoursCertificate; set => _Total40PDHoursCertificate = value; }
        public int TotalActiveParticipants { get => _TotalActiveParticipants; set => _TotalActiveParticipants = value; }
        public int TotalNotYetStartedParticipants { get => _TotalNotYetStartedParticipants; set => _TotalNotYetStartedParticipants = value; }
        // public int TotalPlacements { get => _TotalPlacements; set => _TotalPlacements = value; }
        public int TotalOfferRelesed { get => _TotalOfferRelesed; set => _TotalOfferRelesed = value; }
        public int TotalParticipantPlacements { get => _TotalParticipantPlacements; set => _TotalParticipantPlacements = value; }

        public clsParticipantStatusDashboard()
        {
            DBLayer = new DataAccessLayerHelper.clsParticipantStatusDashboardData();
        }
        public void AddUpdate(clsParticipantStatusDashboard obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public int LoadParticipantStatusDashboardValidation(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusDashboardValidation(obj);
        }
        public clsParticipantStatusDashboard LoadGetDuration(int Id)
        {
            return DBLayer.LoadGetDuration(Id);
        }
        public clsParticipantStatusDashboard Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        //public List<clsParticipantStatusDashboard> LoadAll(clsParticipantStatusDashboard obj)
        //{
        //    return DBLayer.LoadAll(obj);
        //}
        public void Exit(int Id)
        {
            DBLayer.Exit(Id);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusCodeDashboardId(int ParticipantId, int StatusCode)
        {
            return DBLayer.LoadParticipantStatusCodeDashboardId(ParticipantId, StatusCode);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusPreparationDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusPreparationDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusRevisionDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusRevisionDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusCapstoneProjectsDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusCapstoneProjectsDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusLiveProjectsIdentifyDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusLiveProjectsIdentifyDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusWaterfallModelDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusWaterfallModelDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusAgileScrumModelDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusAgileScrumModelDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusBAExposureDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusBAExposureDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusMocksDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusMocksDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusResumeDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusResumeDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusIIBACertificateDashboardCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusIIBACertificateDashboardCount(obj);
        }
        public clsParticipantStatusDashboard LoadParticipantStatusPlacementsCount(clsParticipantStatusDashboard obj)
        {
            return DBLayer.LoadParticipantStatusPlacementsCount(obj);
        }
    }
}
