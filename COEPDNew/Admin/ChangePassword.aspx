<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Admin_ChangePassword" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">





    <script language="javascript" type="text/javascript">



        function alertmeSave() {
            Swal.fire(
                'Change Password Details Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated Change Password  Details Successfully',
                '',
                'success'
            )
        }

       
    </script>
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
                        Change Password Details 
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Search Employee
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtSessionTrainer" runat="server" AutoPostBack="true" OnTextChanged="txtSessionTrainer_TextChanged"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">


                            <label class="col-sm-2 control-label">
                                Select Employee
                            </label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="ddlSessionTrainer" runat="server" OnSelectedIndexChanged="ddlSessionTrainer_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>









                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Old Password
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtOldPassword" runat="server" OnTextChanged="txtOldPassword_TextChanged"></asp:TextBox>
                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                New Password
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtStarttime" runat="server" OnTextChanged="txtStarttime_TextChanged"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Confirm Password
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                            </div>
                        </div>





                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>

                            <div class="col-sm-4">
                                <asp:TextBox ID="txtEndtime" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                            &nbsp;
                        </div>


                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

