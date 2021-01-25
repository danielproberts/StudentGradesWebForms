<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IT391_Roberts_Unit7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Course: Math 100</h2>
    <h3>Instructor: Ms. Jones</h3>
    <p>
        Average Grade: <asp:TextBox ID="txtAverageGrade" runat="server"></asp:TextBox>
    </p>
    <p>
        Highest Grade: <asp:TextBox ID="txtHighestGrade" runat="server"></asp:TextBox>
    </p>
    <p>
        Lowest Grade: <asp:TextBox ID="txtLowestGrade" runat="server"></asp:TextBox>
    </p>
</asp:Content>
