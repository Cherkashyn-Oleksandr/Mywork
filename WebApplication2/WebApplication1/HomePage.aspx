<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload Item" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ItemsConnectionString %>" SelectCommand="SELECT * FROM [ItemsDataBase]"></asp:SqlDataSource> </br>
        <asp:Label ID="Label1" runat="server" Text="Find Item"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
        <asp:Button ID="Button4" runat="server" Text="Find" OnClick="Button4_Click" />
        </br>
        <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></br>
        <asp:Button ID="Button3" runat="server" Text="Buy" OnClick="Button3_Click" />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="125px" style="margin-bottom: 2px">
            <Fields>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            </Fields>
        </asp:DetailsView>
        
        
        
        
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        
        
        
        
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        
        
        
        
    </form>
</body>
</html>
