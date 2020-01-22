<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TouristHelp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/login.css" rel="stylesheet" />
    <script src="Scripts/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <section class="sign-in">
            <div class="login-container">
                <div class="signin-content">
                    <div class="signin-image">
                        <figure>
                            <img src="Images/signin-image.jpg" alt="sing up image">
                        </figure>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="signup-image-link" NavigateUrl="~/RegisterTourist.aspx">Create an account</asp:HyperLink>
                    </div>

                    <div class="signin-form">
                        <h2 class="form-title">Sign in</h2>
                        <form id="FormSignIn" class="register-form" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="tbEmail" runat="server" placeholder="Email Address"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="tbPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="form-group form-button">
                                <asp:Button ID="btnLogin" runat="server" Text="Log In" CssClass="form-submit" OnClick="btnLogin_Click" />
                            </div>
                            <br />
                            <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
                        </form>
                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>