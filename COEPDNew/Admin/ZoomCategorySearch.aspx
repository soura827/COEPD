<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ZoomCategorySearch.aspx.cs" Inherits="Admin_ZoomCategorySearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
      <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <!-- Row Start -->
    <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                Zoom Meeting Category
                            </div>
                        </div>

                        <div class="widget-body">
                            <div class="row">
                                
                                 <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtZoomCategory" MaxLength="500" placeholder="Zoom Category" OnTextChanged="txtZoomCategory_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                                 <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtFullname" MaxLength="500" placeholder="Search By Created By" OnTextChanged="txtFullname_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="textModified" MaxLength="500" placeholder="Search By Modified By" OnTextChanged="textModified_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            
                             <div class="col-lg-2 col-md-2">
                                <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" SkinID="addnew"  />
                             </div>   
                                </div>
                               <div>
                                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                            </div>
                            <div class="row">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" >
                                    <Columns>
                                        <asp:BoundField HeaderText="S.NO" DataField="SNo" />
                                  <asp:BoundField HeaderText="Zoom Meeting Category" DataField="ZoomMeetingCategory" />                                
                                  <%--<asp:BoundField HeaderText="Description" DataField="Description" />--%>
                                   <asp:BoundField HeaderText="Created By" DataField="Fullname" />
                                        <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                        <asp:BoundField HeaderText="Modified By" DataField="Employee" />
                                         <asp:BoundField HeaderText="Modified On" DataField="ModifiedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                  <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                  <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ZoommeetingCategoryId")%>'></asp:LinkButton>
                                       <%-- <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ZoomMeetingCategoryId")%>' OnClientClick="return confirm('Are you sure you want to delete this ActivityCategory?');"></asp:LinkButton>
                                    --%>
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


