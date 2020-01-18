﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TouristHelp.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Login/animate.css" rel="stylesheet" />
    <link href="Styles/Login/animsition.min.css" rel="stylesheet" />
    <link href="Styles/Login/daterangepicker.css" rel="stylesheet" />
    <link href="Styles/Login/font-awesome.min.css" rel="stylesheet" />
    <link href="Styles/Login/hamburgers.min.css" rel="stylesheet" />
    <link href="Styles/Login/icon-font.min.css" rel="stylesheet" />
    <link href="Styles/Login/main.css" rel="stylesheet" />
    <link href="Styles/Login/select2.min.css" rel="stylesheet" />
    <link href="Styles/Login/util.css" rel="stylesheet" />

    <script src="Scripts/animsition.min.js"></script>
    <script src="Scripts/select2.min.js"></script>
    <script src="Scripts/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="limiter">
            <div class="container-login100">
                <div class="wrap-login100">
                    <form class="login100-form validate-form">
                        <span class="login100-form-title p-b-34">Account Login
                        </span>

                        <div class="wrap-input100 rs1-wrap-input100 validate-input m-b-20" data-validate="Type user name">
                            <input id="first-name" class="input100" type="text" name="username" placeholder="User name">
                            <span class="focus-input100"></span>
                        </div>
                        <div class="wrap-input100 rs2-wrap-input100 validate-input m-b-20" data-validate="Type password">
                            <input class="input100" type="password" name="pass" placeholder="Password">
                            <span class="focus-input100"></span>
                        </div>

                        <div class="container-login100-form-btn">
                            <button class="login100-form-btn">
                                Sign in
                            </button>
                        </div>

                        <div class="w-full text-center p-t-27 p-b-239">
                            <span class="txt1">Forgot
                            </span>

                            <a href="#" class="txt2">User name / password?
                            </a>
                        </div>

                        <div class="w-full text-center">
                            <a href="#" class="txt3">Sign Up
                            </a>
                        </div>
                    </form>

                    <div class="login100-more" style="background-image: url('images/bg-01.jpg');"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>