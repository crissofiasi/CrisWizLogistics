<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdOrder4.aspx.cs" Inherits="CrisWizLogistics.ProdOrder4" %>


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
            <li runat="server" id="MeasureUnitGroup">
                <asp:Label runat="server" AssociatedControlID="MeasureUnit">Unitate de masura</asp:Label>                
                <asp:DropDownList runat="server" ID="MeasureUnit" AutoPostBack="true" OnSelectedIndexChanged="MeasureUnit_SelectedIndexChanged">
                    <asp:ListItem Value="1" Text="Kilograme" />
                    <asp:ListItem Value="2" Text="Bucati" Selected="True" />
                </asp:DropDownList>
            </li>            
            <li>
                <asp:Label runat="server" AssociatedControlID="ProcessQty">Cantitate prelucrabila</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ProcessQty" ReadOnly="true" />
            </li>            
            <li>
                <asp:Label runat="server" AssociatedControlID="FinishedQty">Cantitate finalizata</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="FinishedQty" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="FinishedQty" ValidationGroup="Finished" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
                <p><asp:RegularExpressionValidator runat="server" ID="FinishedQtyValidator" ControlToValidate="FinishedQty" ValidationGroup="Finished" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Remarks">Detalii generale</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="Remarks" />                
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="StoppedQty">Cantitate stopata</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="StoppedQty" />
                <p><asp:RegularExpressionValidator runat="server" ID="StoppedQtyValidator" ControlToValidate="StoppedQty" ValidationGroup="Finished" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="StoppedRemarks">Detalii cantitate stopata</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="StoppedRemarks" />                
            </li>            
            <li>
                <asp:Label runat="server" AssociatedControlID="RejectedQty">Cantitate refuzata</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="RejectedQty" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="RejectedQty" ValidationGroup="Rejected" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
                <p><asp:RegularExpressionValidator runat="server" ID="RejectedQtyValidator" ControlToValidate="RejectedQty" ValidationGroup="Rejected" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>            
            <li>
                <asp:Label runat="server" AssociatedControlID="RejectedReasonName">Motiv (defectiune)</asp:Label>                
                <asp:DropDownList runat="server" ID="RejectedReasonName" DataTextField="Name" DataValueField="RejectedReasonID" />                
            </li>
            <li>
                <asp:Button runat="server" CssClass="button tool" ID="Add" Text="Adaugare" ValidationGroup="Rejected" OnClick="AddRejected_Click" />
                <asp:Button runat="server" CssClass="button tool" Text="Stergere" OnClick="DelRejected_Click" />
                <asp:GridView runat="server" ID="RejectedView" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nimic refuzat" EmptyDataRowStyle-HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundField DataField="Quantity" HeaderText="Cant." />
                        <asp:BoundField DataField="ReasonName" HeaderText="Motiv" />
                    </Columns>
                </asp:GridView>
            </li>
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />
        <asp:Button runat="server" CssClass="button" ID="Stop" Text="Stop" ValidationGroup="Finished" OnClick="Stop_Click" />
    </fieldset>                                     
</asp:Content>