using System;
namespace BusinessLayer
{
    //This BusinessLayer is used to Wrapping the Data into  PresentationLayer to DataAccessLayer using get and set Properties.
    public class clsErrorLogs
    {
        DataAccessLayerHelper.clsErrorLogsData DBLayer;

        // Define variables as required for the class

        private int _ErrorId;
        private string _smallDescription1;
        private string _smallDescription2;
        private string _smallDescription3;
        private string _smallDescription4;
        private string _smallDescription5;
        private string _mediumDescription1;
        private string _mediumDescription2;
        private string _mediumDescription3;
        private string _mediumDescription4;
        private string _mediumDescription5;
        private string _largeDescription1;
        private string _largeDescription2;
        private string _largeDescription3;
        private string _largeDescription4;
        private string _largeDescription5;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime? _ModifiedOn;
        private int _ModifiedBy;


        //Generate Getters and setters as required	


        public int ErrorId
        {
            get
            {
                return _ErrorId;
            }

            set
            {
                _ErrorId = value;
            }
        }

        public string smallDescription1
        {
            get
            {
                return _smallDescription1;
            }
            set
            {
                _smallDescription1 = value;
            }
        }
        public string smallDescription2
        {
            get
            {
                return _smallDescription2;
            }
            set
            {
                _smallDescription2 = value;
            }
        }

        public string smallDescription3
        {
            get
            {
                return _smallDescription3;
            }
            set
            {
                _smallDescription3 = value;
            }
        }

        public string smallDescription4
        {
            get
            {
                return _smallDescription4;
            }
            set
            {
                _smallDescription4 = value;
            }
        }

        public string smallDescription5
        {
            get
            {
                return _smallDescription5;
            }
            set
            {
                _smallDescription5 = value;
            }
        }

        public string mediumDescription1
        {
            get
            {
                return _mediumDescription1;
            }
            set
            {
                _mediumDescription1 = value;
            }
        }

        public string mediumDescription2
        {
            get
            {
                return _mediumDescription2;
            }
            set
            {
                _mediumDescription2 = value;
            }
        }

        public string mediumDescription3
        {
            get
            {
                return _mediumDescription3;
            }
            set
            {
                _mediumDescription3 = value;
            }
        }

        public string mediumDescription4
        {
            get
            {
                return _mediumDescription4;
            }
            set
            {
                _mediumDescription4 = value;
            }
        }

        public string mediumDescription5
        {
            get
            {
                return _mediumDescription5;
            }
            set
            {
                _mediumDescription5 = value;
            }
        }

        public string largeDescription1
        {
            get
            {
                return _largeDescription1;
            }
            set
            {
                _largeDescription1 = value;
            }
        }

        public string largeDescription2
        {
            get
            {
                return _largeDescription2;
            }
            set
            {
                _largeDescription2 = value;
            }
        }

        public string largeDescription3
        {
            get
            {
                return _largeDescription3;
            }
            set
            {
                _largeDescription3 = value;
            }
        }

        public string largeDescription4
        {
            get
            {
                return _largeDescription4;
            }
            set
            {
                _largeDescription4 = value;
            }
        }

        public string largeDescription5
        {
            get
            {
                return _largeDescription5;
            }
            set
            {
                _largeDescription5 = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return _IsActive;
            }

            set
            {
                _IsActive = value;
            }
        }

        public bool IsDeleted
        {
            get
            {
                return _IsDeleted;
            }

            set
            {
                _IsDeleted = value;
            }
        }

        public DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }

            set
            {
                _CreatedOn = value;
            }
        }

        public int? CreatedBy
        {
            get
            {
                return _CreatedBy;
            }

            set
            {
                _CreatedBy = value;
            }
        }

        public DateTime? ModifiedOn
        {
            get
            {
                return _ModifiedOn;
            }

            set
            {
                _ModifiedOn = value;
            }
        }

        public int ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }

            set
            {
                _ModifiedBy = value;
            }
        }

        // Change the logic as appropriate

        public clsErrorLogs()
        {
            DBLayer = new DataAccessLayerHelper.clsErrorLogsData();
        }
        public void AddUpdate(clsErrorLogs obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsErrorLogs Load(int id)
        {
            return DBLayer.Load(id);
        }

    }
}

