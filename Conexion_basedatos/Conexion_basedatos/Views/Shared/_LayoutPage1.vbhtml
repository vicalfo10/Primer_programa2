<!DOCTYPE html>
@Imports System.Web.Optimization

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/bundles/jqueryvalunobtrusive")

    @Styles.Render("~/Content/css")
   
</head>
<body>
    @COde
        Dim user As String = Convert.ToString(Session("userName"))

        If user <> "" Then
            @<div class="head">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Acerca de", "Index2", "Home")</li>
                    <li>@Html.ActionLink("Salir", "Index", "Home")</li>
                </ul>
                <h2>Bienvenido: @user</h2>
            </div>@<br />@<br />
        End If

    End Code
    <div>
        @RenderBody()
    </div>

    <footer>
        <center>
            <p>&copy;VGR</p>
        </center>
    </footer>
</body>
</html>
