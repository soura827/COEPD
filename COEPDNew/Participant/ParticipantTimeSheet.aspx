<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="ParticipantTimeSheet.aspx.cs" Inherits="ParticipantTimeSheet" %>
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
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-12 col-md-12">
                            <div class="form-horizontal no-margin">
                                
                                <div class="form-group">
                                    <label class="col-sm-2 ">
                                        Start Time
                                    </label>
                                    <div class="col-sm-10">
                                        <div class="row">
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtsHours" runat="server" type="number" Required="" Placeholder="HH"
                                                    Width="70px" min="1" max="12"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtsmints" runat="server" type="number" Required="" Placeholder="MM"
                                                    Width="70px" min="0" max="59"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-2 col-md-2">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 ">
                                        End Time
                                    </label>
                                    <div class="col-sm-10">
                                        <div class="row">
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtEHours" runat="server" type="number" Placeholder="HH" Width="70px"  min="1" max="12"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-1 col-md-1">
                                                <asp:TextBox ID="txtEmints" runat="server" type="number" Placeholder="MM" Width="70px" min="0" max="59"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-2 col-md-2">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="Description" class="col-md-2">
                                        Note    
                                    </label>
                                    <div class="col-sm-10">
                                        <asp:TextBox ID="txtNote" TextMode="MultiLine" Height="200px" runat="server" Required="" ></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                        <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                            OnClick="btnCancel_Click" CausesValidation="false" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>