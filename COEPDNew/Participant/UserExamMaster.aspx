<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="UserExamMaster.aspx.cs" Inherits="UserExamMaster" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
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
                        Prep Exams List
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="row">
                            <div class="col-lg-1 col-md-1">
                                <h4>Category</h4>
                            </div>
                            <div class="col-lg-4 col-md-4">
                                <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                            <div class="col-lg-7 col-md-7">
                                &nbsp;
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <div class="row col-lg-offset-3">
                                <h4 style="color: tomato">
                                    <asp:Label ID="lblCount" runat="server"></asp:Label>
                                </h4>
                            </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:TemplateField HeaderText="Take Exam" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text="Exam Done" Visible="false"></asp:Label>
                                            <asp:LinkButton ID="lnkStart" runat="server" Text="Take Exam" CommandName="cmdStart"
                                                CommandArgument='<%#Eval("TopicId")%>'></asp:LinkButton>
                                            <asp:HiddenField ID="hdnStatusId" runat="server" Value='<%#Eval("StatusId")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate><%--This Template is used to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                        </div>
                        <div class="col-lg-6 col-md-6">

                            <div class="row col-lg-offset-3">
                                <h4>
                                    <asp:Label ID="lblCountfooter" runat="server" ForeColor="Tomato"></asp:Label>
                                </h4>
                            </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gvExam" runat="server" AutoGenerateColumns="False" Width="100%"
                                OnRowCommand="gvExam_RowCommand">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:BoundField HeaderText="Date" DataField="StartDate" DataFormatString="{0:dd MMM yyyy}"
                                        ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Start" DataField="StartDate" DataFormatString="{0:hh:mm tt}"
                                        ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="End" DataField="EndDate" DataFormatString="{0:hh:mm tt}"
                                        ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="%" DataField="MarksPersontage" />
                                   <%-- <asp:BoundField HeaderText="Time" DataField="ExamTime" />--%>
                                    <asp:TemplateField HeaderText="Review" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkReview" runat="server" Text="Review" CommandName="cmdReview"
                                                CommandArgument='<%#Eval("ExamId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate><%--This Template is used to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                            <div class="row">
                                <center>
                                    <h3 >Re-Take Requests History </h3>
                                </center>
                            </div>
                            <div class="table-responsive">
                            <asp:GridView ID="gvRetakeExam" runat="server" AutoGenerateColumns="False"
                                Width="100%" >
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                    <asp:BoundField HeaderText="Mentor Comments" DataField="UserComments" />
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# Eval("RetakeStatusId").ToString()=="0" ? "Pending": Eval("RetakeStatusId").ToString()=="1"?"Approved":"Rejected" %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Requested On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy hh:mm tt}"/>
                                </Columns>
                                <EmptyDataTemplate><%--This Template is used to display the message when no records find--%>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>