<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Ethical_Hacking.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hacking Website</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <header>
			<h1>Hacking Website</h1>
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
	  
  </ul>
</nav>
		</header>
		<main>
			<section>
				<h2>Capture the Flag (CTF) Hacking Challenge</h2>
				Capture the Flag (CTF) hacking challenges are a type of cybersecurity competition where participants are tasked with finding vulnerabilities and exploiting them to gain access to a target system or steal information. The goal is to find hidden "flags," which are strings of text that are hidden in the system, and submit them to score points.

<p>These challenges are often used as a way to test and improve the skills of cybersecurity professionals, as well as to train individuals interested in learning more about cybersecurity. CTF hacking challenges can be designed for a wide range of skill levels, from beginner to advanced, and can cover a variety of topics such as web application security, network security, reverse engineering, cryptography, and more.</p>
				<a href="CTF.aspx" class="btn">Start the CTF Challenge</a>
			</section>
			<section>
				<h2>Documentation of IT Projects</h2>
				<ul>
					<li><a href="#">Project 1</a></li>
					<li><a href="#">Project 2</a></li>
					<li><a href="#">Project 3</a></li>
				</ul>
			</section>
			<section>
				<h2>Tutorials for Hacking Subjects</h2>
				<ul>
					<li><a href="#">Tutorial 1</a></li>
					<li><a href="#">Tutorial 2</a></li>
					<li><a href="#">Tutorial 3</a></li>
				</ul>
			</section>
		</main>
              <footer>
                  <p>&copy; 2023 Hacking Website</p>
              </footer>
    </form>
</body>
</html>
