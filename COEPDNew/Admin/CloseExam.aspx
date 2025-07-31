<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CloseExam.aspx.cs" Inherits="Admin_CloseExam" %>
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
                        Online Exam Results-
                         Category Name: <asp:Label ID="lblcategory" runat="server" Font-Bold="true"></asp:Label> &nbsp;-&nbsp;
                         Topic Name: <asp:Label ID="lblTopic" runat="server" Font-Bold="true"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" ShowHeader="false">
                            <Columns>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Question" DataField="Question" />
                                <asp:BoundField HeaderText="Marks" DataField="Marks" />
                            </Columns>
                        </asp:GridView>
                            </div>
                    </div>
                    <div class="row">
                        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
                        <asp:Label ID="lblMarks" runat="server"></asp:Label>
                    </div>
                    <div class="row text-center">
                        <h1>
                            Thank You</h1>
                    </div>
                    <div>
                        <center>
                            <asp:Button ID="btnCancel" runat="server" Text="Back to Exams" OnClick="btnCancel_Click" />
                        </center>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

