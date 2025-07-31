<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="StartExam.aspx.cs" Inherits="StartExam" %>
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
                         <asp:Label ID="lblTitle" runat="server"></asp:Label>
                          Category Name:
                        <asp:Label ID="lblCategory" runat="server" Font-Bold="true"></asp:Label>
                                &nbsp;-&nbsp;
                          Topic Name:
                        <asp:Label ID="lblTopic" runat="server" Font-Bold="true"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-4 text-center">
                                <br />
                                <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Start Exam"
                                    Width="100px" />
                            </label>
                            <div class="col-sm-8">
                                <div>
                                    <b>Welcome to COEPD...</b>
                                    <ul>
                                        <li>Instructions for online exam</li>
                                        <li>1. Please use this practice exam to become comfortable with answering exam questions
                                            with your mouse.</li>
                                        <li>2. For each exam item select the answer that best answers the question.</li>
                                        <li>3. You will do this by moving your cursor to the circle by your answer choice and
                                            then left clicking to fill in the circle.</li>
                                        <li>4. Once your choice has been highlighted, click "Next" to go on to the next question.</li>
                                        <li>5. At the end of the exam you will be allowed to review all questions and answers
                                            before final submission.</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
    <div class="box-theme">
        <div class="box-title">
            <div class="box-head">
            </div>
            <div class="box-button">
            </div>
        </div>
        <div class="panel-body">
        </div>
    </div>
</asp:Content>