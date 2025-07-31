<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="KPIActivityMapping.aspx.cs" Inherits="Admin_KPIActivityMapping" %>

<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc1" TagName="ErrorMessage" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc2" TagName="FormMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'KPI Activity Mapping Added Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'KPI Activity Mapping Updated Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeDuplicate() {
            Swal.fire(
                      'KPI Activity Mapping already exist',
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
                                    <label class="col-sm-2 control-label">
                                        KPI Name<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlKPI" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlKPI_SelectedIndexChanged"></asp:DropDownList>
                                    </div>
                                     <asp:RequiredFieldValidator ID="rfvKPI" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlKPI" ErrorMessage="Please Select KPI" ></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Activity Category<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlActivityCategory" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlActivityCategory_SelectedIndexChanged"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Activity Subcategory<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlActivitySubCategory" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlActivitySubCategory_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Activity Name<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlActivity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlActivity_SelectedIndexChanged">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvKPIActivity" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlActivity" ErrorMessage="Please Select Activity" ></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Vallue Alloted<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtValueAlloted" MaxLength="5" runat="server" required="true" AutoPostBack="true"></asp:TextBox>
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

