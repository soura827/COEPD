<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true" CodeFile="ExamCategoryAssignmentSearch.aspx.cs" Inherits="ExamCategoryAssignmentSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" /> 
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
      <div class="col-lg-12 col-md-12">
         <div class="widget">
                <div class="widget-header">
                    <div class="title">
                       Exam Categories
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row"> 
                        <div class="col-lg-12 col-md-12">                                                         
                                <div class="col-lg-1 col-md-1">
                                    <asp:Label ID="lblParticipant" runat="server" Text="Participant" Font-Bold="true" Font-Size="Small"></asp:Label>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:TextBox ID="txtSearch" runat="server" required="" ></asp:TextBox>
                                </div>
                                <div class="col-lg-1 col-md-1">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search"  OnClick="btnSearch_Click" />
                                </div>
                                <div class="col-lg-2 col-md-2">
                                 <b>Select Participant </b>
                                </div>
                                <div class="col-lg-2 col-md-2">
                                    <asp:DropDownList ID="ddlParticipant" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged">
                                </asp:DropDownList>                              
                                </div>
                                <div class="col-lg-4 col-md-4">
                                </div>
                          <%--  <div class="col-lg-5 col-md-5">
                              <div class="col-lg-4 col-md-4">
                                  <strong> Exam Categories </strong>
                               </div>
                                <div class="col-lg-8 col-md-8">
                                    <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                               </div>
                           </div>--%>                                                   
                        </div>  
                    </div> 
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                     <center>
                           <asp:Button ID="btnGoToParticipant" runat="server" OnClick="btnGoToParticipant_Click" Text="Back to Participants Page" UseSubmitBehavior="false" />
                          </center>
                    </div> 
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">
                            Available ExamCategories </h4>
                        </div>
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">
                                Assigned ExamCategories</h4>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="table-responsive">
                            <asp:GridView ID="gvUser" runat="server" OnRowCommand="gvUser_RowCommand" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="ExamCategory Name" DataField="Category" />
                                    <asp:TemplateField HeaderText="Add to ExamCategory" ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="Add to ExamCategory >>" CommandName="cmdAdd"
                                                CssClass="btn btn-primary" CommandArgument='<%#Eval("CategoryId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate> <%--This Template is uded to display the message when no records find--%>

                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                        </div>
                        <div class="col-lg-6 col-md-6">                            
                            <div class="table-responsive">                                  
                            <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" AutoGenerateColumns="False"
                                Width="100%">
                                <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="ExamCategory Name" DataField="Category" />                                 
                                    <asp:TemplateField HeaderText="Remove from ExamCategory " ItemStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkSend" runat="server" Text="<< Remove from ExamCategory" CommandName="cmdRemove"
                                                CssClass="btn btn-info" CommandArgument='<%#Eval("CategoryId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>                     
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                                <EmptyDataTemplate><%--This Template is uded to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>    
                                </div>                      
                        </div>                       
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>                                    
                 </div>
          </div>                                       
      </div>
    </div>
    <!-- Row End -->
</asp:Content>