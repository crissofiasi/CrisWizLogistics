<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CrisWizLogistics.Contact" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2"><a runat="server" href="~/About" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Info</a></li>
                <li id="tab3" class="tab-selected"><a runat="server" href="~/Contact" onfocus="tab3.style.backgroundColor = '#a4d4e6';">Contact</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">    
    <div class="contact">
        <h3>Telefon:</h3>
        <p>
            <span class="label">General:</span>
            <span>+40 742 035 496; +40 741 205 602</span>
        </p>
        <p>
            <span class="label">Fax:</span>
            <span>+40 213 180 266</span>
        </p>
    </div>

    <div class="contact">
        <h3>Email:</h3>
        <p>
            <span class="label">General:</span>
            <span><a href="mailto:office@wizrom.ro">office@wizrom.ro</a></span>
        </p>        
        <p>
            <span class="label">Marketing:</span>
            <span><a href="mailto:sales@wizrom.ro">sales@wizrom.ro</a></span>
        </p>
        <p>
            <span class="label">Tehnic:</span>
            <span><a href="mailto:tehnic@wizrom.ro">tehnic@wizrom.ro</a></span>
        </p>        
    </div>

    <div class="contact">
        <h3>Adresa:</h3>
        <p>
            Str. Tipografilor Nr. 11-15, Cladirea S-Park, intrarea A2, etaj 1<br />
            Sector 1, Bucuresti 013714, Romania
        </p>
    </div>
</asp:Content>