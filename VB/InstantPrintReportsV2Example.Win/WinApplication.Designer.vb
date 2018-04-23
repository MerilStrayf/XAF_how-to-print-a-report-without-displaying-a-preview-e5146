Namespace InstantPrintReportsV2Example.Win
    Partial Public Class InstantPrintReportsV2ExampleWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New InstantPrintReportsV2Example.Module.InstantPrintReportsV2ExampleModule()
            Me.module4 = New InstantPrintReportsV2Example.Module.Win.InstantPrintReportsV2ExampleWindowsFormsModule()

            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' InstantPrintReportsV2ExampleWindowsFormsApplication
            ' 
            Me.ApplicationName = "InstantPrintReportsV2Example"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)

            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As InstantPrintReportsV2Example.Module.InstantPrintReportsV2ExampleModule
        Private module4 As InstantPrintReportsV2Example.Module.Win.InstantPrintReportsV2ExampleWindowsFormsModule
    End Class
End Namespace
