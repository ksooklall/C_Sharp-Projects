<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <button onclick="doWork(); return false;">DoWork</button>

        <button onclick="doFib(); return false;"> DoFib </button>
        <input type="text" id = "fibValue"  style = "width:50px"/>
        
        <button onclick="doSquare(); return false;">DoSquare</button>
        <input type="text" id = "squareValue" style = "width:50px" />
        
        <button onclick="doAddValues(); return false">DoAddValues</button>
        <input type="text" id = "addValue1" style = "width:100px" />
        <input type="text" id = "addValue2" style = "width:100px" />
    </div>

    <script type="text/javascript">

        function doWork() {
            $.ajax({
                url: "Service/Service1.svc/DoWork",
                type: "GET",
                datatype: "json",
                success: function (result) {
                    console.info(result);
                }
            })
        }

        function doFib() {
            var fibVal = $("#fibValue").val()

            $.ajax({
                url: "Service/Service1.svc/DoFib",
                type: "POST",
                data: JSON.stringify(fibVal),
                datatype: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                }
            })
        }

        function doSquare() {
            var value = $("#squareValue").val();

            $.ajax({
                url: "Service/Service1.svc/DoSquare",
                type: "POST",
                data: JSON.stringify(value),
                datatype: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                }
            })
        }

        function doAddValues() {
            var value = {
                "value1": $("#addValue1").val(),
                "value2": $("#addValue2").val()
            };

            $.ajax({
                url: "Service/Service1.svc/DoAddValues",
                type: "POST",
                data: JSON.stringify(value),
                datatype: "json",
                contentType: "application/json",
                success: function (result) {
                    console.info(result);
                },
                error: function(error) {
                    console.error(error);
            }
            })
        }
    </script>
</asp:Content>
