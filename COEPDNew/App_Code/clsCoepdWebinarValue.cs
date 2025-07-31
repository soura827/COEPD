using System;
using System.Collections.Generic;

public class clsCoepdWebinarValue
{
    DataAccessLayerHelper.clsCoepdWebinarValueData DBLayer;

    private int _LeadId;
    private int _Offer;
    private string _Title;
    private string _Name;
    private string _EmailId;
    private string _MobileNo;
    private string _SpecificEnquiry;
    private int _IsActive;
    private int _IsDeleted;
    private string _Location;
    private DateTime? _Date;
    private DateTime? _FromDate;
    private DateTime? _ToDate;
    private int _SNO;
    private DateTime _CreatedOn;
    private String _FullName;
    private DateTime? _WebinarDate;
    public int LeadId { get => _LeadId; set => _LeadId = value; }
    public int Offer { get => _Offer; set => _Offer = value; }
    public string Title { get => _Title; set => _Title = value; }
    public string Name { get => _Name; set => _Name = value; }
    public string EmailId { get => _EmailId; set => _EmailId = value; }
    public string MobileNo { get => _MobileNo; set => _MobileNo = value; }
    public string SpecificEnquiry { get => _SpecificEnquiry; set => _SpecificEnquiry = value; }
    public int IsActive { get => _IsActive; set => _IsActive = value; }
    public int IsDeleted { get => _IsDeleted; set => _IsDeleted = value; }
    public string Location { get => _Location; set => _Location = value; }
    public DateTime? Date { get => _Date; set => _Date = value; }
    public DateTime? FromDate { get => _FromDate; set => _FromDate = value; }
    public DateTime? ToDate { get => _ToDate; set => _ToDate = value; }
    public int SNO { get => _SNO; set => _SNO = value; }
    public DateTime CreatedOn { get => _CreatedOn; set => _CreatedOn = value; }
    public string FullName { get => _FullName; set => _FullName = value; }
    public DateTime? WebinarDate { get => _WebinarDate; set => _WebinarDate = value; }

    public clsCoepdWebinarValue()
    {
        DBLayer = new DataAccessLayerHelper.clsCoepdWebinarValueData();
    }
    public void AddUpdate(clsCoepdWebinarValue obj)
    {
        DBLayer.AddUpdate(obj);
    }
    public clsCoepdWebinarValue Load(int Id)
    {
        return DBLayer.Load(Id);
    }
    public List<clsCoepdWebinarValue> LoadAll(clsCoepdWebinarValue obj)
    {
        return DBLayer.LoadAll(obj);
    }
    public int LoadCoepdValueMobileValidation(clsCoepdWebinarValue obj)
    {
        return DBLayer.LoadCoepdValueMobileValidation(obj);
    }
    public int LoadCoepdValueEmailValidation(clsCoepdWebinarValue obj)
    {
        return DBLayer.LoadCoepdValueEmailValidation(obj);
    }



}

