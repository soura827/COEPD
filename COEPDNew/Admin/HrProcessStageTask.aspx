<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HrProcessStageTask.aspx.cs" Inherits="Admin_HrProcessStageTask" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc1" TagName="FormMessage" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc2" TagName="ErrorMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Hr Process Stage Task Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Hr Process Stage Task Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Hr Process Stage Task already exist',
                '',
                'warning'
            )
        }
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">

    <uc1:FormMessage runat="server" ID="FormMessage" Visible="false" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />

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
                                        Hr Process Stage Name<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlNurturingProcessStage" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNurturingProcessStage_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator ID="rfvNurturingProcessStage" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlNurturingProcessStage" ErrorMessage="Please Select Nurturing Process Stage"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Hr Process Stage Task Name<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtNurturingProcessStageTaskName" runat="server" MaxLength="100" AutoPostBack="true" Required="" OnTextChanged="txtNurturingProcessStageTaskName_TextChanged"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Weightage<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtWeightage" runat="server" Type="Number" Required=""></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label">
                                        Time Frame<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtTimeFrame" runat="server" Type="Number" Required=""></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
                                        <asp:Button ID="btnAdd" runat="server" Text="Add New" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnAdd_Click" />
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

