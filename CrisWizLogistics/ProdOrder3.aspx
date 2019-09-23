<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdOrder3.aspx.cs" Inherits="CrisWizLogistics.ProdOrder3" %>

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
    <p class="validation-summary-valid">
        <asp:Literal runat="server" ID="SuccessText" />
    </p>
    <fieldset>        
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="ItemCode">Articol</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ItemCode" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ActionName">Operatie</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ActionName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="WorkCenterName">Centru de lucru</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="WorkCenterName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ProcessQty">Cantitate prelucrabila</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ProcessQty" ReadOnly="true" />
            </li>        
            <li>
                <asp:Label runat="server" AssociatedControlID="WorkerName">Operator</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="WorkerName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ShiftName">Schimb</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ShiftName" ReadOnly="true" />                 
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ShiftName">Data start</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="CreatedDate" ReadOnly="true" />                 
            </li>
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />
        <asp:Button runat="server" CssClass="button" Text="Continuare" OnClick="Next_Click" />        
    </fieldset>                                     
</asp:Content>