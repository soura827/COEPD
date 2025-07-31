<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="NurturingRevisionSearch.aspx.cs" Inherits="Participant_NurturingRevisionSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Nurturing Revision Report
                    </div>
                </div>

                <div class="widget-body">
                     <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Approved" Value="True"></asp:ListItem>
                                 <asp:ListItem Text="Pending/Evaluated" Value="False"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                         <div class="col-md-2 col-lg-2">
                             <asp:Button ID="GoToExams" runat="server" Text="Click To Browse All Exams" OnClick="GoToExams_Click" />
                         </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="gv_PageIndexChanging" PageSize="30" AllowPaging="true">
                                 <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="Sno" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" />
                                    <asp:BoundField HeaderText="ExamId" DataField="ExamId" />
                                    <asp:BoundField HeaderText="Category" DataField="Category" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:BoundField HeaderText="TotalQuestions" DataField="TotalQuestions" />
                                    <asp:BoundField HeaderText="CorrectAnswers" DataField="CorrectAnswers" />
                                    <asp:BoundField HeaderText="%" DataField="MarksPersontage" />
                                    <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                   <%-- <asp:BoundField HeaderText="StartDate" DataField="StartDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Start Time" DataField="StartTime" DataFormatString="{0:hh:mm tt}" />
                                    <asp:TemplateField HeaderText="End Time">
                                        <ItemTemplate>
                                            <%#Eval("EndTime", "{0:hh:mm tt}") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Duration">
                                        <ItemTemplate>
                                            <%#Eval("Duration", "{0:hh:mm tt}") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField HeaderText="Exam Retake Count" DataField="RetakeExamCount" />--%>
                                </Columns>
                                <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" Font-Size="Large" />
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                        </div>
                    </div>
                     <br />

                    <div class="row">
                      <div class="col-sm-offset-5 col-sm-10">
                           <asp:Button runat="server" ID="btnBack" Text="Back To Dashboard" OnClick="btnBack_Click" />
                      </div> 
                        </div>
                <br />
                </div>
            </div>
        </div>
        </div>
</asp:Content>

