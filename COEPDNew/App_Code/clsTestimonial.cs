using System;
using System.Collections.Generic;
namespace BusinessLayer
{
    public class clsTestimonial
    {
        DataAccessLayerHelper.clsTestimonialData DBLayer;
        private int _SNo;
        private string _keywords;
        private int? _TestimonialId;
        private string _Testimonial;
        private string _Description;
        private bool? _IsFeatured;
        private bool _IsActive;
        private bool _IsDeleted;
        private DateTime _CreatedOn;
        private int? _CreatedBy;
        private DateTime _ModifiedOn;

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
        public int? TestimonialId
        {
            get { return _TestimonialId; }
            set { _TestimonialId = value; }
        }
        public string Testimonial
        {
            get { return _Testimonial; }
            set { _Testimonial = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public bool? IsFeatured
        {
            get { return _IsFeatured; }
            set { _IsFeatured = value; }
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
        public clsTestimonial()
        {
            DBLayer = new DataAccessLayerHelper.clsTestimonialData();
        }
        public void AddUpdate(clsTestimonial obj)
        {
            DBLayer.AddUpdate(obj);
        }
        public clsTestimonial Load(int Id)
        {
            return DBLayer.Load(Id);
        }
        public List<clsTestimonial> LoadAll(clsTestimonial obj)
        {
            return DBLayer.LoadAll(obj);
        }
        public void Remove(int Id)
        {
            DBLayer.Remove(Id);
        }
    }
}