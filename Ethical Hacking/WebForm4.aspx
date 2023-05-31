<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Ethical_Hacking.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Linux Basics</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
		<h1>Linux Basics</h1>
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

	
		<section>
			<h2>Linux Basics</h2>
			<p>In this section, you will learn the basics of using Linux operating system.</p>
			<ul>
				<li>Introduction to Linux</li>
				<li><a href="#InstallingLinux">Installing Linux</a></li>
				<li>File System Navigation and Manipulation</li>
				<li>Managing Users and Permissions</li>
				<li>Installing and Updating Software Packages</li>
				<li>System Monitoring and Troubleshooting</li>
			</ul>
		</section>
		<section id="InstallingLinux">
			 <h2 >Installing Linux</h2>
			<p>Welcome to the world of virtual machines and Kali Linux! In this section, you'll discover how to set up and run a virtual machine, along with a step-by-step guide on installing Kali Linux. With virtualization, you can run multiple operating systems on a single machine without affecting the host system. And Kali Linux, a popular penetration testing and security auditing operating system, offers a wide range of tools for security professionals and enthusiasts. So, let's get started on this exciting journey!</p>
			<p></p>
			<ol>
				<li><a href="https://www.virtualbox.org/wiki/Downloads"> Install VirtualBox</a>
				<ul>
					<li>
						<p>To get started, ensure that you have the most up-to-date VirtualBox platform packages downloaded onto your computer.</p>
					</li>
				</ul>

				</li>
				<li><a href="https://www.kali.org/get-kali/#kali-virtual-machines">Installing Kali Linux</a>
					<ul>
					<li>
						<p>If you're planning to install Kali in a virtual environment, I have a time-saving tip for you. Instead of downloading the Kali ISO file, you can simply download the pre-configured Kali virtual machine for VirtualBox. This way, you can avoid the hassle of setting up Kali from scratch and get started with your virtual environment right away.</p>
					</li>
				</ul>
				</li>

				<li>Set up Kali in a virtualized environment
						<ol>
							<li>Open VirtualBox and go to "Machine" and select "New".</li>
							<li>Give your new system a name and select the Kali virtual machine file that was previously downloaded.</li>
							<li>Change the type to "Linux" and select the version according to your processor's architecture.</li>
							<li>Next, select the amount of RAM you would like to dedicate to your virtual machine (2GB of RAM is recommended).</li>
							<li>Select the amount of cores you would like to dedicate (1 processor is recommended), and then check "Enable EFI".</li>
							<li>Finally, create a virtual hard disk with a recommended size of 25GB. Click "Next" and then "Finish".</li>
							
						</ol>
					<p>By following these steps, you'll be able to set up Kali in a virtualized environment without having to download the ISO file separately. This will save you a lot of time and effort.</p>
				</li>
				<li>Managing Users and Permissions</li>
				<li>Installing and Updating Software Packages</li>
				<li>System Monitoring and Troubleshooting</li>
			</ol>
		</section>
	

	<footer>
		<p>&copy; 2023 Hacking Website. All rights reserved.</p>
	</footer>
    </form>
</body>
</html>
