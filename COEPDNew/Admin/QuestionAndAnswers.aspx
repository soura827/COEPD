<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" 
    CodeFile="QuestionAndAnswers.aspx.cs" Inherits="QuestionAndAnswers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Answers
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                         <div class="col-md-3 col-lg-3">
                            <asp:DropDownList runat="server" ID="ddlCategory" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3 col-lg-3">
                            <asp:DropDownList runat="server" ID="ddlTopic" AutoPostBack="true" OnSelectedIndexChanged="ddlTopic_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3 col-lg-3">
                            <asp:DropDownList runat="server" ID="ddlQuestion" AutoPostBack="true" OnSelectedIndexChanged="ddlQuestion_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1 pull-right">
                            <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" CausesValidation="false" Text="Download" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Question" DataField="Question" />
                                <%--<asp:BoundField HeaderText="Hint" DataField="Description" />--%>
                                <asp:BoundField HeaderText="Answer1" DataField="Answer1"  />
                                <asp:BoundField HeaderText="Marks" DataField="AnswerMarks1" DataFormatString="{0:0}" />
                                <asp:BoundField HeaderText="Answer2" DataField="Answer2" />
                                <asp:BoundField HeaderText="Marks" DataField="AnswerMarks2" DataFormatString="{0:0}" />
                                <asp:BoundField HeaderText="Answer3" DataField="Answer3" />
                                <asp:BoundField HeaderText="Marks" DataField="AnswerMarks3" DataFormatString="{0:0}" />
                                <asp:BoundField HeaderText="Answer4" DataField="Answer4" />
                                <asp:BoundField HeaderText="Marks" DataField="AnswerMarks4" DataFormatString="{0:0}" />
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
    </div>
    <!-- Row End -->
</asp:Content>

