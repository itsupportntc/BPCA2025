<%@ Page language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="CondoDeficiencyReports.ReportViewer" %>
<%@ Register assembly="GrapeCity.ActiveReports.Web.v12, Version=12.2.13986.0, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" namespace="GrapeCity.ActiveReports.Web" tagprefix="ActiveReportsWeb" %>

<style type="text/css">  
html, body, #WebViewer1, #controlDiv  
{  
   width: 100%;  
   height: 100%;  
   margin: 0;  
}  
</style>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Condo Deficiencies - Report Viewer</title>
    </head>
    <body>
        <ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" ViewerType="AcrobatReader">
            <FlashViewerOptions MultiPageViewColumns="1" MultiPageViewRows="1"></FlashViewerOptions>
            <PdfExportOptions CenterWindow="True" DisplayMode="FullScreen" FitWindow="True">
            </PdfExportOptions>
        </ActiveReportsWeb:WebViewer>
    </body>
</html>
