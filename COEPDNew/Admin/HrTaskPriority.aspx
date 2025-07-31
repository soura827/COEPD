<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HrTaskPriority.aspx.cs" Inherits="Admin_HrTaskPriority" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Hr Task Priority Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Hr Task Priority Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Hr Task Priority already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />
    <uc2:FormMessage runat="server" ID="FormMessage" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <!-- Row Start -->
            <div class="Row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                <asp:Label runat="server" ID="lblTitle"></asp:Label>
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="form-horizontal no-margin">





                                
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Employee search <sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                         <asp:TextBox ID="txtSearch" runat="server" OnTextChanged="txtSearch_TextChanged"  AutoPostBack="true" ></asp:TextBox>
                                    </div>
                                </div>








                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Employee<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <%--<div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Nurturing Process Stage<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtNurturingProcessStage" runat="server" MaxLength="100" Required=""></asp:TextBox>
                                    </div>
                                </div>--%>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Hr Process Stage Task<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlNurturingProcessStageTask" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStageTask_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Priority<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtPriority" runat="server" Min="0" Max="100" Type="Number" Required=""></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-sm-offset-3 col-sm-9">
                                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <!-- Row End -->
</asp:Content>

