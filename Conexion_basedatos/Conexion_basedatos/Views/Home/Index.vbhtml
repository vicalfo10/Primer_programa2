@ModelType Conexion_basedatos.UserLogin
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<div class="container">
    <div class="card card-container">
        <h2 class="titleLogin">Iniciar Sesión</h2>
        @code
            Using (Html.BeginForm("Usuarios", "Home", FormMethod.Post, New With {.class = "form-signin"}))
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @<div>
                    <div>
                        @Html.TextBoxFor(Function(m) m.Email, "", New With {.class = "form-control", .placeholder = "Email"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-"})
                    </div>
                    <div>
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control", .placeholder = "Password"})
                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                    </div><br />
                </div>
                @<input type="submit" value="Enviar " class="btn btn-signin" />
            End Using
        End Code
    </div>
</div>

