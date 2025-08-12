<%@ Page Title="Contact Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Demo.WebApp.Add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row">
            <h1 id="aspnetTitle">Demo</h1>
            <p class="lead">CRUD + CSV Demo</p>
        </section>

        <div class="row">
            <div class="col-md-4">
                <div>
                    <label>First Name:</label>
                    <asp:TextBox ID="txtFirstName" runat="server" />
                    <asp:RequiredFieldValidator ID="reqFirstName" runat="server"
                        ControlToValidate="txtFirstName" ErrorMessage="First Name is required." Display="Dynamic" />
                </div>
                <div>
                    <label>Last Name:</label>
                    <asp:TextBox ID="txtLastName" runat="server" />
                    <asp:RequiredFieldValidator ID="reqLastName" runat="server"
                        ControlToValidate="txtLastName" ErrorMessage="Last Name is required." Display="Dynamic" />
                </div>
                <div>
                    <label>Email:</label>
                    <asp:TextBox ID="txtEmail" runat="server" />
                    <asp:RequiredFieldValidator ID="reqEmail" runat="server"
                        ControlToValidate="txtEmail" ErrorMessage="Email is required" Display="Dynamic" />
                    <asp:RegularExpressionValidator ID="regEmail" runat="server"
                        ControlToValidate="txtEmail"
                        ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                        ErrorMessage="Email format is invalid" Display="Dynamic" />
                </div>
                <div>
                    <label>Phone:</label>
                    <asp:TextBox ID="txtPhone" runat="server" />
                    <asp:RequiredFieldValidator ID="reqPhone" runat="server"
                        ControlToValidate="txtPhone" ErrorMessage="Phone is required" Display="Dynamic" />
                </div>
                <div>
                    <label>Alternate Phone:</label>
                    <asp:TextBox ID="txtAlternatePhone" runat="server" />
                </div>
                <div>
                    <asp:Button ID="AddContactButton" runat="server" Text="Save Contact" CssClass="btn btn-primary" OnClick="AddContactButton_Click" />
                    <asp:Button ID="CancelContactButton" runat="server" Text="Cancel" CssClass="btn btn-secondary" OnClick="CancelContactButton_Click" />
                </div>
            </div>
        </div>
    </main>

</asp:Content>
