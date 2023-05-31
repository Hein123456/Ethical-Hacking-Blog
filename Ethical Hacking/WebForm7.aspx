<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="Ethical_Hacking.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
         <table>
               <tr>
                   <td>
                       <h1>Staff Login</h1>
                   </td>
               </tr>
              <tr>
                  <td>

                      Username:
                      <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox"></asp:TextBox>

                  </td>
              </tr>
             <tr>
                 <td>

                     Surname:&nbsp;
                     <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBox"></asp:TextBox>

                 </td>
             </tr>
               <tr>
                   <td>
                       <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Login" Height="44px" OnClick="Button1_Click" Width="116px" />
                   
                   </td>
               </tr>
             
           </table>


       
    </form>
</body>
</html>
