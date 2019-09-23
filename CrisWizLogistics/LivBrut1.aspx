<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LivBrut1.aspx.cs" Inherits="CrisWizLogistics.LivBrut1" %>

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

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="FailureText" />
    </p>
    <p class="validation-summary-valid">
        <asp:Literal runat="server" ID="SuccessText" />
    </p>
    <fieldset>        
        <ol>
            <li>                
                <asp:Label runat="server" AssociatedControlID="AECode">Dispozitie de livrare (AE)</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="AECode" CausesValidation="True"  autofocus="true" AutoPostBack="false" />                
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="AECode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li> 
            <li>
                <asp:Button ID="CautaAE" runat="server" Text="Cauta" Width="303px" OnClick="CautaAE_Click" />


            </li>




       </ol>
   </fieldset>
</asp:Content>
