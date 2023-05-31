<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ethical_Hacking.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Auth</title>
     <style type="text/css">
        .auto-style1 {
            background-color: #333333;
            border-style: none;
            cursor: text;
            display : flex;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
             <table>
               <tr>
                   <td>
                       <h1>This Website is strictly 18+</h1>
                   </td>
               </tr>
               <tr>
                   <td><p>
                       <asp:Label ID="Label1" runat="server" Text="Enter your birthdate:"></asp:Label>
                       </p>
                       <p>Year:
                           <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" CssClass="auto-style1" AutoPostBack="True" Height="27px"></asp:TextBox>
                       &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Button2" CssClass="auto-style1" runat="server" Text="Set Year" Height="44px" OnClick="Button2_Click" Width="116px" />
                       </p>
                       <p>
                           <asp:Calendar ID="Calendar1" runat="server" Height="397px" Width="491px" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" ShowGridLines="True"></asp:Calendar>
                       </p>
                      
                   </td>
               </tr>
               <tr>
                   <td><p>
                       <asp:Button ID="Button1" CssClass="auto-style1" runat="server" Text="Submit" Height="44px" OnClick="Button1_Click" Width="116px" />
                       </p>
                   </td>
               </tr>
               <tr>
                   <td>
                       &nbsp;</td>
               </tr>
           </table>


        </div>
    </form>
</body>
</html>
