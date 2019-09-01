<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TesteAPP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID ="grv_teste" AutoGenerateColumns="false" runat="server" DataKeyNames="CategoryID"
        onrowdeleting="EmployeeGridView_RowDeleting">
        <Columns>
            <asp:TemplateField HeaderText="[CategoryID]">
                <ItemTemplate>
                    <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="[CategoryName]">
                <ItemTemplate>
                    <%#Eval("CategoryName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="[Description]">
                <ItemTemplate>
                    <%#Eval("Description") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="[Picture]">
                <ItemTemplate>
                    <%#Eval("Picture") %>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:CommandField ShowDeleteButton="true" ButtonType="Image" DeleteText="DELETAR" HeaderText="Deletar" />
        </Columns>
    </asp:GridView>

</asp:Content>
