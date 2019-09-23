<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receiving4.aspx.cs" Inherits="CrisWizLogistics.Receiving4" %>


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
                <asp:Label runat="server" AssociatedControlID="ItemName">Denumire articol</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ItemName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="OrderQty">Cantitate comanda</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="OrderQty" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="MeasureUnit">Unitate de masura</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="MeasureUnit" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ReceivedQty">Cantitate receptie</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="ReceivedQty" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="ReceivedQty" ValidationGroup="Receive" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
                <p><asp:RegularExpressionValidator runat="server" ControlToValidate="ReceivedQty" ValidationGroup="Receive" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="InternalBatchNo">Numar lot intern</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="InternalBatchNo" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="InternalBatchNo" ValidationGroup="Receive" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="SupplierBatchNo">Numar lot furnizor</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="SupplierBatchNo" />                
            </li>            
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />
        <asp:Button runat="server" CssClass="button" ID="Receive" Text="Receptie" ValidationGroup="Receive" OnClick="Receive_Click" />
    </fieldset>                               
</asp:Content>