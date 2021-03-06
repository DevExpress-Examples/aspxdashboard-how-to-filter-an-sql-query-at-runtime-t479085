﻿using System;
using DevExpress.DashboardWeb;
using DevExpress.Data.Filtering;
using DevExpress.DashboardCommon;

namespace ASPxDashboard_CustomFilterExpression {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
        }

        protected void ASPxDashboard1_CustomFilterExpression(object sender, CustomFilterExpressionWebEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1" && e.TableName == "Invoices") {
                e.FilterExpression = new BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal);
            }
        }
    }
}