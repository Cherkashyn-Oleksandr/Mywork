<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="DatabaseConnectivity.loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>  
    <link href="stylepage.css" type="text/css" rel="stylesheet" />  
    <style type="text/css">  
        .auto-style1 {  
            width : 100%;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div id="title">  
    <h1>REGISTER PAGE</h1>  
    </div>  
        <div id ="teble"></div>  
    <table class="auto-style1">  
        <tr>  
            <td>  
                <asp:Label ID="Label1" runat="server" Text="StudentName"></asp:Label></td>  
            <td>  
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>  
            <td>  
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="Label3" runat="server" Text="EmailId"></asp:Label></td>  
            <td>  
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label></td>  
            <td>  
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="Label5" runat="server" Text="College"></asp:Label></td>  
            <td>  
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>  
        </tr>  
    </table>  
    <div id="button">  
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" BackColor="Yellow" />  
    </div>  
        <div id="sim"></div>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegiConnectionString %>" SelectCommand="SELECT * FROM [RegisterDataBase]"></asp:SqlDataSource>  
          
        <div id="grid">  
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">  
                <AlternatingRowStyle BackColor="White" />  
                <Columns>  
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />  
                    <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />  
                    <asp:BoundField DataField="Passwords" HeaderText="Passwords" SortExpression="Passwords" />  
                    <asp:BoundField DataField="Emailid" HeaderText="Emailid" SortExpression="Emailid" />  
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />  
                    <asp:BoundField DataField="College" HeaderText="College" SortExpression="College" />  
                </Columns>  
                <EditRowStyle BackColor="#2461BF" />  
                <FooterStyle BackColor="#507CD1"  ForeColor="White"  Font-Bold="True" />  
                <HeaderStyle BackColor="#507CD1"  ForeColor="White"  Font-Bold="True" />  
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />  
                <RowStyle BackColor="#EFF3FB" />  
                <SelectedRowStyle BackColor="#D1DDF1"  ForeColor="#333333" Font-Bold="True" />  
                <SortedAscendingCellStyle BackColor="#F5F7FB" />  
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />  
                <SortedDescendingCellStyle BackColor="#E9EBEF" />  
                <SortedDescendingHeaderStyle BackColor="#4870BE" />  
            </asp:GridView>  
        </div>  
              
            <div id="last">  
            <h3>Developed by  
                      Oleksandr Cherkashyn</h3>  
        </div>  
    </form>  
    </body>  
</html> 
