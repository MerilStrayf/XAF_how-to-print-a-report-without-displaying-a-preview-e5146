﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InstantPrintReportsV2Example.Module.Controllers;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Web;

namespace InstantPrintReportsV2Example.Module.Web {
    public class WebInstantPrintReportController : PrintContactsController {
        protected override void PrintReport(IReportDataV2 reportData) {
            string reportContainerHandle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);
            ((WebWindow)WebApplication.Instance.MainWindow).RegisterStartupScript(
                "InstantPrintReport", GetPrintingScript(reportContainerHandle), overwrite: true);
        }
        private string GetPrintingScript(string reportContainerHandle) {
            return string.Format(@"
            if(!ASPx.Browser.Edge) {{
                var iframe = document.getElementById('reportout');
                if (iframe != null) {{
                    document.body.removeChild(iframe);
                }}
                iframe = document.createElement('iframe');
                iframe.setAttribute('id', 'reportout');
                iframe.style.width = 0;
                iframe.style.height = 0;
                iframe.style.border = 0;
                document.body.appendChild(iframe);
                document.getElementById('reportout').contentWindow.location = 'InstantPrintReport.aspx?reportContainerHandle={0}';
            }} else {{
                window.open('InstantPrintReport.aspx?reportContainerHandle={0}', '_blank');
            }}
            ", reportContainerHandle);
        }
    }
}
