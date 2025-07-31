<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="HRQuestionBank.aspx.cs" Inherits="Participant_HRQuestionBank" %>

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
                            <asp:Label runat="server" ID="lblTitle"></asp:Label>
                        </div>

                    </div>
                    <div class="widget-body">
                        <asp:Literal runat="server" ID="ltlContent"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    <!--Row End -->
</asp:Content>

