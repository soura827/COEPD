<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="KPIEmployeeMapping.aspx.cs" Inherits="Admin_KPIEmployeeMapping" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'KPI Employee Mapping Added Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'KPI Employee Mapping Updated Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeDuplicate() {
            Swal.fire(
                      'KPI Employee Mapping already exist',
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
            <!-- Row Start-->
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
                                    <label class="col-sm-2 control-label">
                                        Employee<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployee_SelectedIndexChanged">

                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvEmployee" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlEmployee" ErrorMessage="Please Select Employee" ></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        KPI<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlKPI" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlKPI_SelectedIndexChanged">

                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvKPI" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlKPI" ErrorMessage="Please Select KPI" ></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Target For Month<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtTargetForMonth" runat="server" AutoPostBack="true" required=""></asp:TextBox>
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

