<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ExamReview.aspx.cs" Inherits="Admin_ExamReview" %>
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
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Exam Review - Only Wrong Answers
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-9 col-md-9">
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" ShowFooter="true">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Question" DataField="Question" ItemStyle-Width="300px" />
                                    <asp:TemplateField HeaderText="Your Answer" ItemStyle-Width="200px">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnMarks" runat="server" Value='<%#Eval("Marks")%>' />
                                            <asp:Label ID="lblAnswer" runat="server" Text='<%#Eval("Answer")%>' Visible='<%# (bool)Eval("IsChecked")%>'></asp:Label>
                                            <%--                            <asp:Label ID="lblCorrect" runat="server" Text='<%#Eval("Marks").ToString() == "0.00" ? "Wrong" : "Correct"%>'
                                Visible='<%# (bool)Eval("IsChecked")%>'></asp:Label>
                                            --%>
                                        </ItemTemplate>
                                         <%--<FooterTemplate>
                                            <asp:Label ID="lblTotalMarks" runat="server"></asp:Label>
                                        </FooterTemplate>--%>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Hint" DataField="Description" ItemStyle-Width="300px" />
                                    <%--<asp:TemplateField HeaderText="Correct Answer" ItemStyle-Width="200px">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCorrectAnswer" runat="server" Text='<%#Eval("CorrentAnswer")%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                               </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gvHistory" runat="server" AutoGenerateColumns="False" Width="100%"
                                ShowHeader="false">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Question" DataField="Question" />
                                    <asp:BoundField HeaderText="Marks" DataField="Marks" />
                                </Columns>
                            </asp:GridView>
                                </div>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <div class="widget" id="divRetakeExam" runat="server">
                                <div class="form-horizontal no-margin">
                                    <div class="widget-header">
                                        <div class="title">
                                            ReTake Exam Request
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-12">
                                            <asp:TextBox ID="txtdiscription" runat="server" required="" TextMode="MultiLine" Height="200px"
                                                placeholder="Enter Reson For Retake Exam">
                                            </asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-offset-3 col-sm-9">
                                            <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Send Request" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <asp:Label ID="lblretake" runat="server" Visible="False" Font-Size="Large"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <center>
                            <asp:Button ID="btnCancel" runat="server" Text="Back to Exams" OnClick="btnCancel_Click"
                                UseSubmitBehavior="false" />
                            &nbsp;
                        </center>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="col-lg-2">
                        &nbsp;
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

