namespace InstantPrintReportsV2Example.Win {
    partial class InstantPrintReportsV2ExampleWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new InstantPrintReportsV2Example.Module.InstantPrintReportsV2ExampleModule();
            this.module4 = new InstantPrintReportsV2Example.Module.Win.InstantPrintReportsV2ExampleWindowsFormsModule();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // InstantPrintReportsV2ExampleWindowsFormsApplication
            // 
            this.ApplicationName = "InstantPrintReportsV2Example";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.InstantPrintReportsV2ExampleWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.InstantPrintReportsV2ExampleWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private InstantPrintReportsV2Example.Module.InstantPrintReportsV2ExampleModule module3;
        private InstantPrintReportsV2Example.Module.Win.InstantPrintReportsV2ExampleWindowsFormsModule module4;
    }
}
