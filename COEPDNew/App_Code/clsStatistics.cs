using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsStatistics
    {
        DataAccessLayerHelper.clsStatisticsData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _StatisticsId;
        private string _BatchesCompleted;
        private string _StudentsTrained;
        private string _Placements;
        private string _Corporates;
        private string _BSchools;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

        public int SNo
        {
            get
            {
                return _SNo;
            }

            set
            {
                _SNo = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }

        public int? StatisticsId
        {
            get
            {
                return _StatisticsId;
            }

            set
            {
                _StatisticsId = value;
            }
        }

        public string BatchesCompleted
        {
            get
            {
                return _BatchesCompleted;
            }

            set
            {
                _BatchesCompleted = value;
            }
        }

        public string StudentsTrained
        {
            get
            {
                return _StudentsTrained;
            }

            set
            {
                _StudentsTrained = value;
            }
        }

        public string Placements
        {
            get
            {
                return _Placements;
            }

            set
            {
                _Placements = value;
            }
        }

        public string Corporates
        {
            get
            {
                return _Corporates;
            }

            set
            {
                _Corporates = value;
            }
        }

        public string BSchools
        {
            get
            {
                return _BSchools;
            }

            set
            {
                _BSchools = value;
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

        public DateTime ModifiedOn
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

        public clsStatistics()
        {
            DBLayer = new DataAccessLayerHelper.clsStatisticsData();
        }
        public void AddUpdate(clsStatistics obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsStatistics Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsStatistics> LoadAll(clsStatistics obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}

