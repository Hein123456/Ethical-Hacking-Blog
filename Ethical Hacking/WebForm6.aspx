<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Ethical_Hacking.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 30%;
        }
        .auto-style3 {
            height: 415px;
        }
        .auto-style5 {
            width: 21%;
        }
        .auto-style6 {
            width: 102%;
        }
        .auto-style7 {
            width: 28%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <header>
			<h1>Hacking Website</h1>
			 <div class="logo">
    
    <a href="#"> <asp:Image ID="Image1" runat="server" ImageUrl="~/logo-no-background.png" />
			</a>
    
  </div>
			<h1>Staff</h1>
           <p>

           </p>
		</header>
        <div style =
  "
    background-color: #1c1c1c;
    
    display: flex;
    ">
            <table>
                <tr>
                    <td class="auto-style3" colspan="4">

                        <asp:GridView ID="GridView1" runat="server" EmptyDataText="NULL" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <SelectedRowStyle BackColor="Gray" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" />
                        </asp:GridView>

                    </td>

                </tr>
                <tr>
                          <td>

                              <asp:Button ID="Button4" runat="server" Text="Back" CssClass ="Button" OnClick="Button4_Click" />

                          </td>
                          <td>

                              <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>

                          </td>
                          <td>

                              <asp:Button ID="Button5" runat="server" Text="Next" CssClass ="Button" OnClick="Button5_Click" />

                          </td>
                      </tr>
                <tr>
                    <td class="auto-style1">

                        Seatch:
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

                    </td>
                     <td class="auto-style5">

                         Insert:
                         <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />

                    </td>
                     <td class="auto-style7">

                         Update:
                         <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />

                    </td>
                     <td class="auto-style6">

                         Delete:
                         <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />

                    </td>
                </tr>
               <tr>
                   <td>
                       <h1>Info</h1>
                   </td>
               </tr>
                 <tr>
                   <td><p>ID:</p>
                      
                       <asp:TextBox  ID="TextBox2" runat="server" CssClass="TextBox" Height="43px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td><p>Username:</p>
                      
                       <asp:TextBox  ID="TextBox3" runat="server" CssClass="TextBox" Height="43px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td><p>Comment:</p>
                       <asp:TextBox  ID="TextBox4" runat="server"  CssClass="TextBox" Height="124px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td>
                      <p>Date:</p>
                       <asp:TextBox  ID="TextBox5" runat="server"  CssClass="TextBox" Height="124px" ForeColor="White"></asp:TextBox>
                   </td>
               </tr>
            </table>

            </div>

    </form>
</body>
</html>
