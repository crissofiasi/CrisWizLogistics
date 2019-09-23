<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vkb.aspx.cs" Inherits="CrisWizLogistics.vkb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
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
    <asp:Literal ID="LiteralVKB" runat="server"></asp:Literal>
    <asp:CheckBox ID="CheckBox1" runat="server" OnInit="CheckBox1_Init" Text="vkb" />
    <br />
    <asp:Button ID="KB"  runat="server" Text="VKB" OnClick="KB_Click" />
    <asp:TextBox ID="keyboard" CssClass="keyboard" runat="server"></asp:TextBox>
</asp:Content>
