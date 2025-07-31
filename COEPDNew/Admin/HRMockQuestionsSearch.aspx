<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HRMockQuestionsSearch.aspx.cs" Inherits="Admin_HRMockQuestionsSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                     HRMock Questions
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3">
                            <asp:TextBox runat="server" ID="txtQuestions" MaxLength="500" placeholder="Question Names" AutoPostBack="true" OnTextChanged="txtQuestions_TextChanged"></asp:TextBox>
                        </div>
                        
                        
                          <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                        <div class="row">
                        &nbsp;
                         </div>
                     <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!"  >
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />                                    
                                    <asp:BoundField HeaderText="QuestionName" DataField="QuestionName" />
                                    <%--<asp:BoundField HeaderText="Answer" DataField="Answer" />--%>
                                   <%-- <asp:BoundField HeaderText="Rating" DataField ="Remarks" />
                                    <asp:BoundField HeaderText="Remarks" DataField="Rating" />--%>
                                   <%-- <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="View" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("HRMockQuestionsId")%>'></asp:LinkButton>
                                   
                                    </ItemTemplate>
                                </asp:TemplateField> --%>      
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                             <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                             </div>
                        </div>
                    </div>
            </div>
        
    </div>
  </div>
        </div>
</asp:Content>

