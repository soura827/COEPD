<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="RunExam.aspx.cs" Inherits="Admin_RunExam" %>
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>-&nbsp;
                          Category Name: <asp:Label ID="lblcategory" runat="server" Font-Bold="true"></asp:Label> &nbsp;-&nbsp;
                          Topic Name: <asp:Label ID="lblTopic" runat="server" Font-Bold="true"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 text-right">
                                Question
                            </label>
                            <div class="col-sm-10 text-info">
                                <asp:Label ID="lblQuestion" runat="server" Font-Bold="true"></asp:Label>
                                  <asp:Label ID="lblTotalQuestions" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                                 <asp:Label ID="lblCorrectAnswers" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                                <asp:Label ID="lblMarksPersontage" runat="server" Font-Bold="true" Visible="false"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 text-right">
                                &nbsp;
                            </label>
                            <div class="col-sm-10 text-info">
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 text-right">
                                Answers
                            </label>
                            <div class="col-sm-10">
                                <asp:RadioButtonList ID="rdAnswer" runat="server">
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="BtnPrev" runat="server" OnClick="BtnPrev_Click" Text="Previous" Width="100px" />&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnNext" runat="server" OnClick="BtnNext_Click" Text="Next" Width="100px" />&nbsp;
                                <asp:Button ID="BtnFinish" runat="server" OnClick="BtnFinish_Click" Text="Finish"
                                    Width="100px" Visible="false" />&nbsp;
                            </div>
                        </div>                       
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

