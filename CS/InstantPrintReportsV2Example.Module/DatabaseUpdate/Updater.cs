using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using InstantPrintReportsV2Example.Module.BusinessObjects;
//using DevExpress.ExpressApp.Reports;
//using DevExpress.ExpressApp.PivotChart;
//using DevExpress.ExpressApp.Security.Strategy;
//using InstantPrintReportsV2Example.Module.BusinessObjects;

namespace InstantPrintReportsV2Example.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.GetObjectsCount(typeof(Contact), null) == 0) {
                Contact mary = ObjectSpace.CreateObject<Contact>();
                mary.Name = "Mary";
                mary.Email = "mary@example.com";
                mary.PhoneNumber = "(555)123-45-67";
                Contact john = ObjectSpace.CreateObject<Contact>();
                john.Name = "John";
                john.Email = "john@example.com";
                john.PhoneNumber = "(555)987-65-43";

            }
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
         
        }
    }
}
