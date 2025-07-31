<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Activity.aspx.cs" Inherits="Admin_Activity" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            var $txt = $('input[id$=FilterText]');
            var $ddl = $('select[id$=ddlActivityCategory]');
            var $items = $('select[id$=ddlActivityCategory] option');

            var $SubCtgry = $('select[id$=ddlActivitySubCategory]');
            var $Activity = $('input[id$=txtActivity]');
            //var $Description = $('input[id$=txtDescription]');

            $txt.keyup(function () {
                searchDdl($txt.val());
                $SubCtgry.val(0);
                $Activity.val('');
                $("#<%= txtDescription.ClientID %>").val("");
            });
 
            function searchDdl(item) {
                $ddl.empty();
                var exp = new RegExp(item, "i");
                var arr = $.grep($items, function (n) {
                                                        return exp.test($(n).text());
                                                      }
                                );
 
                if (arr.length > 0) {
                    $.each(arr, function() {
                                                $ddl.append(this);
                                                $ddl.get(0).selectedIndex = 0;
                                            }
                           );
                }
                else {

                    $ddl.append("<option>No Items Found</option>");

                }
            }
        });
    </script>

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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Activity Category <asp:Label runat="server" ID="CategoryStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                             <asp:DropDownList ID="ddlActivityCategory" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlActivityCategory_SelectedIndexChanged" ></asp:DropDownList>
                            </div>
                             <label class="col-sm-1 control-label" style="text-align: left"> Filter By Category  </label>                             
                             <div class="col-sm-3">
                                 <asp:TextBox ID="FilterText" runat="server" Placeholder="Filter By Category" ToolTip="Enter Text Here"></asp:TextBox>
                             </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Activity Subcategory <asp:Label runat="server" ID="SubcategoryStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlActivitySubCategory" runat="server" required="" AutoPostBack="true" ></asp:DropDownList>
                            </div>
                        </div>
                       <%--  <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Activity Mode Of Selection
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlmodeofselection" runat="server" AutoPostBack="true">
                                    <asp:ListItem   Value="0">Please Select Mode Of Selection</asp:ListItem>
                                    <asp:ListItem Value="1">Empolyee</asp:ListItem>
                                     <asp:ListItem Value="2">Participant</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>--%>
                          <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Activity <asp:Label runat="server" ID="ActivityStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtActivity" runat="server" MaxLength="5000" required="" OnTextChanged="txtActivity_TextChanged" AutoPostBack="true" ></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtDescription" runat="server" MaxLength="5000" Height="100" TextMode="MultiLine" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                         <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server"  Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                                 <asp:Button ID="btnreset" runat="server"  Text="Add New" OnClick="btreset_Click" UseSubmitBehavior="false"  />
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>