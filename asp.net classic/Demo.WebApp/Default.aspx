<%@ Page Title="Contact Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.WebApp._Default" %>
<%@ Register TagPrefix="Demo" Namespace="Demo.WebApp.Controls" Assembly="Demo.WebApp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h1 id="aspnetTitle">Demo</h1>
            <p class="lead">CRUD + CSV Demo</p>
        </section>

        <div class="row">
            <section class="col-md-4">
                <asp:GridView ID="ContactGridView" DataKeyNames="id" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" OnRowDeleting="ContactGridView_RowDeleting" 
                    OnRowEditing="ContactGridView_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="Email" HeaderText="Email" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="MainPhone" HeaderText="Phone" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="AlternatePhone" HeaderText="Phone" ValidateRequestMode="Enabled" />
                        <asp:CommandField ButtonType="Link" ShowSelectButton="false" ShowDeleteButton="true" ShowEditButton="true" CausesValidation="true" />
                    </Columns>
                </asp:GridView>
            </section>
        </div>

        <div>
            <section class="col-md-4">
                <asp:Button ID="AddContactButton" runat="server" Text="Add Contact" CssClass="btn btn-primary" OnClick="AddContactButton_Click" />
                <Demo:CSVExport ID="CSVExport" runat="server" />
            </section>
        </div>
    </main>

</asp:Content>
