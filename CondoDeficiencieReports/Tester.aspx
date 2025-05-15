<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tester.aspx.cs" Inherits="CondoDeficiencyReports.Tester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=i&ig=9158c720-ab7e-4306-9113-c900f81d00a6" target="_blank">Print Invoice</a>
        </div>
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=ul&bg=39FB310E-E222-44C2-B7D0-6C17EC13030F" target="_blank">Print Unit Listing</a>
        </div>
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=cdrd&dt=9/1/2018" target="_blank">Print Consolidated Rent Detail</a>
        </div>
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=cdad&dt=9/1/2018" target="_blank">Print Consolidated Aging Detail</a>
        </div>
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=bs&bg=39FB310E-E222-44C2-B7D0-6C17EC13030F&dt=9/1/2018" target="_blank">Building Summary</a>
        </div>
         <div>
            <a href="http://localhost:57245/ReportViewer?rt=dc&bg=E97836B9-1049-4CDB-998A-88864F7F4F19&dt=2/1/2018" target="_blank">Default Certificate</a>
        </div>
        <div>
            <a href="http://localhost:57245/ReportViewer?rt=df&bg=D6E027D3-493A-4D49-B5B3-15DD41E60C44&dt=4/1/2017" target="_blank">Deficiency Report</a>
        </div>
    </form>
</body>
</html>
