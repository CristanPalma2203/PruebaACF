﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron table-header">
        <h3>Table Client</h3>
        <asp:GridView ID="dt1" class="table table-striped" runat="server" AutoGenerateColumns="false" OnRowDataBound="dt1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" DataFormatString="{0:yyyy-MM-dd}" />

                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" runat="server" Text="Editar" OnClick="Edit_Click"></asp:LinkButton>
                        <asp:LinkButton ID="btnDelete" runat="server" Text="Eliminar" OnClick="Delete_Click" OnClientClick="return confirm('¿Estás seguro de eliminar este registro?');"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>