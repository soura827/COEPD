<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AwardSearch.aspx.cs" Inherits="Admin_AwardSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
        function alertmeDelete() {
            Swal.fire(
                      'Employee Removed Successfully',
                      '',
                      'success'
                    )
        }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
    <div class="Row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Awards Details
                    </div>
                </div>
                <div class="widget-body">
                    <div class="Row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtSearchByAward" Placeholder="Search by Award" OnTextChanged="txtSearchByAward_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtCreatedByName" Placeholder=" Created By Name" OnTextChanged="txtSearchByAward_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtModifiedByName" Placeholder=" Modified By Name" OnTextChanged="txtSearchByAward_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button runat="server" ID="btnAdd" Text="Add New" OnClick="btnAdd_Click" />
                        </div>
                    </div>
                        <div>
                        &nbsp;
                    </div>
                    <div>
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="Row">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" OnRowCommand="gv_RowCommand" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                            <Columns>
                                <asp:BoundField HeaderText="S NO" DataField="SNo" />
                                <asp:BoundField HeaderText="Award Id" DataField="AwardId" />
                                <asp:BoundField HeaderText="Award Name" DataField="AwardName" />
                                <asp:BoundField HeaderText="Created On" DataField="CreatedOn"  DataFormatString="{0: dd MMM yyyy hh:mm tt}"/>
                                <asp:BoundField HeaderText="Created By" DataField="CreatedByName" />
                                <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                <asp:BoundField HeaderText="Modified By" DataField="ModifiedByName" />
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px" >
                                    <ItemTemplate>
                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                CommandArgument='<%#Eval("AwardId")%>'></asp:LinkButton>
                        <%--    <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                CommandArgument='<%#Eval("AwardId")%>' OnClientClick="return confirm('Are you sure you want to delete this Employee Award?');"></asp:LinkButton>--%>
                        </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>

            </div>
        </div>
    <!-- Row End -->
</asp:Content>

