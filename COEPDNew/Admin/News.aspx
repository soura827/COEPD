<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="News.aspx.cs" Inherits="News" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                                Website Page
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlCMS" runat="server" Required="">
                                    <asp:ListItem Text="-- Select Page --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Hyderabad" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Chennai" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Pune" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Mumbai" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Visakhapatnam" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Banglore" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Delhi" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Solapur" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training in Dallas" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Online Trainng" Value="10"></asp:ListItem>
                                    <asp:ListItem Text="Business Intelligence Tools" Value="11"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Training Internships" Value="12"></asp:ListItem>
                                    <asp:ListItem Text="Internet of Things" Value="13"></asp:ListItem>
                                    <asp:ListItem Text="Dot Net" Value="14"></asp:ListItem>
                                    <asp:ListItem Text="Digital Marketing" Value="15"></asp:ListItem>
                                    <asp:ListItem Text="Testing" Value="16"></asp:ListItem>
                                    <asp:ListItem Text="Web Designing" Value="17"></asp:ListItem>
                                    <asp:ListItem Text="Data Science" Value="18"></asp:ListItem>
                                    <asp:ListItem Text="VMware vSphere" Value="19"></asp:ListItem>
                                    <asp:ListItem Text="Webdeign internship" Value="20"></asp:ListItem>
                                    <asp:ListItem Text="Dotnet internship" Value="21"></asp:ListItem>
                                    <asp:ListItem Text="Datascience internship" Value="22"></asp:ListItem>
                                    <asp:ListItem Text="Digital marketing internship" Value="23"></asp:ListItem>
                                    <asp:ListItem Text="IIBA CPOA Certification Training" Value="24"></asp:ListItem>
                                    <asp:ListItem Text="Scrum Training" Value="27"></asp:ListItem>
                                    <asp:ListItem Text="Business Analyst Corporate Training" Value="25"></asp:ListItem>
                                    <asp:ListItem Text="Knowledge Partner" Value="26"></asp:ListItem>
                                     
                                    <%-- <asp:ListItem Text="BA internship" Value="24"></asp:ListItem>--%>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                News Description
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtNewsDescription" runat="server" Height="200" TextMode="MultiLine" Required="">
                                </asp:TextBox>
                            </div>
                        </div>
                        <%--<div class="form-group">
                            <label class="col-sm-2 control-label">
                                Is Active?
                            </label>
                            <div class="col-sm-10">
                                <asp:CheckBox ID="chkActive" runat="server" Checked="true"></asp:CheckBox>
                            </div>
                        </div>--%>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
