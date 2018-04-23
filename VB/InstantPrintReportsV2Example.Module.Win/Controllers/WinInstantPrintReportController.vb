Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports InstantPrintReportsV2Example.Module.Controllers
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.XtraReports.UI

Namespace InstantPrintReportsV2Example.Module.Win
    Public Class WinInstantPrintReportController
        Inherits PrintContactsController

        Protected Overrides Sub PrintReport(ByVal reportData As IReportDataV2)
            Dim report As XtraReport = ReportDataProvider.ReportsStorage.LoadReport(reportData)
            Dim reportsModule As ReportsModuleV2 = ReportsModuleV2.FindReportsModule(Application.Modules)
            If reportsModule IsNot Nothing AndAlso reportsModule.ReportsDataSourceHelper IsNot Nothing Then
                reportsModule.ReportsDataSourceHelper.SetupBeforePrint(report)
                report.PrintDialog()
            End If
        End Sub
    End Class
End Namespace
