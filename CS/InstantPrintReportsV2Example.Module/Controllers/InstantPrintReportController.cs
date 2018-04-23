using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using InstantPrintReportsV2Example.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace InstantPrintReportsV2Example.Module.Controllers {
    public abstract class PrintContactsController : ObjectViewController<ListView, Contact> {
        public PrintContactsController() {
            SimpleAction printAction = new SimpleAction(this, "PrintContacts", PredefinedCategory.Reports);
            printAction.ImageName = "Action_Printing_Print";
            printAction.Execute += delegate(object sender, SimpleActionExecuteEventArgs e) {
                IObjectSpace objectSpace = ReportDataProvider.ReportObjectSpaceProvider.CreateObjectSpace(typeof(ReportDataV2));
                IReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(
                    new BinaryOperator("DisplayName","Contacts Report"));
                if (reportData == null) {
                    throw new UserFriendlyException("Cannot find the 'Contacts Report' report.");
                }
                else {
                    PrintReport(reportData);
                }
            };
        }
        protected abstract void PrintReport(IReportDataV2 reportData);
    }
}
