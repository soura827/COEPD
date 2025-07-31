namespace BusinessLayer
{
    public class clsPlacementDashboard
    {
        DataAccessLayerHelper.clsPlacementDashboardData DBLayer;
        private int _TotalResumesFinalized;
        private int _TotalMovetoPlacementWing;
        private int _TotalJobsPosted;
        private int _TotalNewFAQsAdded;
        private int _TotalJobsApplied;
        private int _TotalResumesSubmitted;
        private int _PendingSeviceRequests;
        private int _PendingEscalations;
        private int _PendingDataSheets;
        private int _AssignedProfileOwner;
        private int _PendingHRMocks;
        private int _PendingRequestFAQs;
        private int _PendingReviseFAQs;
        private int _PendingInterviewSupport;
        private int _TotalProfileOwnerResumes;

        private int _ParticipantId;
        private int _TotalInterviewRound1;
        private int _TotalInterviewRound2;
        private int _TotalInterviewRound3;
        private int _TotalOffersReleased;
        private int _TotalOffersAccepted;
        private string _SpecialNotes;



        private int _TotalJobsAppliedStatus;
        private int _TotalInterviewRound1All;
        private int _TotalInterviewRound2All;
        private int _TotalInterviewRound3All;
        private int _TotalOffersReleasedAll;
        private int _TotalOffersAcceptedAll;
        private string _SpecialNotesAll;
        private int _TotalJobsAppliedStatusAll;
        private int _TotalJobsAppliedAll;
        private int _TotalJobsPostedAll;





        private  int _ThoughJobPortal;
        private int _Reference;
        private int _CoepdPortal;
        private int _CoepdPlacementWing;








        public clsPlacementDashboard()
        {
            DBLayer = new DataAccessLayerHelper.clsPlacementDashboardData();
        }

        public int TotalResumesFinalized
        {
            get
            {
                return _TotalResumesFinalized;
            }

            set
            {
                _TotalResumesFinalized = value;
            }
        }

        public int TotalMovetoPlacementWing
        {
            get
            {
                return _TotalMovetoPlacementWing;
            }

            set
            {
                _TotalMovetoPlacementWing = value;
            }
        }

        public int TotalJobsPosted
        {
            get
            {
                return _TotalJobsPosted;
            }

            set
            {
                _TotalJobsPosted = value;
            }
        }

        public int TotalNewFAQsAdded
        {
            get
            {
                return _TotalNewFAQsAdded;
            }

            set
            {
                _TotalNewFAQsAdded = value;
            }
        }

        public int TotalJobsApplied
        {
            get
            {
                return _TotalJobsApplied;
            }

            set
            {
                _TotalJobsApplied = value;
            }
        }

        public int TotalResumesSubmitted
        {
            get
            {
                return _TotalResumesSubmitted;
            }

            set
            {
                _TotalResumesSubmitted = value;
            }
        }

        public int PendingSeviceRequests
        {
            get
            {
                return _PendingSeviceRequests;
            }

            set
            {
                _PendingSeviceRequests = value;
            }
        }

        public int PendingEscalations
        {
            get
            {
                return _PendingEscalations;
            }

            set
            {
                _PendingEscalations = value;
            }
        }

        public int PendingDataSheets
        {
            get
            {
                return _PendingDataSheets;
            }

            set
            {
                _PendingDataSheets = value;
            }
        }

        public int AssignedProfileOwner
        {
            get
            {
                return _AssignedProfileOwner;
            }

            set
            {
                _AssignedProfileOwner = value;
            }
        }

        public int PendingHRMocks
        {
            get
            {
                return _PendingHRMocks;
            }

            set
            {
                _PendingHRMocks = value;
            }
        }

        public int PendingRequestFAQs
        {
            get
            {
                return _PendingRequestFAQs;
            }

            set
            {
                _PendingRequestFAQs = value;
            }
        }

        public int PendingReviseFAQs
        {
            get
            {
                return _PendingReviseFAQs;
            }

            set
            {
                _PendingReviseFAQs = value;
            }
        }

        public int PendingInterviewSupport
        {
            get
            {
                return _PendingInterviewSupport;
            }

            set
            {
                _PendingInterviewSupport = value;
            }
        }

        public int TotalProfileOwnerResumes
        {
            get
            {
                return _TotalProfileOwnerResumes;
            }

            set
            {
                _TotalProfileOwnerResumes = value;
            }
        }

        public int ParticipantId
        {
            get
            {
                return _ParticipantId;
            }

            set
            {
                _ParticipantId = value;
            }
        }

        public int TotalInterviewRound1
        {
            get
            {
                return _TotalInterviewRound1;
            }

            set
            {
                _TotalInterviewRound1 = value;
            }
        }

        public int TotalInterviewRound2
        {
            get
            {
                return _TotalInterviewRound2;
            }

            set
            {
                _TotalInterviewRound2 = value;
            }
        }

        public int TotalInterviewRound3
        {
            get
            {
                return _TotalInterviewRound3;
            }

            set
            {
                _TotalInterviewRound3 = value;
            }
        }

        public int TotalOffersReleased
        {
            get
            {
                return _TotalOffersReleased;
            }

            set
            {
                _TotalOffersReleased = value;
            }
        }

        public int TotalOffersAccepted
        {
            get
            {
                return _TotalOffersAccepted;
            }

            set
            {
                _TotalOffersAccepted = value;
            }
        }

        public string SpecialNotes
        {
            get
            {
                return _SpecialNotes;
            }

            set
            {
                _SpecialNotes = value;
            }
        }

        public int TotalJobsAppliedStatus
        {
            get
            {
                return _TotalJobsAppliedStatus;
            }

            set
            {
                _TotalJobsAppliedStatus = value;
            }
        }

        public int TotalInterviewRound1All { get => _TotalInterviewRound1All; set => _TotalInterviewRound1All = value; }
        public int TotalInterviewRound2All { get => _TotalInterviewRound2All; set => _TotalInterviewRound2All = value; }
        public int TotalInterviewRound3All { get => _TotalInterviewRound3All; set => _TotalInterviewRound3All = value; }
        public int TotalOffersReleasedAll { get => _TotalOffersReleasedAll; set => _TotalOffersReleasedAll = value; }
        public int TotalOffersAcceptedAll { get => _TotalOffersAcceptedAll; set => _TotalOffersAcceptedAll = value; }
        public string SpecialNotesAll { get => _SpecialNotesAll; set => _SpecialNotesAll = value; }
        public int TotalJobsAppliedStatusAll { get => _TotalJobsAppliedStatusAll; set => _TotalJobsAppliedStatusAll = value; }
        public int TotalJobsAppliedAll { get => _TotalJobsAppliedAll; set => _TotalJobsAppliedAll = value; }
        public int TotalJobsPostedAll { get => _TotalJobsPostedAll; set => _TotalJobsPostedAll = value; }
        public int ThoughJobPortal { get => _ThoughJobPortal; set => _ThoughJobPortal = value; }
        public int Reference { get => _Reference; set => _Reference = value; }
        public int CoepdPortal { get => _CoepdPortal; set => _CoepdPortal = value; }
        public int CoepdPlacementWing { get => _CoepdPlacementWing; set => _CoepdPlacementWing = value; }

        public clsPlacementDashboard PlacementDashboardCount(clsPlacementDashboard obj)
        {
            return DBLayer.PlacementDashboardCount(obj);
        }
       

        public clsPlacementDashboard PlacementDashboardAdminCount(clsPlacementDashboard obj)
        {
            return DBLayer.PlacementDashboardAdminCount(obj);
        }
        public clsPlacementDashboard PlacementDashboardAdminCountAll(clsPlacementDashboard obj)
        {
            return DBLayer.PlacementDashboardAdminCountAll(obj);
        }
        public clsPlacementDashboard PlacementDashboardAppliedThrough(clsPlacementDashboard obj)
        {
            return DBLayer.PlacementDashboardAppliedThrough(obj);
        }
    }
}

