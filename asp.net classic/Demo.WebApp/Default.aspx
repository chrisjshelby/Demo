<%@ Page Title="Contact Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo.WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row">
            <h1 id="aspnetTitle">Demo</h1>
            <p class="lead">CRUD + CSV Demo</p>
        </section>

        <div class="row">
            <section class="col-md-4">
                <asp:GridView ID="ContactGridView" DataKeyNames="id" runat="server" 
                    OnDeleteCommand="DeleteContactButton_Click" OnEditCommand="EditContactButton_Click" 
                    OnInsertCommand="InsertContactButton_Click"  AllowPaging="True" OnRowCancelingEdit="ContactGridView_RowCancelingEdit" OnRowDeleting="ContactGridView_RowDeleting" OnRowEditing="ContactGridView_RowEditing" OnRowUpdating="ContactGridView_RowUpdating" OnSelectedIndexChanged="ContactGridView_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="First_Name" HeaderText="First Name" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="Last_Name" HeaderText="Last Name" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="Email" HeaderText="Email" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone" ValidateRequestMode="Enabled" />
                        <asp:BoundField DataField="Alternate_Phone" HeaderText="Alternate Phone" />
                        <asp:CommandField ButtonType="Link" ShowSelectButton="false" ShowDeleteButton="true" ShowEditButton="true" CausesValidation="true" />
                    </Columns>
                </asp:GridView>
            </section>
        </div>

        <div>
            <section class="col-md-4">
                <asp:Button ID="AddContactButton" runat="server" Text="Add Contact" CssClass="btn btn-primary" OnClick="AddContactButton_Click" />
                <asp:Button ID="ExportContactCsvButton" runat="server" Text="Export to CSV" CssClass="btn btn-secondary" OnClick="ExportContactCsvButton_Click" />
            </section>
        </div>
    </main>

</asp:Content>
