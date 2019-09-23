<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CrisWizLogistics.About" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/About" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Info</a></li>
                <li id="tab3"><a runat="server" href="~/Contact" onfocus="tab3.style.backgroundColor = '#a4d4e6';">Contact</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">    
    <article>
        <p>        
            Use this area to provide additional information.
        </p>
        <p>        
            Use this area to provide additional information.
        </p>
        <p>        
            Use this area to provide additional information.
        </p>
    </article>
    <aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Operatii</a></li>
            <li><a runat="server" href="~/About">Info</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>