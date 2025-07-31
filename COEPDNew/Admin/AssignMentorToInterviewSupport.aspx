<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AssignMentorToInterviewSupport.aspx.cs" Inherits="Admin_AssignMentorToInterviewSupport" %>
<%@ Register src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
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
                        <asp:Label ID="lblTitle" Text="Assign Mentor to Interview Support" runat="server"></asp:Label>
                    </div>
                </div>
                 <div class="widget-body">
                <div class="form-horizontal no-margin">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Select Mentor<sup class="sup">*</sup>
                        </label>
                       
                        <div class="col-sm-5">
                            <asp:DropDownList runat="server" ID="ddlMentor" AutoPostBack="true" required="">

                            </asp:DropDownList>
                        </div>    
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="btnAssignMentor" runat="server" Text="Assign Mentor" OnClick="btnAssignMentor_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Back To List" SkinID="delete" CssClass="btn btn-warning btn-md" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
                        </div>
                    </div>

                </div>
            </div>
            </div>
           
        </div>

    </div>
    <!-- Row End -->
</asp:Content>

