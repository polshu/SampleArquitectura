<%@ Page Title="" Language="C#" MasterPageFile="~/Master/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gestion.WebForms.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPageContent" runat="server">
    <div class="col-md-4 order-md-2 mb-4">
        <h4 class="mb-3">GetAll</h4>
        <asp:Repeater ID="repPersonas" runat="server">
            <HeaderTemplate>
                <ul class="list-group mb-3">
            </HeaderTemplate>
            <ItemTemplate>
                <li class="list-group-item d-flex justify-content-between lh-condensed">
                    <h6 class="my-0"><%# DataBinder.Eval(Container.DataItem,"Nombre") %> | <small class="text-muted"><%# DataBinder.Eval(Container.DataItem,"Email") %></small></h6>
                    <span class="text-muted"><%# DataBinder.Eval(Container.DataItem,"Activo") %></span>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
       

        <div class="card p-2">
            <asp:Button ID="btnRefresh" runat="server" Text="Refresh" CssClass="btn btn-secondary btn-lg btn-block" OnClick="btnRefresh_Click" />
        </div>
    </div>
    
    <div class="col-md-8 order-md-1">
        <h4 class="mb-3">Persona</h4>
        <div class="row">
            <div class="col-md-6 mb-3">
                
                <label for="firstName">Nombre</label>
                <%--<input type="text" maxlength="320" class="form-control" id="txtNombre1" placeholder="ingrese email" value="" >--%>
                <asp:TextBox ID="txtNombre" runat="server" MaxLength="150" CssClass="form-control" placeholder="ingrese nombre"></asp:TextBox>
            </div>
            <div class="col-md-6 mb-3">
                <label for="lastName">Email</label>
                <%--<input type="text" maxlength="320" class="form-control" id="txtEmail1" placeholder="ingrese email" value="">--%>
                <asp:TextBox ID="txtEmail" runat="server" maxlength="320" CssClass="form-control" placeholder="ingrese email"></asp:TextBox>
            </div>
            
        </div>
                   
        <div class="custom-control custom-checkbox">
            <input type="checkbox" class="custom-control-input" id="chkActivo" runat="server">
            <label class="custom-control-label" for="same-address">Activo</label>
        </div>
                    
        <hr class="mb-4">
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-primary btn-lg btn-block" OnClick="btnInsertar_Click" />
        <asp:Literal ID="litOutput" runat="server"></asp:Literal>
    </div>
</asp:Content>
