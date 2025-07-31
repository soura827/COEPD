<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TermsConditions.aspx.cs" Inherits="Participant_TermsConditions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <asp:Literal ID="lilcontent" runat="server"></asp:Literal>
                    <div class="row">
                    <div class="col-sm-1 col-md-1">
                    <asp:CheckBox ID="chkTermsAccepted" runat="server" AutoPostBack="true" Font-Size="Large" />
                        </div>
                    <div class="col-md-5">
                  <p style="color:red; font-size:large">  <strong>I understood and agree to the above terms and conditions.</strong></p>
                    </div>
                    <div class="col-sm-1 col-md-1">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
