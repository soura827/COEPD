<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ActivitySubCategory.aspx.cs" Inherits="Admin_ActivitySubCategory" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            var $txt = $('input[id$=FilterText]');
            var $ddl = $('select[id$=ddlActivityCategory]');
            var $items = $('select[id$=ddlActivityCategory] option');
            var $SubCtgry = $('input[id$=txtActivitysubCategory]');
            //var $Description = $('input[id$=txtDescription]');
 
            $txt.keyup(function () {
                searchDdl($txt.val());
                $SubCtgry.val('');
                $("#<%= txtDescription.ClientID %>").val("");
                //$Description.val('');
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

    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script src="Scripts/jquery.searchabledropdown-1.0.8.min.js" type="text/javascript"></script>
    <script type="text/javascript">
 $(document).ready(function () {
     $("ddlActivityCategory").searchable({
      maxListSize: 200, // if list size are less than maxListSize, show them all
      maxMultiMatch: 300, // how many matching entries should be displayed
      exactMatch: false, // Exact matching on search
      wildcards: true, // Support for wildcard characters (*, ?)
      ignoreCase: true, // Ignore case sensitivity
      latency: 200, // how many millis to wait until starting search
      warnMultiMatch: 'top {0} matches ...',
      warnNoMatch: 'no matches ...',
      zIndex: 'auto'
          });
       });

    </script>--%>

<%--    <script type = "text/javascript">
    var ddlText, ddlValue, ddl, lblMesg;
    function CacheItems() {
        ddlText = new Array();
        ddlValue = new Array();
        ddl = document.getElementById("<%=ddlActivityCategory.ClientID %>");
      
        for (var i = 0; i < ddl.options.length; i++) {
            ddlText[ddlText.length] = ddl.options[i].text;
            ddlValue[ddlValue.length] = ddl.options[i].value;
        }
    }
    window.onload = CacheItems;
    
    function FilterItems(value) {
        ddl.options.length = 0;
        for (var i = 0; i < ddlText.length; i++) {
            if (ddlText[i].toLowerCase().indexOf(value) != -1) {
                AddItem(ddlText[i], ddlValue[i]);
            }
        }
        lblMesg.innerHTML = ddl.options.length + " item(s) found.";
        if (ddl.options.length == 0) {
            AddItem("No item found.", "");
        }
    }
    
    function AddItem(text, value) {
        var opt = document.createElement("option");
        opt.text = text;
        opt.value = value;
        ddl.options.add(opt);
    }
</script>--%>
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
                            <%-- <label class="col-sm-2 control-label">
                                ActivityCategorySearch
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtActivityCategorySearch" runat="server" MaxLength="5000"  Required="" OnTextChanged="txtActivityCategorySearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>--%>
                            <label class="col-sm-2 control-label">
                                Activity Category <asp:Label runat="server" ID="star" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                             <asp:DropDownList ID="ddlActivityCategory" runat="server" required="" AutoPostBack="true">
                             </asp:DropDownList>
                            </div>
                             <label class="col-sm-1 control-label" style="text-align: left"> Filter By Category  </label>                             
                             <div class="col-sm-3">
                                 <asp:TextBox ID="FilterText" runat="server" Placeholder="Filter By Category" ToolTip="Enter Text Here"></asp:TextBox>
                             </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Activity Subcategory <asp:Label runat="server" ID="SubcagegoryStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label> 
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtActivitysubCategory" runat="server" MaxLength="5000" required=""    OnTextChanged="txtActivitysubCategory_TextChanged" AutoPostBack="true"></asp:TextBox>
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
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" onclick="btnCancel_Click"/>
                                <asp:Button ID="btnreset" runat="server"  Text="Add New" OnClick="btnreset_Click" UseSubmitBehavior="false"/>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>