<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="GSuitSearch.aspx.cs" Inherits="Admin_GSuitSearch" %>
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
                                GSuit Email
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="row">
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtGSuitEmail" MaxLength="500" placeholder="Search By Email" OnTextChanged="txtGSuitEmail_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div> 
                                <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlIsCreated" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtGSuitEmail_TextChanged">
                                        <asp:ListItem Text="Active Emails" Value="True"></asp:ListItem>
                                        <asp:ListItem Text="InActive Emails" Value="False"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-2 col-lg-2">
                                    <asp:DropDownList ID="ddlIsEmailAssigned" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtGSuitEmail_TextChanged" >
                                        <asp:ListItem Text="Unassigned Emails" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Assigned Emails" Value="True"></asp:ListItem>
                                        
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtCreatedName" MaxLength="500" placeholder="Search By Created Name" OnTextChanged="txtGSuitEmail_TextChanged" AutoPostBack="true" ></asp:TextBox>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtModifiedName" MaxLength="500" placeholder="Search By Modified Name" OnTextChanged="txtGSuitEmail_TextChanged" AutoPostBack="true" ></asp:TextBox>
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
                                         <asp:BoundField HeaderText="GSuit Email" DataField="GSuitEmail" />
                                         <asp:TemplateField HeaderText="Email Status">
                                            <ItemTemplate>
                                                <%# (Boolean.Parse(Eval("IsCreated").ToString()) ? "Created" : "Not Created" )%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                         <asp:BoundField HeaderText="Date Of Creation" DataField="DateOfCreation" DataFormatString="{0: dd MMM yyyy}" />        
                                         <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                         <asp:BoundField HeaderText="Created By" DataField="CreatedName" />
                                         <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                          <asp:BoundField HeaderText="Modified By" DataField="ModifiedName" />
                                         <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                             <ItemTemplate>
                                                 <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("GSuitEmailId")%>'></asp:LinkButton>
                                                 <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("GSuitEmailId")%>' OnClientClick="return confirm('Are you sure you want to delete this Number?');"></asp:LinkButton>--%>

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

