<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TouristHelp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/login.css" rel="stylesheet" />
    <script src="Scripts/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <section class="signup">
            <div class="login-container">
                <div class="signup-content">
                    <div class="signup-form">
                        <h2 class="form-title">Sign up</h2>
                        <form class="register-form" id="FormRegister" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="tbName" runat="server" placeholder="Your Name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="tbEmail" runat="server" placeholder="Your Email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblNation" runat="server" Text="Nationality: "></asp:Label>
                                <asp:DropDownList ID="ddlNation" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="tbRepeatPass" runat="server" TextMode="Password" placeholder="Repeat Password"></asp:TextBox>
                            </div>
                            <div class="form-group form-button">
                                <asp:Button ID="btnSignup" runat="server" Text="Register" CssClass="form-submit" OnClick="btnSignup_Click" />
                            </div>
                        </form>
                    </div>
                    <div class="signup-image">
                        <figure><img src="Images/signup-image.jpg" alt="sign up image"></figure>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="signup-image-link" NavigateUrl="~/Login.aspx">I am already a user</asp:HyperLink>
                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
