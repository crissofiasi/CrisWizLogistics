﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryBrut1.aspx.cs" Inherits="CrisWizLogistics.DeliveryBrut1" %>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Delivery1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Pregatire livrare brut</a></li>                
            </ul>
        </div>
    </div>
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


</asp:Content>
