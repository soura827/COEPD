<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ErrorMessage.ascx.cs"
    Inherits="Controls_ErrorMessage" %>
<style type="text/css">
    .errorMessage
    {
        color: red;
        font-weight: bold;
        font-size: 13px;
    }
</style>
<div class="errorMessage">
    <asp:Label ID="lblFormMessage" runat="server"></asp:Label>
</div>
