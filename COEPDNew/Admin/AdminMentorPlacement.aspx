<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AdminMentorPlacement.aspx.cs" Inherits="Admin_AdminMentorPlacement" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'KPI Employee  Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'KPI Employee Updated Successfully',
                '',
                'success'
            )
        }
        function alertmeDuplicate() {
            Swal.fire(
                'KPI Employee  already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <%--<uc1:FormMessage runat="server" ID="FormMessage" Visible="false" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

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

                                <div class="col-md-2 col-lg-2">
                                    <asp:TextBox runat="server" ID="txttarget" MaxLength="250" placeholder="Targets" AutoPostBack="true"></asp:TextBox>
                                </div>

                                <div class="col-lg-2 col-md-2">
                                    <asp:Button ID="btnAddTarget" runat="server" Text="NewTargets" AutoPostBack="true" CausesValidation="false" OnClick="btnAddTarget_Click" />
                                </div>

                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        KPI Applicable To<sup class="sup">*</sup>:
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlKPIApplicableTo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlKPIApplicableTo_SelectedIndexChanged1">
                                        </asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator ID="rfvKPIApplicableTo" runat="server" InitialValue="0" ForeColor="Red" Font-Bold="true" ControlToValidate="ddlKPIApplicableTo" ErrorMessage="Please Select KPI Applicable To"></asp:RequiredFieldValidator>
                                </div>

                                <div class="widget-body">
                                    <div class="Row">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>
                                                        <asp:CheckBox ID="chkall" runat="server" AutoPostBack="true" OnCheckedChanged="chkall_CheckedChanged" />
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkst" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField HeaderText="KPIId" DataField="KPIId" />
                                                <asp:BoundField HeaderText="KPIName" DataField="KPIName" />
                                                <asp:BoundField HeaderText="Target" DataField="MonthlyTarget" />
                                               <%-- <asp:TemplateField HeaderText="Action" ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="LinkEdit" runat="server" CausesValidation="false" CommandName="cmdEdit" CommandArgument='<%# Eval("KPIId")%>' Text="Edit"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Action" ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="LinkDelete" runat="server" SkinID="cmdDelete" CausesValidation="false" CommandName="cmdDelete" CommandArgument='<%# Eval("KPIId")%>' Text="Delete"></asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>--%>
                                                
                                            </Columns>
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:GridView>
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Select  Team
                                  <asp:Label runat="server" ID="Label1" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:DropDownList ID="ddlDesignations" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlDesignations_SelectedIndexChanged"></asp:DropDownList>
                                    </div>
                                </div>


                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Associate Name </label>

                                    <div class="col-sm-5">
                                        <asp:TextBox runat="server" ID="txtEmployeename" Placeholder="Employee Name" OnTextChanged="txtEmployeename_TextChanged" AutoPostBack="True"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="widget-body">
                                    <div class="Row">
                                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%">
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>
                                                        <asp:CheckBox ID="chkselectedall" runat="server" AutoPostBack="true" OnCheckedChanged="chkselectedall_CheckedChanged" />
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkSelectEmployee" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField HeaderText="EmployeeId" DataField="EmployeeId" />
                                                <asp:BoundField HeaderText="Employee" DataField="Employee" />



                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />
        </div>
    </div>

</asp:Content>

