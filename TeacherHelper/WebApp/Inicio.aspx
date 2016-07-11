<%@Page Title="TeacherHelper" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApp.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <div class="form-group">
    <label for="lblEmail" class="col-lg-2 control-label">Email</label>
    <div class="col-lg-10">
      <input type="email" class="form-control" id="lblEmail"
             placeholder="Email">
    </div>
  </div>
  <div class="form-group">
    <label for="lblPassword" class="col-lg-2 control-label">Contraseña</label>
    <div class="col-lg-10">
      <input type="password" class="form-control" id="lblPassword" 
             placeholder="Contraseña">
    </div>
  </div>
  <div class="form-group">
    <div class="col-lg-offset-2 col-lg-10">
      <div class="checkbox">
        <label>
          <input type="checkbox"> No cerrar sesión
        </label>
      </div>
    </div>
  </div>
  <div class="form-group">
      <button type="submit" class="btn btn-default">Entrar</button>
    </div>
    <div class="form-group">
        <button type="submit" class="btn btn-default">Registrarse</button>
    </div>
</asp:Content>
