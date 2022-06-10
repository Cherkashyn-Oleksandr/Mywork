<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItemPage.aspx.cs" Inherits="WebApplication1.AddItemPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server">  
       </asp:TextBox>  
            <br />
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server">  
       </asp:TextBox>  
       <br />   
                   
       <br />   
       <asp:Button ID="Button1" runat="server"  
       Text="Add" OnClick="Button1_Click" /> 
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="HomePage" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ItemsConnectionString %>" SelectCommand="SELECT * FROM [ItemsDataBase]"></asp:SqlDataSource>
    </form>
</body>
</html>
