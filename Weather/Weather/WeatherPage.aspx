<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherPage.aspx.cs" Inherits="Weather.WeatherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="stylepage.css" type="text/css" rel="stylesheet" />  
    <style type="text/css">  
        .body{ padding-top:50px; padding-bottom:50px; }
    .left200{position:absolute; left:200px; padding-bottom:55px;
            top: 157px;
            height: 40px;
            width: 76px;
            margin-left: 0px;
            margin-bottom: 0px;
        }
    
        .auto-style2 {
            height: 26px;
        }
        .atuo-style1 {
            height: 47px;
            margin-left: 0px;
            margin-bottom: 37px;
        }
    
    </style> 
</head>
<body>
    <form id="form1" runat="server">
        <div id ="table">
        <h1>Weather Page</h1></div>
        <div id ="table"></div>
        <table class="atuo-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1"  runat="server" Text="City/Town"></asp:Label>
                </td>
                <td class="auto-style2"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td class="auto-style2">
                    <asp:Label ID="Label5"  runat="server" Text="Day"></asp:Label>
                </td>
                <td class="auto-style2"><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            </table>
        <table style="margin-left: 220px; margin-bottom: 0px"  >
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Day/Night"></asp:Label></td>
               
            </tr>
        </table>
         <table class="atuo-style1">
            <tr>
                <td>
                    <asp:Label ID="Label3"  runat="server" Text="Max Temperature"></asp:Label>
                </td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4"  runat="server" Text="Min Temperature"></asp:Label>
                </td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
             </table>
         <div id="button">  
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" BackColor="Yellow" />  
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:WeatherConnectionString %>" SelectCommand="SELECT * FROM [WeatherDataBase] WHERE ([city] = @city)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="ListBox1" Name="city" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
    </div>  
        <div id="sim"></div>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WeatherConnectionString %>" SelectCommand="SELECT * FROM [WeatherDataBase]"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatDirection="Horizontal">
            <ItemTemplate>
                city:
                <asp:Label ID="cityLabel" runat="server" Text='<%# Eval("city") %>' />
                <br />
                Day:
                <asp:Label ID="DayLabel" runat="server" Text='<%# Eval("Day") %>' />
                <br />
                daytempmax:
                <asp:Label ID="daytempmaxLabel" runat="server" Text='<%# Eval("daytempmax") %>' />
                <br />
                daytempmin:
                <asp:Label ID="daytempminLabel" runat="server" Text='<%# Eval("daytempmin") %>' />
                <br />
                nighttempmax:
                <asp:Label ID="nighttempmaxLabel" runat="server" Text='<%# Eval("nighttempmax") %>' />
                <br />
                nighttempmin:
                <asp:Label ID="nighttempminLabel" runat="server" Text='<%# Eval("nighttempmin") %>' />
<br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="city" DataValueField="city" ></asp:ListBox>
            <asp:Button ID="Button2" runat="server" Text="submit" OnClick="Button2_Click" BackColor="Yellow" style="height: 26px" />
        <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2">
            <ItemTemplate>
                city:
                <asp:Label ID="cityLabel" runat="server" Text='<%# Eval("city") %>' />
                <br />
                Day:
                <asp:Label ID="DayLabel" runat="server" Text='<%# Eval("Day") %>' />
                <br />
                daytempmax:
                <asp:Label ID="daytempmaxLabel" runat="server" Text='<%# Eval("daytempmax") %>' />
                <br />
                daytempmin:
                <asp:Label ID="daytempminLabel" runat="server" Text='<%# Eval("daytempmin") %>' />
                <br />
                nighttempmax:
                <asp:Label ID="nighttempmaxLabel" runat="server" Text='<%# Eval("nighttempmax") %>' />
                <br />
                nighttempmin:
                <asp:Label ID="nighttempminLabel" runat="server" Text='<%# Eval("nighttempmin") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        
    </form>
</body>
</html>
