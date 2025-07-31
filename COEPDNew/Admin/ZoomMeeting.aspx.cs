using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Diagnostics;
using System.Threading;
using System.Activities.Expressions;

using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using System.Text;

using Microsoft.IdentityModel.Tokens;

public partial class Admin_ZoomMeeting : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsZoomMeeting Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentUser CurrentUser = new CurrentUser();
        clsZoomMeeting Item = new clsZoomMeeting();

            ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);


            Item = new clsZoomMeeting();
            if (!IsPostBack)
            {
                BindTrainer();
                BindBatch();
                BindCatagory();
                //BindTime();
                if (ItemId > 0)
                {
                    lblTitle.Text = "Edit Meeting Details";
                    Item = Item.Load(Convert.ToString(ItemId));
                    if (Item != null)
                    {
                        chkIsBatchOnly.Enabled = false;
                    //txtsHours.Enabled = false;
                    //txtsmints.Enabled = false;
                    //  txtEHours.Enabled = false;
                    //  txtEmints.Enabled = false;
                    //  ddlEStartAMPM.Enabled = false;
                    //  ddlEEndAMPM.Enabled = false;
                    //ddlBatch.Enabled = false;
                    //ddlZoommeetingCategory.Visible = true;
                    ddlZoommeetingCategory.Text = Convert.ToString(Item.ZoomMeetingCategoryId);
                    txtUrl.Text = (Item.URL);
                    txtZoomMeetingId.Text = Convert.ToString(Item.ZoomMeetingValueId);
                    txtPasscode.Text = Item.PassCode;
                    ddlHostemployee.SelectedValue = Convert.ToString(Item.HostEmployeeId);
                    if (Item.ZoomMeetingDate != null)
                        txtZoomMeetingDateOn.Text = Convert.ToString(Convert.ToDateTime(Item.ZoomMeetingDate));

                    if (Item.IsBatchOnly == true)
                    {
                        chkIsBatchOnly.Checked = true;


                    }
                    else
                    {
                        chkIsBatchOnly.Checked = false;

                    }
                    ddlBatch.SelectedValue = Convert.ToString(Item.BatchId);

                }
                btnsubmit.Enabled = false;
                txtZoomMeetingDateOn.Enabled = false;
            }

            else
            {
                lblTitle.Text = "Add Zoom Meeting Details";
                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);



            }
        }

    }
 
    protected void BindTrainer()
    {
        clsEmployee obj = new clsEmployee();
        ddlHostemployee.DataSource = obj.LoadAll(obj);
        ddlHostemployee.DataTextField = "Employee";
        ddlHostemployee.DataValueField = "EmployeeId";
        ddlHostemployee.DataBind();
        ddlHostemployee.Items.Insert(0, new ListItem("Search by Trainer", ""));
    }
    protected void BindBatch()
    {
        clsBatch obj = new clsBatch();
        ddlBatch.DataSource = obj.LoadAll(obj);
        ddlBatch.DataTextField = "Batch";
        ddlBatch.DataValueField = "BatchId";
        ddlBatch.DataBind();
        ddlBatch.Items.Insert(0, new ListItem("-- Select Batch --", ""));
    }
    protected void BindCatagory()
    {
        clsZoomCategory obj = new clsZoomCategory();
        ddlZoommeetingCategory.DataSource = obj.LoadAll(obj);
        ddlZoommeetingCategory.DataTextField = "ZoomMeetingCategory";
        ddlZoommeetingCategory.DataValueField = "ZoomMeetingCategoryId";
        ddlZoommeetingCategory.DataBind();
        ddlZoommeetingCategory.Items.Insert(0, new ListItem("-- Select Catagory --", ""));
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        var now = DateTime.UtcNow;
        var apiSecret = "VGCUDfuEKZVAMgpjg8bFQdcuJXwjglLY9Xat";
        byte[] symmetricKey = Encoding.ASCII.GetBytes(apiSecret);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = "lxFovL6EQpqdNekz0NZ2GA",
            Expires = now.AddSeconds(300),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256),
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        var client = new RestClient("https://api.zoom.us/v2/users/developer1@coepd.com/meetings");
        var request = new RestRequest("", Method.Post);
        request.RequestFormat = DataFormat.Json;
        request.AddJsonBody(new { topic = "Meeting with Sateesh", duration = "10", start_time = "2021-03-20T05:00:00", type = "2" });
        request.AddHeader("authorization", String.Format("Bearer {0}", tokenString));

        RestResponse restResponse = client.Execute(request);
        HttpStatusCode statusCode = restResponse.StatusCode;
        int numericStatusCode = (int)statusCode;
        var jObject = JObject.Parse(restResponse.Content);
        //Host.Text = (string)jObject["start_url"];
        //Join.Text = (string)jObject["join_url"];
        //Code.Text = Convert.ToString(numericStatusCode);

        String Host = (string)jObject["start_url"];
       String Join = (string)jObject["join_url"];
        String Code = Convert.ToString(numericStatusCode);

        Item = new clsZoomMeeting();
        if (ItemId > 0)
        {
            Item.ZoomMeetingId = ItemId;

        }

        Item.ZoomMeetingCategory = ddlZoommeetingCategory.SelectedValue.ToString();
        Item.URL = Convert.ToString(txtUrl.Text);
        Item.HostURL = Host;
        Item.JoinURL = Join;
        Item.PassCode = txtPasscode.Text;
        Item.ZoomMeetingValueId = Convert.ToString(txtZoomMeetingId.Text);
        Item.HostEmployeeId = Convert.ToInt32(ddlHostemployee.SelectedValue);

        if (chkIsBatchOnly.Checked == true)
        {
            
           Item.IsBatchOnly = true;
           Item.BatchId = Convert.ToInt32(ddlBatch.SelectedValue);
        }
        else
        {
            Item.IsBatchOnly = false;
            
        }
        //DateTime date = DateTime.ParseExact(txtZoomMeetingDateOn.Text, "dd/MM/yyyy", null);
        if (txtZoomMeetingDateOn.Text != "")
        {
            string date1 = txtZoomMeetingDateOn.Text;
            DateTime date = DateTime.ParseExact(txtZoomMeetingDateOn.Text, "dd/MM/yyyy", null);
            Item.ZoomMeetingDate = Convert.ToDateTime(date);

        }
        if (chkIsBatchOnly.Checked == false)
        {
            Item.IsBatchOnly = false;
            ddlBatch.Visible = false;
        }

        //if (txtZoomMeetingEndTimeOn.Text != "")
        //{
        //    DateTime date = DateTime.ParseExact(txtZoomMeetingEndTimeOn.Text, "dd/MM/yyyy", null);
        //    Item.ZoomMeetingEndTimeOn = Convert.ToDateTime(date);
        //}


        DateTime dt = DateTime.ParseExact(txtZoomMeetingDateOn.Text, "dd/MM/yyyy", null);
        Item.ZoomMeetingStartedTime = Convert.ToDateTime(dt);
        Item.ZoomMeetingEndedTime = Convert.ToDateTime(dt);
        string stHours;
        {
            if (txtsHours.Text.Length == 1)
            {
                stHours = "0" + txtsHours.Text;
            }
            else
            {
                stHours = txtsHours.Text;
            }
            string stTotalHours = stHours;
            if (ddlEStartAMPM.SelectedIndex == 1)
            {
                int ESAddHours = 12;
                int SSHours = int.Parse(stTotalHours);
                int ESHours = ESAddHours + SSHours;
                stTotalHours = Convert.ToString(ESHours);
            }
            else
            {
                stTotalHours = stHours;
            }

            string stMin;
            if (txtsmints.Text.Length == 1)
            {
                stMin = "0" + txtsmints.Text;
            }
            else
            {
                stMin = txtsmints.Text;
            }

            DateTime dt1 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + stTotalHours + ":" + stMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.ZoomMeetingStartTimeOn = dt1;
            string etHours;
            if (txtEHours.Text.Length == 1)
            {
                etHours = "0" + txtEHours.Text;
            }
            else
            {
                etHours = txtEHours.Text;
            }
            string EEndTotalHours = etHours;
            if (ddlEEndAMPM.SelectedIndex == 1)
            {
                int EEAddHours = 12;
                int EEHours = int.Parse(EEndTotalHours);
                int EETotalHours = EEAddHours + EEHours;
                EEndTotalHours = Convert.ToString(EETotalHours);
            }
            else
            {
                EEndTotalHours = etHours;
            }
            string etMin;
            if (txtEmints.Text.Length == 1)
            {
                etMin = "0" + txtEmints.Text;
            }
            else
            {
                etMin = txtEmints.Text;
            }
            DateTime dt2 = Convert.ToDateTime(DateTime.ParseExact(dt.ToString("dd/MM/yyyy") + " " + EEndTotalHours + ":" + etMin, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None));
            Item.ZoomMeetingEndTimeOn = dt2;
            if(dt2 > dt1)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "alertmeSave()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "randomtext", "GiveCorrectTime()", true);
            }

            Item.CreatedBy = CurrentUser.CurrentUserId;
            Item.AddUpdate(Item);
            ddlZoommeetingCategory.SelectedIndex = -1;
            txtUrl.Text = "";
            txtZoomMeetingId.Text = "";
            txtPasscode.Text = "";
            ddlHostemployee.SelectedIndex = -1;
            chkIsBatchOnly.Checked = false;
            ddlBatch.SelectedIndex=-1; 
            txtEHours.Text = "";
            txtEmints.Text = "";
            txtsHours.Text = "";
            txtsmints.Text = "";
            txtZoomMeetingDateOn.Text = null;
            btnsubmit.Enabled = false;
           
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ZoomMeetingSearch.aspx");
    }

    protected void chkIsBatchOnly_CheckedChanged(object sender, EventArgs e)
    {
        if (chkIsBatchOnly.Checked == true)
        {
            ddlBatch.SelectedValue = "";
            ddlBatch.Visible = true;
            lblBatchOnly.Visible = true;
        }

        else
        {
            ddlBatch.SelectedValue = "";
            ddlBatch.Visible = false;
            lblBatchOnly.Visible = false;
        }

    }




    protected void btnCreate_Click(object sender, EventArgs e)
    {
        var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
        var now = DateTime.UtcNow;
        var apiSecret = "VGCUDfuEKZVAMgpjg8bFQdcuJXwjglLY9Xat";
        byte[] symmetricKey = Encoding.ASCII.GetBytes(apiSecret);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = "lxFovL6EQpqdNekz0NZ2GA",
            Expires = now.AddSeconds(300),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256),
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        var client = new RestClient("https://api.zoom.us/v2/users/developer1@coepd.com/meetings");
        var request = new RestRequest("", Method.Post);
        request.RequestFormat = DataFormat.Json;
        request.AddJsonBody(new { topic = "Meeting with Sateesh", duration = "10", start_time = "2021-03-20T05:00:00", type = "2" });
        request.AddHeader("authorization", String.Format("Bearer {0}", tokenString));

        RestResponse restResponse = client.Execute(request);
        HttpStatusCode statusCode = restResponse.StatusCode;
        int numericStatusCode = (int)statusCode;
        var jObject = JObject.Parse(restResponse.Content);
        Host.Text = (string)jObject["start_url"];
        Join.Text = (string)jObject["join_url"];
        Code.Text = Convert.ToString(numericStatusCode);
    }
}


