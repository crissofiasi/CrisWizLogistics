<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receiving2.aspx.cs" Inherits="CrisWizLogistics.Receiving2" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Receiving1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Receptie marfa</a></li>                
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
                <asp:Label runat="server" AssociatedControlID="DocDate">Data document</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DocDate" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="SupplierName">Denumire furnizor</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="SupplierName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="SupplierDocNum">Numar doc. furnizor</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="SupplierDocNum" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="SupplierDocNum" ValidationGroup="DocInfo" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>            
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />
        <asp:Button runat="server" CssClass="button" ID="OrderItems" Text="Articole" ValidationGroup="DocInfo" OnClick="OrderItems_Click" />
        <asp:Button runat="server" CssClass="button" ID="Finish" Text="Finalizare receptie" ValidationGroup="DocInfo" OnClick="Finish_Click" />
    </fieldset>      
</asp:Content>
