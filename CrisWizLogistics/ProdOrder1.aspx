<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdOrder1.aspx.cs" Inherits="CrisWizLogistics.ProdOrder1" %>
 

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/ProdOrder1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Raportare productie</a></li>                
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent"> 
    
    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="FailureText" />
    </p>
    <fieldset>        
        <ol>
            <li>                
                <asp:Label runat="server" AssociatedControlID="ProdOrderCode">Comanda productie</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="ProdOrderCode" />                
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="ProdOrderCode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ActionCode">Operatie</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="ActionCode" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="ActionCode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="WorkCenterCode">Centru de lucru</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="WorkCenterCode" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="WorkCenterCode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>            
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Continuare" OnClick="Next_Click" />                    
    </fieldset>                                     
</asp:Content>
