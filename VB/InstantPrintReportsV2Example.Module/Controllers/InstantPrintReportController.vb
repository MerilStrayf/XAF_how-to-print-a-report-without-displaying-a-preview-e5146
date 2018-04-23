Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports InstantPrintReportsV2Example.Module.BusinessObjects
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace InstantPrintReportsV2Example.Module.Controllers
    Public MustInherit Class PrintContactsController
        Inherits ObjectViewController(Of ListView, Contact)

        Public Sub New()
            Dim printAction As New SimpleAction(Me, "PrintContacts", PredefinedCategory.Reports)
            printAction.ImageName = "Action_Printing_Print"
            AddHandler printAction.Execute, Sub(sender As Object, e As SimpleActionExecuteEventArgs)
                Dim objectSpace As IObjectSpace = ReportDataProvider.ReportObjectSpaceProvider.CreateObjectSpace(GetType(ReportDataV2))
                Dim reportData As IReportDataV2 = objectSpace.FindObject(Of ReportDataV2)(New BinaryOperator("DisplayName","Contacts Report"))
                If reportData Is Nothing Then
                    Throw New UserFriendlyException("Cannot find the 'Contacts Report' report.")
                Else
                    PrintReport(reportData)
                End If
            End Sub
        End Sub
        Protected MustOverride Sub PrintReport(ByVal reportData As IReportDataV2)
    End Class
End Namespace
