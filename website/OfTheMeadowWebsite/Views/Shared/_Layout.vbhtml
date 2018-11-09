<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Styles.Render("~/Content/CSS.css")
    @Styles.Render("~/Scripts/JavaScript.js")

</head>
<body>
    <!--navigation-->

    <div class="navbar">
        <ul id="menu">
            <li style="float:left"><a href="~/OfTheMeadowWebsite.vbproj">home</a></li>
            <li><a href="#aboutme">about</a></li>
            <li><a href="#skills">skills</a></li>
            <li><a href="#experience">experience</a></li>
            <li style="float:right"><a href="#contact">contact</a></li>
        </ul>
    </div>

    <!--/navigation-->
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
