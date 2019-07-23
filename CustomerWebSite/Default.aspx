<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Username&nbsp;
        <asp:TextBox ID="txtUsername" runat="server" Height="24px" Width="139px"></asp:TextBox>
        <br />
        <br />
        Password<asp:TextBox ID="txtPassword" runat="server" Height="21px" style="margin-left: 8px" Width="143px"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="lblMessage"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
