using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{

    public class ClsChangePassword
    {

        DataAccessLayerHelper.ClsChangePasswordData DBLayer;

        private int? _ResetId;
        private int _SNo;
        private string _keywords;
        private int _EmployeeId;
        private string _Employee;
        private string _OldPassword;
        private string _NewPassword;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;
        private int _ModifiedBy;
        private int _UserId;
        private string _Pwd;
        private string _FullName;
        private string _Description;
        private string _ConfirmPassword;



        public int SNo { get => _SNo; set => _SNo = value; }
        public string Keywords { get => _keywords; set => _keywords = value; }
        public int EmployeeId { get => _EmployeeId; set => _EmployeeId = value; }
        public string Employee { get => _Employee; set => _Employee = value; }
        public string OldPassword { get => _OldPassword; set => _OldPassword = value; }
        public string NewPassword { get => _NewPassword; set => _NewPassword = value; }
        public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
        public int? CreatedBy { get => _CreatedBy; set => _CreatedBy = value; }
        public DateTime ModifiedOn { get => _ModifiedOn; set => _ModifiedOn = value; }
        public int ModifiedBy { get => _ModifiedBy; set => _ModifiedBy = value; }
        public int? ResetId { get => _ResetId; set => _ResetId = value; }
        public int UserId { get => _UserId; set => _UserId = value; }
        public string Pwd { get => _Pwd; set => _Pwd = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public string Description { get => _Description; set => _Description = value; }
        public string ConfirmPassword { get => _ConfirmPassword; set => _ConfirmPassword = value; }

        public ClsChangePassword()
        {
            DBLayer = new DataAccessLayerHelper.ClsChangePasswordData();
        }
        public void AddUpdate(ClsChangePassword obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public List<ClsChangePassword> LoadAllChangePwdEmployee(ClsChangePassword obj)
        {
            return DBLayer.LoadAllChangePwdEmployee(obj);
        }
        public ClsChangePassword Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<ClsChangePassword> LoadAll(ClsChangePassword obj)
        {
            return DBLayer.LoadAll(obj);
        }
    }
}
