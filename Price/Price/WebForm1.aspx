<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Price.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="LoginPage"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Login"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 142px; margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 107px"></asp:TextBox>
        
        <asp:Button ID="Button1" runat="server" style="margin-left: 378px; margin-bottom: 0px" Text="Login" OnClick="Button1_Click" />
        
        <p>
            
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            
        </p>
        
        <p>
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </p>
        
    </form>
</body>
</html>
