using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class clsEmployee
    {
        DataAccessLayerHelper.clsEmployeeData DBLayer;

        private int _SNo;
        private string _keywords;
        private int? _EmployeeId;
        private string _Employee;
        private string _Code;
        private int _BranchId;
        private string _Branch;
        private int _DesignationId;
        private string _Designation;
        private string _Email;
        private string _OfficeEmail;
        private string _Mobile;
        private string _CUGMobile;
        private string _Phone;
        private string _Summary;
        private string _Remarks;
        private decimal _Salary;
        private string _Address;
        private string _City;
        private string _State;
        private string _Zip;
        private DateTime _JoinDate;
        private string _EmergencyContact;
        private string _EmergencyPhone;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private DateTime? _FromDate;
        private DateTime? _ToDate;
        private bool? _IsLeadPermit;
        private int _DepartmentId;
        private string _Department;
        private string _Roles;
        private bool? _NurturePermit;
        private string _ResumePath;
        private string _keywords1;
        private string _keywords2;
        private string _keywords3;
        private string _keywords4;
        private string _keywords5;
        private int _LocationId;
        private string _Location;
        private string _keywords6;
        private string _keywords7;
        private string _keywords8;
        private string _keywords9;
        private string _keywords10;
        private string _keywords11;
        private string _keywords12;
        private string _keywords13;
        private string _keywords14;
        private string _keywords15;
        private string _keywords16;
        private string _keywords17;
        private string _keywords18;
        private string _keywords19;
        private string _keywords20;
        private string _keywords21;
        private string _keywords22;
        private string _keywords23;
        private string _keywords24;
        private string _keywords25;
        private string _keywords26;
        private string _keywords27;
        private string _keywords28;
        private string _keywords29;
        private string _keywords30;
        private string _PhonePayNumber;
        private string _GooglePayNumber;
        private string _PaytmNumber;
        private string _AccountHolderName;
        private string _BankAccountNumber;
        private string _IFSCCode;
        private string _BankName;
        private string _BranchName;
        private string _PassbookFilePath;
        private string _PancardFilePath;
        private string _AadharFrontFilePath;
        private string _AadharBackFilePath;
        private string _CertificateId;
        private string _AwardName;
        private DateTime _DateOfIssued;
        private DateTime _IssuedFortheMonth;

        private bool _IsTrainer;
        private bool _IsProcess;
        private bool _IsMentor;
        private bool _IsDiscounter;
        private bool? _IsReportingManager;
        private bool _IsAssociate;

        private string _AlternateMobileNo;
        private string _SkypeId;
        private bool? _IsVerticalHead;
        public int SNo
        {
            get { return _SNo; }
            set { _SNo = value; }
        }
        public string keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        public int? EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        public string Employee
        {
            get { return _Employee; }
            set { _Employee = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public int BranchId
        {
            get { return _BranchId; }
            set { _BranchId = value; }
        }
        public string Branch
        {
            get { return _Branch; }
            set { _Branch = value; }
        }
        public int DesignationId
        {
            get { return _DesignationId; }
            set { _DesignationId = value; }
        }
        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string OfficeEmail
        {
            get { return _OfficeEmail; }
            set { _OfficeEmail = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public string CUGMobile
        {
            get { return _CUGMobile; }
            set { _CUGMobile = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Summary
        {
            get { return _Summary; }
            set { _Summary = value; }
        }
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        public decimal Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }
        public string EmergencyContact
        {
            get { return _EmergencyContact; }
            set { _EmergencyContact = value; }
        }
        public string EmergencyPhone
        {
            get { return _EmergencyPhone; }
            set { _EmergencyPhone = value; }
        }
        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }
        public DateTime CreatedOn
        {
            get { return _CreatedOn; }
            set { _CreatedOn = value; }
        }
        public int? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public DateTime ModifiedOn
        {
            get { return _ModifiedOn; }
            set { _ModifiedOn = value; }
        }
        public DateTime? FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }
        public DateTime? ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }
        public bool? IsLeadPermit
        {
            get { return _IsLeadPermit; }
            set { _IsLeadPermit = value; }
        }
        public bool? NurturePermit
        {
            get { return _NurturePermit; }
            set { _NurturePermit = value; }
        }

        public int DepartmentId
        {
            get { return _DepartmentId; }
            set { _DepartmentId = value; }
        }
        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }
        public string Roles
        {
            get { return _Roles; }
            set { _Roles = value; }
        }

        public string ResumePath
        {
            get { return _ResumePath; }
            set { _ResumePath = value; }
        }

        public string Keywords1
        {
            get
            {
                return _keywords1;
            }

            set
            {
                _keywords1 = value;
            }
        }

        public string Keywords2
        {
            get
            {
                return _keywords2;
            }

            set
            {
                _keywords2 = value;
            }
        }

        public string Keywords3
        {
            get
            {
                return _keywords3;
            }

            set
            {
                _keywords3 = value;
            }
        }

        public string Keywords4
        {
            get
            {
                return _keywords4;
            }

            set
            {
                _keywords4 = value;
            }
        }

        public string Keywords5
        {
            get
            {
                return _keywords5;
            }

            set
            {
                _keywords5 = value;
            }
        }

        public int LocationId
        {
            get
            {
                return _LocationId;
            }

            set
            {
                _LocationId = value;
            }
        }

        public string Location
        {
            get
            {
                return _Location;
            }

            set
            {
                _Location = value;
            }
        }

        public string Keywords6
        {
            get
            {
                return _keywords6;
            }

            set
            {
                _keywords6 = value;
            }
        }

        public string Keywords7
        {
            get
            {
                return _keywords7;
            }

            set
            {
                _keywords7 = value;
            }
        }

        public string Keywords8
        {
            get
            {
                return _keywords8;
            }

            set
            {
                _keywords8 = value;
            }
        }

        public string Keywords9
        {
            get
            {
                return _keywords9;
            }

            set
            {
                _keywords9 = value;
            }
        }

        public string Keywords10
        {
            get
            {
                return _keywords10;
            }

            set
            {
                _keywords10 = value;
            }
        }

        public string Keywords11
        {
            get
            {
                return _keywords11;
            }

            set
            {
                _keywords11 = value;
            }
        }

        public string Keywords12
        {
            get
            {
                return _keywords12;
            }

            set
            {
                _keywords12 = value;
            }
        }

        public string Keywords13
        {
            get
            {
                return _keywords13;
            }

            set
            {
                _keywords13 = value;
            }
        }

        public string Keywords14
        {
            get
            {
                return _keywords14;
            }

            set
            {
                _keywords14 = value;
            }
        }

        public string Keywords15
        {
            get
            {
                return _keywords15;
            }

            set
            {
                _keywords15 = value;
            }
        }

        public string Keywords16
        {
            get
            {
                return _keywords16;
            }

            set
            {
                _keywords16 = value;
            }
        }

        public string Keywords17
        {
            get
            {
                return _keywords17;
            }

            set
            {
                _keywords17 = value;
            }
        }

        public string Keywords18
        {
            get
            {
                return _keywords18;
            }

            set
            {
                _keywords18 = value;
            }
        }

        public string Keywords19
        {
            get
            {
                return _keywords19;
            }

            set
            {
                _keywords19 = value;
            }
        }

        public string Keywords20
        {
            get
            {
                return _keywords20;
            }

            set
            {
                _keywords20 = value;
            }
        }

        public string Keywords21
        {
            get
            {
                return _keywords21;
            }

            set
            {
                _keywords21 = value;
            }
        }

        public string Keywords22
        {
            get
            {
                return _keywords22;
            }

            set
            {
                _keywords22 = value;
            }
        }

        public string Keywords23
        {
            get
            {
                return _keywords23;
            }

            set
            {
                _keywords23 = value;
            }
        }

        public string Keywords24
        {
            get
            {
                return _keywords24;
            }

            set
            {
                _keywords24 = value;
            }
        }

        public string Keywords25
        {
            get
            {
                return _keywords25;
            }

            set
            {
                _keywords25 = value;
            }
        }

        public string Keywords26
        {
            get
            {
                return _keywords26;
            }

            set
            {
                _keywords26 = value;
            }
        }

        public string Keywords27
        {
            get
            {
                return _keywords27;
            }

            set
            {
                _keywords27 = value;
            }
        }

        public string Keywords28
        {
            get
            {
                return _keywords28;
            }

            set
            {
                _keywords28 = value;
            }
        }

        public string Keywords29
        {
            get
            {
                return _keywords29;
            }

            set
            {
                _keywords29 = value;
            }
        }

        public string Keywords30
        {
            get
            {
                return _keywords30;
            }

            set
            {
                _keywords30 = value;
            }
        }

        public string PhonePayNumber
        {
            get
            {
                return _PhonePayNumber;
            }

            set
            {
                _PhonePayNumber = value;
            }
        }

        public string GooglePayNumber
        {
            get
            {
                return _GooglePayNumber;
            }

            set
            {
                _GooglePayNumber = value;
            }
        }

        public string PaytmNumber
        {
            get
            {
                return _PaytmNumber;
            }

            set
            {
                _PaytmNumber = value;
            }
        }

        public string AccountHolderName
        {
            get
            {
                return _AccountHolderName;
            }

            set
            {
                _AccountHolderName = value;
            }
        }

        public string BankAccountNumber
        {
            get
            {
                return _BankAccountNumber;
            }

            set
            {
                _BankAccountNumber = value;
            }
        }

        public string IFSCCode
        {
            get
            {
                return _IFSCCode;
            }

            set
            {
                _IFSCCode = value;
            }
        }

        public string BankName
        {
            get
            {
                return _BankName;
            }

            set
            {
                _BankName = value;
            }
        }

        public string BranchName
        {
            get
            {
                return _BranchName;
            }

            set
            {
                _BranchName = value;
            }
        }

        public string PassbookFilePath
        {
            get
            {
                return _PassbookFilePath;
            }

            set
            {
                _PassbookFilePath = value;
            }
        }

        public string PancardFilePath
        {
            get
            {
                return _PancardFilePath;
            }

            set
            {
                _PancardFilePath = value;
            }
        }

        public string AadharFrontFilePath
        {
            get
            {
                return _AadharFrontFilePath;
            }

            set
            {
                _AadharFrontFilePath = value;
            }
        }

        public string AadharBackFilePath
        {
            get
            {
                return _AadharBackFilePath;
            }

            set
            {
                _AadharBackFilePath = value;
            }
        }

        public string CertificateId
        {
            get
            {
                return _CertificateId;
            }

            set
            {
                _CertificateId = value;
            }
        }

        public string AwardName
        {
            get
            {
                return _AwardName;
            }

            set
            {
                _AwardName = value;
            }
        }

        public DateTime DateOfIssued
        {
            get
            {
                return _DateOfIssued;
            }

            set
            {
                _DateOfIssued = value;
            }
        }

        public DateTime IssuedFortheMonth
        {
            get
            {
                return _IssuedFortheMonth;
            }

            set
            {
                _IssuedFortheMonth = value;
            }
        }

        public bool IsTrainer { get => _IsTrainer; set => _IsTrainer = value; }
        public bool IsProcess { get => _IsProcess; set => _IsProcess = value; }
        public bool IsMentor { get => _IsMentor; set => _IsMentor = value; }
        public bool IsDiscounter { get => _IsDiscounter; set => _IsDiscounter = value; }
        public bool? IsReportingManager { get => _IsReportingManager; set => _IsReportingManager = value; }
        public bool IsAssociate { get => _IsAssociate; set => _IsAssociate = value; }
        public string AlternateMobileNo { get => _AlternateMobileNo; set => _AlternateMobileNo = value; }
        public string SkypeId { get => _SkypeId; set => _SkypeId = value; }
        public bool? IsVerticalHead { get => _IsVerticalHead; set => _IsVerticalHead = value; }

        public clsEmployee()
        {
            DBLayer = new DataAccessLayerHelper.clsEmployeeData();
        }
        public void AddUpdate(clsEmployee obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsEmployee Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsEmployee> LoadAll(clsEmployee obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public List<clsEmployee> LoadForAll(clsEmployee obj)
        {
            return DBLayer.LoadForAll(obj);
        }
        public List<clsEmployee> LoadAllMultiple(clsEmployee obj)
        {
            return DBLayer.LoadAllMultiple(obj);
        }
        public List<clsEmployee> LoadAllReports(clsEmployee obj)
        {
            return DBLayer.LoadAllReports(obj);
        }
        public List<clsEmployee> LoadAllEmployee(clsEmployee obj)
        {
            return DBLayer.LoadAllEmployee(obj);
        }
        public List<clsEmployee> LoadAll_InActive(clsEmployee obj)
        {
            return DBLayer.LoadAll_InActive(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }

        public List<clsEmployee> LoadAll_VerifyCertificate(clsEmployee obj)
        {
            return DBLayer.LoadAll_VerifyCertificate(obj);
        }

        public clsEmployee Loadfew(int Id)
        {
            return DBLayer.Loadfew(Id);
        }

        public List<clsEmployee> DisplayEmployee(clsEmployee obj)
        {
            return DBLayer.DisplayEmployee(obj);
        }
    }
}