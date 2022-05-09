<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Price.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style type="text/css">
        canvas {
            color: #465f25;
            background: #94d362;
            border-color: #91ce5e #7ab04b #5e903f;
            -webkit-box-shadow: inset 0 1px #d9f3b5, inset 0 0 0 1px #b1e095, 0 1px #5e903f, 0 3px #6da445, 0 4px #5e903f, 0 5px 2px rgba(0, 0, 0, 0.4);
            border-radius: 10px;
        }
        button {
            border: 2px solid #4CAF50;
            border-radius: 5px;
            text-align: center;
            align-items: center;
            align-content: center;
            position: fixed;
            top: auto;
            left: auto;
            transform: translate(40%,-50%);
            
        }
    </style>

    <script>
        function exportDataToExcel(dataID, filename = '') {
            var downloadLink;
            var datatype = 'application/vnd.ms-excel';
            var dataSelect = document.getElementById(dataID);
            var dataHTML = dataSelect.outerHTML.replace(/ /g, '%20');

            filename = filename ? filename + '.xls' : 'excel_data.xls';
            downloadLink = document.createElement("a");
            document.body.appendChild(downloadLink);

            if (navigator.msSaveOrOpenBlob) {
                var blob = new Blob(['\ufeff', dataHTML], {
                    type: dataType
                });
                navigator.msSaveOrOpenBlob(blob, filename);
            } else {
                downloadLink.href = 'data: ' + datatype + ', ' + dataHTML;
                downloadLink.download = filename;
                downloadLink.click();
            }
        }
    </script>
</head>
<body>
    <button onclick="exportDataToExcel('data');">Export data to Excel</button>
    <br>

    <h3>Elektri jooksva tunni hind</h3>
    <canvas id="data" width="250" height="75"></canvas>
    <div>
        <script>
            fetch('https://dashboard.elering.ee/api/nps/price/EE/current')
                .then(function (response) {
                    return response.json();
                })
                .then(function (Data) {
                    f(Data);
                })
            function f(Data) {
                var price = Data.data[0].price;
                var c = document.getElementById("data");
                var ctx = c.getContext("2d");
                ctx.font = "30px Arial";

                ctx.fillText(price + " €/MWh", 30, 50);
            }
        </script>
    </div>
</body>
</html >

