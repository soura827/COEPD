<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="JobAppliedSearch.aspx.cs" Inherits="Admin_JobAppliedSearch" %>

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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                          Jobs Applied participants List
                    </div>
                </div>
                
                <div class="widget-body">
                    <div class="row">
                         <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="100" placeholder="Partcipant Name, Email,ReferenceNo" OnTextChanged="txtParticipant_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                         <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtCompany" MaxLength="100" placeholder="Search By Company" OnTextChanged="txtCompany_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="100" placeholder="Search By Location" OnTextChanged="txtLocation_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                         
                        
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                      <div class="row"> 
                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                              <Columns>                                  
                                  <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                  <asp:BoundField HeaderText="Participant Name" DataField="Participant" />
                                  <asp:BoundField HeaderText="Applied Company" DataField="Company" />
                                  <asp:BoundField HeaderText="Applied Location" DataField="Location" />
                                   <asp:BoundField HeaderText="Applied On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                   <%--<asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ActivityId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ActivityId")%>' OnClientClick="return confirm('Are you sure you want to delete this Activity?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
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
</asp:Content>

