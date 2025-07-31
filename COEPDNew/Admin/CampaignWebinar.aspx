<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CampaignWebinar.aspx.cs" Inherits="Admin_CampaignWebinar" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
      <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                         <div class="form-group">
                                <label class="col-sm-2 control-label">
                                  Title<sup class="sup">*</sup>
                                </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server"  ID="txtTitle" Required="" MaxLength="300"  CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Campaign Keywords
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtCampaign_Keywords" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Start Date
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-md-2">
                                <asp:TextBox ID="txtStartDay" min="1" Max="31" runat="server" type="number" CssClass="form-control"
                                    placeholder="DD" ></asp:TextBox>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="txtStartMonth" min="1" Max="12" runat="server" type="number" placeholder="MM"
                                    CssClass="form-control" ></asp:TextBox>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="txtStartYear" runat="server" type="number" CssClass="form-control" placeholder="YYYY"
                                     MaxLength="4" min="1950"></asp:TextBox>
                            </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                End Date
                            </label>
                            <div class="col-sm-10">
                                <div class="row">
                                    <div class="col-md-2">
                                <asp:TextBox ID="txtEndDay" min="1" Max="31" runat="server" type="number" CssClass="form-control"
                                    placeholder="DD" ></asp:TextBox>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="txtEndMonth" min="1" Max="12" runat="server" type="number" placeholder="MM"
                                    CssClass="form-control" ></asp:TextBox>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="txtEndYear" runat="server" type="number" CssClass="form-control" placeholder="YYYY"
                                     MaxLength="4" min="1950"></asp:TextBox>
                            </div>
                                </div>
                            </div>
                        </div>
                        <div class="form-group" id="divAttachemnts" runat="server">
                            <label class="col-sm-2 control-label">
                                Attachemnts
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Campaing-File</asp:HyperLink>
                                </h5>
                            </div>
                        </div>
                        <div class="form-group" id="divFileUpload" runat="server">
                            <label class="col-sm-2 control-label">
                                Upload File
                            </label>
                            <div class="col-sm-4">
                                <asp:FileUpload ID="flUpload" runat="server" />
                                <asp:RequiredFieldValidator runat="server" ID="ReqFileUpload" ControlToValidate="flUpload" ErrorMessage="Upload Campaing-File" ForeColor="Red" Font-Names="Verdana" Font-Size="10"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-sm-6">
                                <small>( Max 10 MB )</small>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP1
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP1" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP2
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP2" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP3
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP3" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP4
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP4" CssClass="form-control" required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP5
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP5" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP6
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP6" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP7
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP7" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP8
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP8" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP9
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP9" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                USP10
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtUSP10" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Mobile Number Required
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkMobileNumberRequired" runat="server"  CssClass="form-control"/>
                            </div>
                             <label class="col-sm-2 control-label">
                                Email Id Required
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkEmailIdRequired" runat="server" CssClass="form-control" />
                            </div>
                            <label class="col-sm-2 control-label">
                                Specific Enquiry Required
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkSpecificEnquiryRequired" runat="server" CssClass="form-control" />
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                               Active
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkActive" runat="server"  CssClass="form-control"/>
                            </div>
                             <label class="col-sm-2 control-label">
                                Deleted
                            </label>
                            <div class="col-sm-2">
                                <asp:CheckBox ID="chkDeleted" runat="server" CssClass="form-control" />
                            </div>
                            <label class="col-sm-2 control-label">
                            </label>
                            <div class="col-sm-2">
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                FollowUpURL
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" ID="txtFollowUpURL" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                               <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save"/>
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
                                    OnClick="btnCancel_Click"/>
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

