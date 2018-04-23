Imports System
Imports System.Linq
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security
Imports InstantPrintReportsV2Example.Module.BusinessObjects
'using DevExpress.ExpressApp.Reports;
'using DevExpress.ExpressApp.PivotChart;
'using DevExpress.ExpressApp.Security.Strategy;
'using InstantPrintReportsV2Example.Module.BusinessObjects;

Namespace InstantPrintReportsV2Example.Module.DatabaseUpdate
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            If ObjectSpace.GetObjectsCount(GetType(Contact), Nothing) = 0 Then
                Dim mary As Contact = ObjectSpace.CreateObject(Of Contact)()
                mary.Name = "Mary"
                mary.Email = "mary@example.com"
                mary.PhoneNumber = "(555)123-45-67"
                Dim john As Contact = ObjectSpace.CreateObject(Of Contact)()
                john.Name = "John"
                john.Email = "john@example.com"
                john.PhoneNumber = "(555)987-65-43"

            End If
        End Sub
        Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
            MyBase.UpdateDatabaseBeforeUpdateSchema()

        End Sub
    End Class
End Namespace
