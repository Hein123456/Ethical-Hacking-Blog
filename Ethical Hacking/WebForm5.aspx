<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Ethical_Hacking.WebForm5" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comments</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 48%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                     <header>
			<h1>Q&A</h1>
			 <div class="logo">
    
      <a href="#">&nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="~/logo-no-background.png" />
			</a>
    
  </div>
			<nav class="main-nav">
  <ul>
    <li><a href="WebForm2.aspx">Home</a></li>
    <li><a href="WebForm3.aspx">CTF</a>
      <ul>
        <li><a href="WebForm4.aspx">Linux Basics</a></li>
      </ul>
    </li>
	   <li><a href="WebForm5.aspx">Q&A</a></li>
  </ul>
</nav>
		</header>
          
      
              <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
           <table>
               <tr>
                   <td>
                       <h1>Ask A Question</h1>
                   </td>
               </tr>
               <tr>
                   <td><p>Username:</p>
                      
                       <asp:TextBox  ID="TextBox1" runat="server" CssClass="TextBox" Height="43px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td><p>Comment:</p>
                       <asp:TextBox  ID="TextBox2" runat="server"  CssClass="TextBox" Height="124px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Post" OnClick="Button1_Click" />
                   </td>
               </tr>
           </table>
                  </div>
          <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
              <table>
                  <tr>
                      <td>

                          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                      </td>
                      <td>

                          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">

                          <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBox" Height="75px" Width="1259px" ForeColor="White" ReadOnly="True"></asp:TextBox>

                      </td>
                  </tr>
              </table>
              </div>
         <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
              <table>
                  <tr>
                      <td>

                          <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                      </td>
                      <td>

                          <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">

                          <asp:TextBox ID="TextBox4" runat="server" CssClass="TextBox" Height="75px" Width="1259px" ForeColor="White" ReadOnly="True"></asp:TextBox>

                      </td>
                  </tr>
              </table>
              </div>
         <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
              <table>
                  <tr>
                      <td>

                          <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                      </td>
                      <td>

                          <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>

                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">

                          <asp:TextBox ID="TextBox5" runat="server" CssClass="TextBox" Height="75px" Width="1259px" ForeColor="White" ReadOnly="True"></asp:TextBox>

                      </td>
                  </tr>
              </table>
              </div>
         <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
              <table>
                  <tr>
                      <td>

                          <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                      </td>
                      <td>

                          <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">

                          <asp:TextBox ID="TextBox6" runat="server" CssClass="TextBox" Height="75px" Width="1259px" ForeColor="White" ReadOnly="True"></asp:TextBox>

                      </td>
                  </tr>
              </table>
              </div>
         <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
              <table>
                  <tr>
                      <td>

                          <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                      </td>
                      <td>

                          <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>

                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">

                          <asp:TextBox ID="TextBox7" runat="server" CssClass="TextBox" Height="75px" Width="1259px" ForeColor="White" ReadOnly="True"></asp:TextBox>

                      </td>
                  </tr>
              </table>
              </div>

              <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
                  <table>
                      <tr>
                          <td class="auto-style2">

                              <asp:Button ID="Button2" runat="server" Text="Back" CssClass ="Button" OnClick="Button2_Click" />

                          </td>
                          <td>

                              <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>

                          </td>
                          <td>

                              <asp:Button ID="Button3" runat="server" Text="Next" CssClass ="Button" OnClick="Button3_Click" />

                          </td>
                      </tr>
                  </table>
                  </div>
              <footer>
                  <p>&copy; 2023 Hacking Website</p>
              </footer>
    </form>
</body>
</html>
