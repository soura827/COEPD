using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class Admin_ActivityTaskCreation : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    protected void Page_PreInit(object Sender, EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindActivityCategory();
            //BindActivitySubCategory();
            //BindActivity();
            // BindEmployee();
            //BindParticipant();
            //BindLocation();
            //Binddata();
            //gv.Visible = false;
        }
        //btnstartActivity.Visible = false;
        //txtActivityDescription.Visible = false;
        //btnEndActivity.Visible = false;
    }
    protected void BindActivityCategory()
    {
        clsActivityCategory obj = new clsActivityCategory();
        ddlActivityCategory.DataSource = obj.LoadAll(obj);
        ddlActivityCategory.DataValueField = "ActivityCategoryId";
        ddlActivityCategory.DataTextField = "ActivityCategory";
        ddlActivityCategory.DataBind();
        ddlActivityCategory.Items.Insert(0, new ListItem("Select Activity Category", ""));
    }
    protected void BindActivitySubCategory()
    {
        clsActivitySubCategory obj = new clsActivitySubCategory();
        obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
        ddlActivitySubCategory.DataSource = obj.LoadAll(obj);
        ddlActivitySubCategory.DataValueField = "ActivitySubCategoryId";
        ddlActivitySubCategory.DataTextField = "ActivitySubCategory";
        ddlActivitySubCategory.DataBind();
        ddlActivitySubCategory.Items.Insert(0, new ListItem("Select Activity SubCategory", ""));
    }
    protected void BindActivity()
    {
        clsActivity obj = new clsActivity();
        obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
        if (ddlActivitySubCategory.SelectedValue != "")
            obj.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
        ddlActivity.DataSource = obj.LoadAll(obj);
        ddlActivity.DataValueField = "ActivityId";
        ddlActivity.DataTextField = "Activity";
        ddlActivity.DataBind();
        ddlActivity.Items.Insert(0, new ListItem("Select Activtiy", ""));
    }
    protected void BindEmployee()
    {
        //clsEmployee obj = new clsEmployee();
        //obj.keywords =Convert.ToString(txtEmployee.Text);
        //ddlEmployee.DataSource = obj.LoadAll(obj);
        //ddlEmployee.DataValueField = "EmployeeId";
        //ddlEmployee.DataTextField = "Employee";
        //ddlEmployee.DataBind();
        //ddlEmployee.Items.Insert(0, new ListItem("Selcet Employee", ""));
        //string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //SqlConnection con = new SqlConnection(Constr);
        //string sqlquery = "Select * from [dbo].[tblEmployee]";
        //SqlCommand cmd = new SqlCommand(sqlquery, con);
        //con.Open();
        //SqlDataReader sdr = cmd.ExecuteReader();
        //if (sdr.HasRows)
        //{
        //    listEmaployee.DataSource = sdr;
        //    listEmaployee.DataTextField = "Employee";
        //    listEmaployee.DataValueField = "EmployeeId";
        //    listEmaployee.DataBind();

        //}
        //con.Close();

        //DataTable dt = new DataTable();
        //string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //using (SqlConnection con = new SqlConnection(Constr))
        //{
        //    using (SqlCommand cmd = con.CreateCommand())
        //    {
        //        cmd.CommandText = "SELECT Employee FROM tblEmployee";
        //        con.Open();

        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        sda.SelectCommand = cmd;
        //        sda.Fill(dt);

        //        // BIND THE SELECT DROP-DOWN LIST WITH A DATABASE TABLE.
        //        Books.DataSource = dt; Books.DataValueField = "Employee";
        //        Books.DataBind();

        //        // FOR MULTIPLE SELECTION. SET THE VALUE AS FALSE, AND SEE WHAT HAPPENS.
        //        Books.Multiple = true;
        //string str = null;
        //string[] strArr = null;
        //str = txtEmployee.Text;
        //string[] authorsList = authors.Split(", ");
        ////Char[] spiltchar = { ' ' };
        ////strArr = str.Split(spiltchar);
        //for (int count = 0; count <= strArr.Length - 1; count++)
        //{

        //    //if(count==0)
        //    //{
        //    // obj.Keywords1= strArr
        //    //}
        //}
        // obj.keywords =Convert.ToString(txtEmployee.Text);
        clsEmployee obj = new clsEmployee();
        string authors = txtEmployee.Text;
        string[] authorsList = authors.Split(',');
        //  foreach (string author in authorsList)
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        string value6 = null;
        string value7 = null;
        string value8 = null;
        string value9 = null;
        string value10 = null;
        string value11 = null;
        string value12 = null;
        string value13 = null;
        string value14 = null;
        string value15 = null;
        string value16 = null;
        string value17 = null;
        string value18 = null;
        string value19 = null;
        string value20 = null;
        string value21 = null;
        string value22 = null;
        string value23 = null;
        string value24 = null;
        string value25 = null;
        string value26 = null;
        string value27 = null;
        string value28 = null;
        string value29 = null;
        string value30 = null;

        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            else if (count == 1)
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            else if (count == 2)
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            else if (count == 3)
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            else if (count == 4)
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            else if (count == 5)
                value6 = Convert.ToString(authorsList.GetValue(5).ToString());
            else if (count == 6)
                value7 = Convert.ToString(authorsList.GetValue(6).ToString());
            else if (count == 7)
                value8 = Convert.ToString(authorsList.GetValue(7).ToString());
            else if (count == 8)
                value9 = Convert.ToString(authorsList.GetValue(8).ToString());
            else if (count == 9)
                value10 = Convert.ToString(authorsList.GetValue(9).ToString());
            else if (count == 10)
                value11 = Convert.ToString(authorsList.GetValue(10).ToString());
            else if (count == 11)
                value12 = Convert.ToString(authorsList.GetValue(11).ToString());
            else if (count == 12)
                value13 = Convert.ToString(authorsList.GetValue(12).ToString());
            else if (count == 13)
                value14 = Convert.ToString(authorsList.GetValue(13).ToString());
            else if (count == 14)
                value15 = Convert.ToString(authorsList.GetValue(14).ToString());
            else if (count == 15)
                value16 = Convert.ToString(authorsList.GetValue(15).ToString());
            else if (count == 16)
                value17 = Convert.ToString(authorsList.GetValue(16).ToString());
            else if (count == 17)
                value18 = Convert.ToString(authorsList.GetValue(17).ToString());
            else if (count == 18)
                value19 = Convert.ToString(authorsList.GetValue(18).ToString());
            else if (count == 19)
                value20 = Convert.ToString(authorsList.GetValue(19).ToString());
            else if (count == 20)
                value21 = Convert.ToString(authorsList.GetValue(20).ToString());
            else if (count == 21)
                value22 = Convert.ToString(authorsList.GetValue(21).ToString());
            else if (count == 22)
                value23 = Convert.ToString(authorsList.GetValue(22).ToString());
            else if (count == 23)
                value24 = Convert.ToString(authorsList.GetValue(23).ToString());
            else if (count == 24)
                value25 = Convert.ToString(authorsList.GetValue(24).ToString());
            else if (count == 25)
                value26 = Convert.ToString(authorsList.GetValue(25).ToString());
            else if (count == 26)
                value27 = Convert.ToString(authorsList.GetValue(26).ToString());
            else if (count == 27)
                value28 = Convert.ToString(authorsList.GetValue(27).ToString());
            else if (count == 28)
                value29 = Convert.ToString(authorsList.GetValue(28).ToString());
            else if (count == 29)
                value30 = Convert.ToString(authorsList.GetValue(29).ToString());

        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        obj.Keywords6 = value6;
        obj.Keywords7 = value7;
        obj.Keywords8 = value8;
        obj.Keywords9 = value9;
        obj.Keywords10 = value10;
        obj.Keywords11 = value11;
        obj.Keywords12 = value12;
        obj.Keywords13 = value13;
        obj.Keywords14 = value14;
        obj.Keywords15 = value15;
        obj.Keywords16 = value16;
        obj.Keywords17 = value17;
        obj.Keywords18 = value18;
        obj.Keywords19 = value19;
        obj.Keywords20 = value20;
        obj.Keywords21 = value21;
        obj.Keywords22 = value22;
        obj.Keywords23 = value23;
        obj.Keywords24 = value24;
        obj.Keywords25 = value25;
        obj.Keywords26 = value26;
        obj.Keywords27 = value27;
        obj.Keywords28 = value28;
        obj.Keywords29 = value29;
        obj.Keywords30 = value30;
        gvemployee.DataSource = obj.LoadAllMultiple(obj);
        gvemployee.DataBind();

    }
    protected void BindParticipant()

    {
        clsParticipant obj = new clsParticipant();
        string authors = txtParticipant.Text;
        string[] authorsList = authors.Split(',');
        //  foreach (string author in authorsList)
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        string value6 = null;
        string value7 = null;
        string value8 = null;
        string value9 = null;
        string value10 = null;
        string value11 = null;
        string value12 = null;
        string value13 = null;
        string value14 = null;
        string value15 = null;
        string value16 = null;
        string value17 = null;
        string value18 = null;
        string value19 = null;
        string value20 = null;
        string value21 = null;
        string value22 = null;
        string value23 = null;
        string value24 = null;
        string value25 = null;
        string value26 = null;
        string value27 = null;
        string value28 = null;
        string value29 = null;
        string value30 = null;

        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            else if (count == 1)
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            else if (count == 2)
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            else if (count == 3)
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            else if (count == 4)
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            else if (count == 5)
                value6 = Convert.ToString(authorsList.GetValue(5).ToString());
            else if (count == 6)
                value7 = Convert.ToString(authorsList.GetValue(6).ToString());
            else if (count == 7)
                value8 = Convert.ToString(authorsList.GetValue(7).ToString());
            else if (count == 8)
                value9 = Convert.ToString(authorsList.GetValue(8).ToString());
            else if (count == 9)
                value10 = Convert.ToString(authorsList.GetValue(9).ToString());
            else if (count == 10)
                value11 = Convert.ToString(authorsList.GetValue(10).ToString());
            else if (count == 11)
                value12 = Convert.ToString(authorsList.GetValue(11).ToString());
            else if (count == 12)
                value13 = Convert.ToString(authorsList.GetValue(12).ToString());
            else if (count == 13)
                value14 = Convert.ToString(authorsList.GetValue(13).ToString());
            else if (count == 14)
                value15 = Convert.ToString(authorsList.GetValue(14).ToString());
            else if (count == 15)
                value16 = Convert.ToString(authorsList.GetValue(15).ToString());
            else if (count == 16)
                value17 = Convert.ToString(authorsList.GetValue(16).ToString());
            else if (count == 17)
                value18 = Convert.ToString(authorsList.GetValue(17).ToString());
            else if (count == 18)
                value19 = Convert.ToString(authorsList.GetValue(18).ToString());
            else if (count == 19)
                value20 = Convert.ToString(authorsList.GetValue(19).ToString());
            else if (count == 20)
                value21 = Convert.ToString(authorsList.GetValue(20).ToString());
            else if (count == 21)
                value22 = Convert.ToString(authorsList.GetValue(21).ToString());
            else if (count == 22)
                value23 = Convert.ToString(authorsList.GetValue(22).ToString());
            else if (count == 23)
                value24 = Convert.ToString(authorsList.GetValue(23).ToString());
            else if (count == 24)
                value25 = Convert.ToString(authorsList.GetValue(24).ToString());
            else if (count == 25)
                value26 = Convert.ToString(authorsList.GetValue(25).ToString());
            else if (count == 26)
                value27 = Convert.ToString(authorsList.GetValue(26).ToString());
            else if (count == 27)
                value28 = Convert.ToString(authorsList.GetValue(27).ToString());
            else if (count == 28)
                value29 = Convert.ToString(authorsList.GetValue(28).ToString());
            else if (count == 29)
                value30 = Convert.ToString(authorsList.GetValue(29).ToString());

        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        obj.Keywords6 = value6;
        obj.Keywords7 = value7;
        obj.Keywords8 = value8;
        obj.Keywords9 = value9;
        obj.Keywords10 = value10;
        obj.Keywords11 = value11;
        obj.Keywords12 = value12;
        obj.Keywords13 = value13;
        obj.Keywords14 = value14;
        obj.Keywords15 = value15;
        obj.Keywords16 = value16;
        obj.Keywords17 = value17;
        obj.Keywords18 = value18;
        obj.Keywords19 = value19;
        obj.Keywords20 = value20;
        obj.Keywords21 = value21;
        obj.Keywords22 = value22;
        obj.Keywords23 = value23;
        obj.Keywords24 = value24;
        obj.Keywords25 = value25;
        obj.Keywords26 = value26;
        obj.Keywords27 = value27;
        obj.Keywords28 = value28;
        obj.Keywords29 = value29;
        obj.Keywords30 = value30;
        //obj.keywords =Convert.ToString(txtParticipant.Text);
        //ddlParticipant.DataSource = obj.LoadAll(obj);
        //ddlParticipant.DataValueField = "ParticipantId";
        //ddlParticipant.DataTextField = "Participant";
        //ddlParticipant.DataBind();
        //ddlParticipant.Items.Insert(0, new ListItem("Select Participant", ""));
        gvPartiicipant.DataSource = obj.LoadAllMultiple(obj);
        gvPartiicipant.DataBind();
    }
    protected void BindLead()
    {
        clsLead obj = new clsLead();
        string authors = txtLead.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        string value6 = null;
        string value7 = null;
        string value8 = null;
        string value9 = null;
        string value10 = null;
        string value11 = null;
        string value12 = null;
        string value13 = null;
        string value14 = null;
        string value15 = null;
        string value16 = null;
        string value17 = null;
        string value18 = null;
        string value19 = null;
        string value20 = null;
        string value21 = null;
        string value22 = null;
        string value23 = null;
        string value24 = null;
        string value25 = null;
        string value26 = null;
        string value27 = null;
        string value28 = null;
        string value29 = null;
        string value30 = null;

        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            else if (count == 1)
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            else if (count == 2)
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            else if (count == 3)
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            else if (count == 4)
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            else if (count == 5)
                value6 = Convert.ToString(authorsList.GetValue(5).ToString());
            else if (count == 6)
                value7 = Convert.ToString(authorsList.GetValue(6).ToString());
            else if (count == 7)
                value8 = Convert.ToString(authorsList.GetValue(7).ToString());
            else if (count == 8)
                value9 = Convert.ToString(authorsList.GetValue(8).ToString());
            else if (count == 9)
                value10 = Convert.ToString(authorsList.GetValue(9).ToString());
            else if (count == 10)
                value11 = Convert.ToString(authorsList.GetValue(10).ToString());
            else if (count == 11)
                value12 = Convert.ToString(authorsList.GetValue(11).ToString());
            else if (count == 12)
                value13 = Convert.ToString(authorsList.GetValue(12).ToString());
            else if (count == 13)
                value14 = Convert.ToString(authorsList.GetValue(13).ToString());
            else if (count == 14)
                value15 = Convert.ToString(authorsList.GetValue(14).ToString());
            else if (count == 15)
                value16 = Convert.ToString(authorsList.GetValue(15).ToString());
            else if (count == 16)
                value17 = Convert.ToString(authorsList.GetValue(16).ToString());
            else if (count == 17)
                value18 = Convert.ToString(authorsList.GetValue(17).ToString());
            else if (count == 18)
                value19 = Convert.ToString(authorsList.GetValue(18).ToString());
            else if (count == 19)
                value20 = Convert.ToString(authorsList.GetValue(19).ToString());
            else if (count == 20)
                value21 = Convert.ToString(authorsList.GetValue(20).ToString());
            else if (count == 21)
                value22 = Convert.ToString(authorsList.GetValue(21).ToString());
            else if (count == 22)
                value23 = Convert.ToString(authorsList.GetValue(22).ToString());
            else if (count == 23)
                value24 = Convert.ToString(authorsList.GetValue(23).ToString());
            else if (count == 24)
                value25 = Convert.ToString(authorsList.GetValue(24).ToString());
            else if (count == 25)
                value26 = Convert.ToString(authorsList.GetValue(25).ToString());
            else if (count == 26)
                value27 = Convert.ToString(authorsList.GetValue(26).ToString());
            else if (count == 27)
                value28 = Convert.ToString(authorsList.GetValue(27).ToString());
            else if (count == 28)
                value29 = Convert.ToString(authorsList.GetValue(28).ToString());
            else if (count == 29)
                value30 = Convert.ToString(authorsList.GetValue(29).ToString());

        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        obj.Keywords6 = value6;
        obj.Keywords7 = value7;
        obj.Keywords8 = value8;
        obj.Keywords9 = value9;
        obj.Keywords10 = value10;
        obj.Keywords11 = value11;
        obj.Keywords12 = value12;
        obj.Keywords13 = value13;
        obj.Keywords14 = value14;
        obj.Keywords15 = value15;
        obj.Keywords16 = value16;
        obj.Keywords17 = value17;
        obj.Keywords18 = value18;
        obj.Keywords19 = value19;
        obj.Keywords20 = value20;
        obj.Keywords21 = value21;
        obj.Keywords22 = value22;
        obj.Keywords23 = value23;
        obj.Keywords24 = value24;
        obj.Keywords25 = value25;
        obj.Keywords26 = value26;
        obj.Keywords27 = value27;
        obj.Keywords28 = value28;
        obj.Keywords29 = value29;
        obj.Keywords30 = value30;
        gvLead.DataSource = obj.LoadAllMultiple(obj);
        gvLead.DataBind();
    }
    protected void BindVendor()
    {
        clsVendor obj = new clsVendor();
        string authors = txtVendor.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        string value6 = null;
        string value7 = null;
        string value8 = null;
        string value9 = null;
        string value10 = null;
        string value11 = null;
        string value12 = null;
        string value13 = null;
        string value14 = null;
        string value15 = null;
        string value16 = null;
        string value17 = null;
        string value18 = null;
        string value19 = null;
        string value20 = null;
        string value21 = null;
        string value22 = null;
        string value23 = null;
        string value24 = null;
        string value25 = null;
        string value26 = null;
        string value27 = null;
        string value28 = null;
        string value29 = null;
        string value30 = null;

        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            else if (count == 1)
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            else if (count == 2)
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            else if (count == 3)
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            else if (count == 4)
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            else if (count == 5)
                value6 = Convert.ToString(authorsList.GetValue(5).ToString());
            else if (count == 6)
                value7 = Convert.ToString(authorsList.GetValue(6).ToString());
            else if (count == 7)
                value8 = Convert.ToString(authorsList.GetValue(7).ToString());
            else if (count == 8)
                value9 = Convert.ToString(authorsList.GetValue(8).ToString());
            else if (count == 9)
                value10 = Convert.ToString(authorsList.GetValue(9).ToString());
            else if (count == 10)
                value11 = Convert.ToString(authorsList.GetValue(10).ToString());
            else if (count == 11)
                value12 = Convert.ToString(authorsList.GetValue(11).ToString());
            else if (count == 12)
                value13 = Convert.ToString(authorsList.GetValue(12).ToString());
            else if (count == 13)
                value14 = Convert.ToString(authorsList.GetValue(13).ToString());
            else if (count == 14)
                value15 = Convert.ToString(authorsList.GetValue(14).ToString());
            else if (count == 15)
                value16 = Convert.ToString(authorsList.GetValue(15).ToString());
            else if (count == 16)
                value17 = Convert.ToString(authorsList.GetValue(16).ToString());
            else if (count == 17)
                value18 = Convert.ToString(authorsList.GetValue(17).ToString());
            else if (count == 18)
                value19 = Convert.ToString(authorsList.GetValue(18).ToString());
            else if (count == 19)
                value20 = Convert.ToString(authorsList.GetValue(19).ToString());
            else if (count == 20)
                value21 = Convert.ToString(authorsList.GetValue(20).ToString());
            else if (count == 21)
                value22 = Convert.ToString(authorsList.GetValue(21).ToString());
            else if (count == 22)
                value23 = Convert.ToString(authorsList.GetValue(22).ToString());
            else if (count == 23)
                value24 = Convert.ToString(authorsList.GetValue(23).ToString());
            else if (count == 24)
                value25 = Convert.ToString(authorsList.GetValue(24).ToString());
            else if (count == 25)
                value26 = Convert.ToString(authorsList.GetValue(25).ToString());
            else if (count == 26)
                value27 = Convert.ToString(authorsList.GetValue(26).ToString());
            else if (count == 27)
                value28 = Convert.ToString(authorsList.GetValue(27).ToString());
            else if (count == 28)
                value29 = Convert.ToString(authorsList.GetValue(28).ToString());
            else if (count == 29)
                value30 = Convert.ToString(authorsList.GetValue(29).ToString());

        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        obj.Keywords6 = value6;
        obj.Keywords7 = value7;
        obj.Keywords8 = value8;
        obj.Keywords9 = value9;
        obj.Keywords10 = value10;
        obj.Keywords11 = value11;
        obj.Keywords12 = value12;
        obj.Keywords13 = value13;
        obj.Keywords14 = value14;
        obj.Keywords15 = value15;
        obj.Keywords16 = value16;
        obj.Keywords17 = value17;
        obj.Keywords18 = value18;
        obj.Keywords19 = value19;
        obj.Keywords20 = value20;
        obj.Keywords21 = value21;
        obj.Keywords22 = value22;
        obj.Keywords23 = value23;
        obj.Keywords24 = value24;
        obj.Keywords25 = value25;
        obj.Keywords26 = value26;
        obj.Keywords27 = value27;
        obj.Keywords28 = value28;
        obj.Keywords29 = value29;
        obj.Keywords30 = value30;
        gvVendor.DataSource = obj.LoadAllMultiple(obj);
        gvVendor.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsActivityInstance Item = new clsActivityInstance();
        //if(ItemId>0)
        //{
        //    Item.ActivityInstanceId = Convert.ToInt32(ItemId);
        //}
        //if (ddlActivityCategory.SelectedValue != "" && ddlActivitySubCategory.SelectedValue != "" && ddlActivity.SelectedValue != "")
        //{

        Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
        //Session["ActivityCategoryId"] = Item.ActivityCategoryId;
        Item.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
        //Session["ActivitySubCategoryId"] = Item.ActivitySubCategoryId;
        Item.ActivityId = Convert.ToInt32(ddlActivity.SelectedValue);
        //Session["ActivityId"] = Item.ActivityId;

        //if(ddlEmployee.SelectedIndex>0|| ddlParticipant.SelectedIndex>0)
        //{
        //    if (ddlEmployee.SelectedValue != "")
        //    {
        //  Item.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        //        Session["EmployeeId"] = Item.EmployeeId;
        //    }
        //    if (ddlParticipant.SelectedValue != "")
        //    {
        //        Item.ParticipantId = Convert.ToInt32(ddlParticipant.SelectedValue);
        //        Session["ParticipantId"] = Item.ParticipantId;
        //    }
        //}
        //else
        //{
        //    ErrorMessage.Text = "Please Select Employee/Participant or both values";
        //    ErrorMessage.Visible = true;
        //}
        //var checkedBoxes = Form.Controls.OfType<CheckBox>().Count(c => c.Checked);
        //Item.EmployeeId = checkedBoxes;

        int Sno = 1;
        string InvolvedEmployees = Convert.ToString(CurrentUser.CurrentName);
        string EmployeesPhoneNumbers = Convert.ToString(CurrentUser.CurrentUserMobile);
        foreach (GridViewRow row in gvemployee.Rows)
        {
            Label lbltext = (Label)row.FindControl("lblEmployees");
            Label lblPhone = (Label)row.FindControl("lblEMobile");
            if ((row.FindControl("CheckBox2") as CheckBox).Checked)
            {
                Label lbl = (Label)row.FindControl("lblEmployees");
                Label lblEPhone = (Label)row.FindControl("lblEMobile");
                string Qids = lbl.Text;
                string EMobile = lblEPhone.Text;
                Sno = Sno + 1;
                InvolvedEmployees = InvolvedEmployees + " , " + lbl.Text;
                EmployeesPhoneNumbers = EmployeesPhoneNumbers + " , " + lblEPhone.Text;
            }
        }
        Item.NoOfEmployeeId = Convert.ToInt32(Sno);
        Item.InvolvedEmployees = Convert.ToString(InvolvedEmployees);
        Item.EmployeesPhoneNumbers = Convert.ToString(EmployeesPhoneNumbers);
        int Sno1 = 0;
        string InvolvedParfticipants = "";
        string ParticipantsPhoneNumbers = "";
        foreach (GridViewRow row in gvPartiicipant.Rows)
        {
            if ((row.FindControl("CheckBox3") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lbParticipant");
                Label lblPhone = (Label)row.FindControl("lblMobile");
                string Qids = lbltext.Text;
                string Phone = lblPhone.Text;
                Sno1 = Sno1 + 1;
                InvolvedParfticipants = InvolvedParfticipants + lbltext.Text + " , ";
                ParticipantsPhoneNumbers = ParticipantsPhoneNumbers + lblPhone.Text + " , ";
            }
        }
        Item.NoOfParticipantId = Convert.ToInt32(Sno1);
        Item.InvolvedParticipants = Convert.ToString(InvolvedParfticipants);
        Item.ParticipantsPhoneNumbers = Convert.ToString(ParticipantsPhoneNumbers);
        int Sno2 = 0;
        string InvolvedLeads = "";
        string LeadsPhoneNumbers = "";
        foreach (GridViewRow row in gvLead.Rows)
        {
            if ((row.FindControl("CheckBox4") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblLead");
                Label lblPhone = (Label)row.FindControl("lblPrimaryMobile");
                string Qids = lbltext.Text;
                string Phone = lblPhone.Text;
                Sno2 = Sno2 + 1;
                InvolvedLeads = InvolvedLeads + lbltext.Text + " , ";
                LeadsPhoneNumbers = LeadsPhoneNumbers + lblPhone.Text + " , ";
            }
        }
        Item.NoOfLeads = Convert.ToInt32(Sno2);
        Item.InvolvedLeads = Convert.ToString(InvolvedLeads);
        Item.LeadsPhoneNumbers = Convert.ToString(LeadsPhoneNumbers);
        int Sno3 = 0;
        string InvolvedVendors = "";
        string VendorsPhoneNumbers = "";
        foreach (GridViewRow row in gvVendor.Rows)
        {
            if ((row.FindControl("CheckBox5") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblVendor");
                Label lblPhone = (Label)row.FindControl("lblMobile");
                string Qids = lbltext.Text;
                string Phone = lblPhone.Text;
                Sno3 = Sno3 + 1;
                InvolvedVendors = InvolvedVendors + lbltext.Text + " , ";
                VendorsPhoneNumbers = VendorsPhoneNumbers + lblPhone.Text + " , ";
            }
        }
        Item.NoOfVendors = Convert.ToInt32(Sno3);
        Item.InvolvedVendors = Convert.ToString(InvolvedVendors);
        Item.VendorsPhoneNumbers = Convert.ToString(VendorsPhoneNumbers);
        Item.CreatedBy = CurrentUser.CurrentUserId;
        string id = Guid.NewGuid().ToString();
        Item.UniqueId = Convert.ToString(id);
        Item.JobDescription = Convert.ToString(txtJobDescription.Text);
        if (txtFollowupdate.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtFollowupdate.Text, "dd/MM/yyyy", null);
            Item.DateToWorkOn = Convert.ToDateTime(Date);
        }
        Item.Description = Convert.ToString(txtfollowupdescription.Text);
        Item.Status = "New";
        Item.AddUpdate(Item);


















        ddlActivityCategory.SelectedIndex = -1;
        ddlActivitySubCategory.SelectedIndex = -1;
        
        //ddlEmployee.SelectedIndex = -1;
        //ddlParticipant.SelectedIndex = -1;
        //ddlLocation.SelectedIndex = -1;
        //gv.Visible = false;
        gvemployee.Visible = false;
        gvPartiicipant.Visible = false;
        gvLead.Visible = false;
        gvVendor.Visible = false;
        txtEmployee.Text = "";
        txtParticipant.Text = "";
        txtLead.Text = "";
        txtVendor.Text = "";
        FormMessage.Visible = false;
        txtFollowupdate.Text = "";
        txtfollowupdescription.Text = "";
        FormMessage.Text = "Activity Task Created Successfully";
        FormMessage.Visible = true;
        //  FormMessage.Text = "Activity Instance Created Successfully";
        //FormMessage.Visible = true;
        //gv.Visible = true;
        //Binddata();
        Item = Item.LoadUniqueId(Item.UniqueId);
        //int ActivityInstanceId4 = Convert.ToInt32(Item.ActivityInstanceId);
        //{
        //    clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
        //    objUG.ActivityInstanceId = ActivityInstanceId4;
        //    objUG.EmployeeId = Convert.ToInt32(CurrentUser.CurrentUserId);
        //    objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
        //    objUG.AddUpdate(objUG);
        //}
        int ActivityInstanceId = Convert.ToInt32(Item.ActivityInstanceId);
        foreach (GridViewRow row in gvemployee.Rows)
        {
            if ((row.FindControl("CheckBox2") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblEmployee");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId;
                objUG.EmployeeId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }






        int ActivityInstanceId1 = Convert.ToInt32(Item.ActivityInstanceId);
        foreach (GridViewRow row in gvPartiicipant.Rows)
        {
            if ((row.FindControl("CheckBox3") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lbParticipantId");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId1;
                objUG.ParticipantId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }






        int ActivityInstanceId2 = Convert.ToInt32(Item.ActivityInstanceId);
        foreach (GridViewRow row in gvLead.Rows)
        {
            if ((row.FindControl("CheckBox4") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblLeadId");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId;
                objUG.LeadId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }
        int ActivityInstanceId3 = Convert.ToInt32(Item.ActivityInstanceId);
        foreach (GridViewRow row in gvVendor.Rows)
        {
            if ((row.FindControl("CheckBox5") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblVendorId");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId;
                objUG.VendorId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }
        int ActivityInstanceId4 = Convert.ToInt32(Item.ActivityInstanceId);
        {
            clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
            objUG.ActivityInstanceId = ActivityInstanceId;
            objUG.EmployeeId = Convert.ToInt32(CurrentUser.CurrentEmployeeId);
            objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            objUG.AddUpdate(objUG);
        }




        if (ddlActivity.SelectedValue == "93")
        {
            foreach (GridViewRow row in gvPartiicipant.Rows)
            {
                int ResumeSubmissionId = 0;
                if ((row.FindControl("CheckBox3") as CheckBox).Checked)
                {
                    Label lbltext = (Label)row.FindControl("lbParticipantId");
                    int Tids = Convert.ToInt32(lbltext.Text);

                    clsResumeSubmission ResumeSubmission = new clsResumeSubmission();
                    if (ResumeSubmissionId > 0)
                        ResumeSubmission.ResumeSubmissionId = Convert.ToInt32(ResumeSubmissionId);
                    ResumeSubmission.CompanyName = InvolvedVendors;


                    ResumeSubmission.JobDescription = txtJobDescription.Text; /**/



                    ResumeSubmission.Location = txtLocation.Text;
                    ResumeSubmission.Experience = txtExperiance.Text;
                    ResumeSubmission.Domain = txtDomain.Text;
                    DateTime AppliedOnDateTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                    //DateTime AppliedOn = DateTime.ParseExact(DateTime.ToString(), "dd/MM/yyyy", null);
                    ResumeSubmission.AppliedOn = AppliedOnDateTime;
                    ResumeSubmission.AppliedThroughId = 4;
                    ResumeSubmission.InterviewStatusId = 8;
                    ResumeSubmission.ParticipantId = Tids;
                    ResumeSubmission.CreatedBy = CurrentUser.CurrentUserId;
                    ResumeSubmission.AddUpdate(ResumeSubmission);
                }
            }
            
           
        }





























        ddlActivity.SelectedIndex = -1;

        Response.Redirect("ActivityTaskInputs.aspx?ItemId=" + Item.ActivityInstanceId);
        // btnstartActivity.Visible = true;
        //txtActivityDescription.Visible = true;
        //txtActivityDescription.Enabled = true;
        //txtActivityDescription.Visible = false;
        //ddlActivityCategory.SelectedIndex = -1;
        //ddlActivitySubCategory.SelectedIndex = -1;
        //ddlActivity.SelectedIndex = -1;
        //ddlEmployee.SelectedIndex = -1;
        // ddlParticipant.SelectedIndex = -1;
        //ddlLocation.SelectedIndex = -1;
        //txtLocation.Text = "";
        //txtEmployee.Text = "";
        //txtParticipant.Text = "";

        //}
        //else
        //{
        //    ErrorMessage.Text = "Please Create ActivityInstance based on above fields ";
        //    ErrorMessage.Visible = true;

        //}
    }

    //protected void BindLocation()
    //{
    //    clsLocation obj = new clsLocation();
    //    obj.keywords = txtLocation.Text;
    //    ddlLocation.DataSource = obj.LoadAll(obj);
    //    ddlLocation.DataValueField = "LocationId";
    //    ddlLocation.DataTextField = "Location";
    //    ddlLocation.DataBind();
    //    ddlLocation.Items.Insert(0, new ListItem("Select Location", ""));
    //}
    //protected void btnreset_Click(object sender, EventArgs e)
    //{
    //    //ddlActivityCategory.SelectedIndex = -1;
    //    //ddlActivitySubCategory.SelectedIndex = -1;
    //    //ddlActivity.SelectedIndex = -1;
    //    //ddlEmployee.SelectedIndex = -1;
    //    //ddlParticipant.SelectedIndex = -1;
    //    //ddlLocation.SelectedIndex = -1;
    //    ddlActivityCategory.SelectedValue = "";
    //    ddlActivitySubCategory.SelectedValue = "";
    //    ddlActivity.SelectedValue = "";
    //    gv.Visible = false;
    //    gvemployee.Visible = false;
    //    gvPartiicipant.Visible = false;
    //    gvLead.Visible = false;
    //    gvVendor.Visible = false;
    //    txtEmployee.Text = "";
    //    txtParticipant.Text = "";
    //    txtLead.Text = "";
    //    txtVendor.Text = "";
    //    FormMessage.Visible = false;
    //    //txtFollowupdate.Text = "";
    //    //txtfollowupdescription.Text = "";
    //}
    //protected void btnstartActivity_Click(object sender, EventArgs e)
    //{
    //    btnstartActivity.Visible = true;
    //    txtActivityDescription.Visible = true;
    //    btnEndActivity.Visible = true;
    //}

    //protected void EndActivity_Click(object sender, EventArgs e)
    //{
    //    clsActivityInteractions item = new clsActivityInteractions();
    //    item.ActivityInteractionInputs = Convert.ToString(txtActivityDescription.Text);

    //    item.StartTime = Convert.ToDateTime(Session["StartTime"]);
    //    item.StartDate = Convert.ToDateTime(Session["StartDate"]);
    //    item.EndTime = Convert.ToDateTime(DateTime.Now.ToString());
    //    item.EndDate = DateTime.UtcNow.AddHours(5).AddMinutes(30);
    //    item.CreatedBy = CurrentUser.CurrentUserId;
    //    item.AddUpdate(item);

    //    //item.ActivityInstanceId=
    //}
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("ActivityInstanceCreation.aspx?ItemId=" + e.CommandArgument);
        }
    }
    protected void Binddata()
    {
        clsActivityInstance obj = new clsActivityInstance();
        //obj.EmployeeId = CurrentUser.CurrentUserId;
        gv.DataSource = obj.LoadAll(obj);
        gv.DataBind();
    }
    //protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        if (e.Row.Cells[0].Text == IDvariable)
    //        {
    //            ((LinkButton)e.Row.FindControl("NameOfLinkButton")).Visible = false;
    //        }
    //    }

    //}
    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindParticipant();
    }
    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        //if(ddlEmployee.SelectedIndex>0)
        //{
        //    int EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);

        //}
        BindEmployee();
    }

    //protected void txtLocation_TextChanged(object sender, EventArgs e)
    //{
    //    BindLocation();
    //}
    protected void ddlActivityCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if(ddlActivityCategory.SelectedIndex>0)
        //{
        BindActivitySubCategory();
        //}
        ErrorMessage.Visible = false;
        divResume.Visible = false;
    }
    protected void ddlActivitySubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if(ddlActivityCategory.SelectedIndex>0 && ddlActivitySubCategory.SelectedIndex>0)
        //{
        BindActivity();
        divResume.Visible = false;
        //ErrorMessage.Visible = false;
        //}
    }
    protected void ddlActivity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlActivity.SelectedValue == "93")
            divResume.Visible = true;
        else
            divResume.Visible = false;
       
        //ErrorMessage.Visible = false;
    }

    //protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ErrorMessage.Visible = false;
    //}

    //protected void ddlParticipant_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ErrorMessage.Visible = false;
    //}

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        Binddata();
    }
    //protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {

    //        ///find the button object
    //        Button btn = (Button)e.Row.Cells[6].FindControl("lnkEdit");

    //        ///Add the attribute to disable the button
    //        btn.Attributes.Add("onclick", "this.disabled=true;");

    //    }
    //}

    //protected void gv_RowDataBound1(object sender, GridViewRowEventArgs e)
    //{

    //}
    protected void btnInteractionSearchPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityTasks.aspx");
    }
    protected void txtLead_TextChanged(object sender, EventArgs e)
    {
        BindLead();
    }
    protected void txtVendors_TextChanged(object sender, EventArgs e)
    {
        BindVendor();
    }
}