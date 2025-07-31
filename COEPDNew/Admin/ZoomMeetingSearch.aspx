<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ZoomMeetingSearch.aspx.cs" Inherits="Admin_ZoomMeetingSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Zoom Meeting
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Employee" AutoPostBack="true" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlZoommeetingCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlZoommeetingCategory_SelectedIndexChanged">
                                
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-1 col-lg-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>

                    </div>

                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="500" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>
                                      <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("ZoomMeetingId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                     <asp:BoundField HeaderText="ZoomMeetingId" DataField="ZoomMeetingValueId" />
                                    <asp:BoundField HeaderText="ZoomMeetingCategory" DataField="ZoomMeetingCategory" />
                                     <asp:BoundField HeaderText="HostEmployeeName" DataField="Employee" />
                                    <asp:BoundField HeaderText="URL" DataField="URL" />
                                    <asp:BoundField HeaderText="PassCode" DataField="PassCode" />
                                    <asp:BoundField HeaderText="ZoomMeetingDate" DataField="ZoomMeetingDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="ZoomMeetingStartTimeOn" DataField="ZoomMeetingStartTimeOn" DataFormatString="{0: hh:mm tt}" />
                                    <asp:BoundField HeaderText="ZoomMeetingEndTimeOn" DataField="ZoomMeetingEndTimeOn" DataFormatString="{0:  hh:mm tt}" />
                                    <asp:BoundField HeaderText="Batch" DataField="Batch" />
                                    <asp:BoundField HeaderText="IsBatchOnly" DataField="IsBatchOnly" />
                                   <asp:TemplateField HeaderText="View Meeting" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkJoinMeeting" runat="server" SkinID="Green" Text="JoinMeeting" CommandName="cmdAttend"
                                                CommandArgument='<%#Eval("ZoomMeetingId")%>' Visible='<%# (Boolean.Parse(Eval("IsZoomMeetingStarted").ToString())? false:true) %>'></asp:LinkButton>
                                           
                                             </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText="LinkMeetingEnded" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEndMeeting" runat="server" SkinID="Green" Text="EndZoomMeeting" CommandName="cmdEnded"
                                                CommandArgument='<%#Eval("ZoomMeetingId")%>' Visible='<%# (Boolean.Parse(Eval("IszoomMeetingEnded").ToString())? false:true) %>'></asp:LinkButton>
                                           
                                             </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText=" FeedBack" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkFeedBack" runat="server" SkinID="Orange" Text="FeedBack" CommandName="cmdFeedBack" EnableViewState="false"
                                                CommandArgument='<%#Eval("ZoomMeetingAttendanceId")%>' Visible='<%# (Boolean.Parse(Eval("IsFeedBackAdded").ToString())? false:true) %>'></asp:LinkButton>
                                           
                                             </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <div>
                                <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


