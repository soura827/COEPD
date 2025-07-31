<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantExam.aspx.cs" Inherits="ParticipantExam" %>

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
                        Participant ReTake Exam
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-8 col-md-8">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Search
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-5">
                                        <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Participant
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:DropDownList ID="ddlParticipant" runat="server" Required="" AutoPostBack="true"
                                            OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Batch
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:Label ID="lblBatch" runat="server"></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Completed Exams
                                    </label>
                                    <div class="col-sm-10">
                                        <div class="table-responsive">
                                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="gv_RowCommand">
                                                <Columns>
                                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                                    <asp:BoundField HeaderText="Topic" DataField="Topic" />
                                                    <asp:BoundField HeaderText="Start Date" DataField="StartDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                                    <asp:BoundField HeaderText="End Date" DataField="EndDate" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                                    <asp:BoundField HeaderText="Time" DataField="ExamTime" />
                                                    <asp:TemplateField HeaderText="ReTake Exam" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lnkReTake" runat="server" Text="ReTake Exam" CommandName="cmdRemove"
                                                                CommandArgument='<%#Eval("ExamId")%>'></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <EmptyDataTemplate>
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
                        <div class="col-lg-4 col-md-4">
                            <div class="form-horizontal no-margin">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
