<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AdminMentorPlacementSearch.aspx.cs" Inherits="Admin_AdminMentorPlacementSearch" %>


<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">

    <uc1:FormMessage runat="server" ID="FormMessage" Visible="false" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" Visible="false" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="Row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        KPIs
                    </div>
                </div>


                <div class="widget-body">
                    <div class="Row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtEmployeeNames" MaxLength="100" Placeholder="Employee Name" OnTextChanged="txtEmployeeNames_TextChanged" AutoPostBack="True"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtKPIname" MaxLength="25" placeholder="KPINames" OnTextChanged="txtKPIname_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtkpiapplicalbeto" placeholder="KPIApplicalbeto" AutoPostBack="true" OnTextChanged="txtkpiapplicalbeto_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="true" CausesValidation="false" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                </div>

                <div>
                    <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                </div>
                <div class="Row">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" OnRowCommand="GridView1_RowCommand" OnPreRender="GridView1_PreRender" OnPageIndexChanging="GridView1_PageIndexChanging" >
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkall" runat="server" AutoPostBack="true" OnCheckedChanged="chkall_CheckedChanged" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkst" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="EmployeeKPIId" DataField="EmployeeKPIId"  ItemStyle-Width="50px" />
                            <asp:BoundField HeaderText="Associate name" DataField="Employee" />
                            <asp:BoundField HeaderText="Team" DataField="Designation" />
                            <asp:BoundField HeaderText="KPIName" DataField="KPIName" />
                            <asp:BoundField HeaderText="MonthlyTarget" DataField="MonthlyTarget" />
                            <asp:BoundField HeaderText="CreatedOn" DataField="CreatedOn" />
                            <asp:BoundField HeaderText="CreatedBy" DataField="CreatedName" />
                            <asp:BoundField HeaderText="ModifiedOn" DataField="ModifiedOn" />
                            <asp:BoundField HeaderText="ModifiedBy" DataField="ModifiedName" />
                          
                            <asp:TemplateField HeaderText="Action" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkEdit" runat="server" CausesValidation="false" CommandName="cmdEdit" CommandArgument='<%# Eval("EmployeeKPIId")%>' Text="Edit"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkDelete" runat="server"  SkinID="cmdDelete" CausesValidation="false" CommandName="cmdDelete" CommandArgument='<%# Eval("EmployeeKPIId")%>' Text="Delete"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:GridView>
                    <div>
                        <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                    </div>
                </div>
            </div>


        </div>
    </div>
</asp:Content>

