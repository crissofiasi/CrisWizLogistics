<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CrisWizLogistics.Login" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

     <% if(Request.Cookies["VirtualKeyBoard"]!=null)
           if (Convert.ToInt16(Request.Cookies["VirtualKeyBoard"].Value) == 1)
           { %>
        
       
 

    <script>
        $(function () {
            $('input[type=password]').keyboard({
                layout: 'custom',
                customLayout: {
                    'normal': [
                        '7 8 9 {b}',
                        '4 5 6 {clear}',
                        '1 2 3 {c}',
                        '0 {dec} {empty} {a}'
                    ]
                },
                            });
        });
	</script>
     <%} %>

    <div id="loginForm">
        <h2>Autentificare</h2>
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false" OnAuthenticate="User_Authenticate">            
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>                    
                    <ol>
                       <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Utilizator</asp:Label>
                            <asp:TextBox runat="server" CssClass="textbox" ID="UserName" Text="terminal1"/>
                            <p><asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Numele utilizatorului este obligatoriu." /></p>
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Parola</asp:Label>
                            <asp:TextBox runat="server" CssClass="textbox" ID="Password" TextMode="Password" Text="1" />
                            <p><asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Parola este obligatorie." /></p>
                        </li>
                    </ol>
                    <asp:Button runat="server" CssClass="button" CommandName="Login" Text="Autentificare" />                    
                </fieldset>
            </LayoutTemplate>
        </asp:Login>        
    </div>
</asp:Content>

