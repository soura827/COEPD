<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CUGSimSearch.aspx.cs" Inherits="Admin_CUGSimSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
         .ui-widget-content .ui-icon {
    /background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")/ 
    /background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                CUG Sims
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtSim" MaxLength="500" placeholder="Search By Sim Number" OnTextChanged="txtSim_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtMobile" MaxLength="500" placeholder="Search By Mobile Number" OnTextChanged="txtSim_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-md-1 col-lg-1">
                                    <asp:DropDownList ID="ddlIsSimActivated" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtSim_TextChanged">
                                        <asp:ListItem Text="Active Sims" Value="True"></asp:ListItem>
                                        <asp:ListItem Text="Inactive Sims" Value="False"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlIsSimAssigned" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtSim_TextChanged">
                                        <asp:ListItem Text="Unassigned Sims" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Assigned Sims" Value="True"></asp:ListItem>
                                        
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtCreatedName" MaxLength="500" placeholder="Search By Created Name" OnTextChanged="txtSim_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtModifiedName" MaxLength="500" placeholder="Search By Modified Name" OnTextChanged="txtSim_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-1 col-md-1">
                                    <asp:Button ID="btnAdd" runat="server"  SkinID="addnew" OnClick="btnAdd_Click"/>
                                </div>
                            </div>
                            <div class="row">
                                 &nbsp;
                            </div>
                            <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                 <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="50" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                     <Columns>
                                         <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                         <asp:BoundField HeaderText="Sim Number" DataField="SimNumber" />
                                         <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
                                         <asp:TemplateField HeaderText="Sim Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsActivated").ToString()) ? "Activated" : "Not Activated" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                         <asp:BoundField HeaderText="Activation Date" DataField="ActivationDate" DataFormatString="{0: dd MMM yyyy}" />
                                         <asp:BoundField HeaderText="Tariff Plan" DataField="TarifPlan" />      
                                         <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                         <asp:BoundField HeaderText="Created By" DataField="CreatedName" />
                                         <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                          <asp:BoundField HeaderText="Modified By" DataField="ModifiedName" />
                                         <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                             <ItemTemplate>
                                                 <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("CUGSimId")%>'></asp:LinkButton>
                                                 <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("CUGSimId")%>' OnClientClick="return confirm('Are you sure you want to delete this Number?');"></asp:LinkButton>--%>

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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>