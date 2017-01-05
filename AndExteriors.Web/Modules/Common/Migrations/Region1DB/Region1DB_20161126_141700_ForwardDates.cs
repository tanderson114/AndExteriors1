﻿using FluentMigrator;
using AndExteriors.Region1.Entities;
using Serenity.Data;
using System;

namespace AndExteriors.Migrations.Region1DB
{
    [Migration(20161126141700)]
    public class Region1DB_20161126_141700_ForwardDates : Migration
    {
        public override void Up()
        {
            var o = OrderRow.Fields;

            IfDatabase("SqlServer")
                .Execute.Sql(
                    new SqlUpdate(o.TableName)
                        .SetTo(o.OrderDate, "DATEADD(MONTH, 6, DATEADD(YEAR, 18, " + o.OrderDate.Name + "))")
                        .SetTo(o.RequiredDate, "DATEADD(MONTH, 6, DATEADD(YEAR, 18, " + o.RequiredDate.Name + "))")
                        .SetTo(o.ShippedDate, "DATEADD(MONTH, 6, DATEADD(YEAR, 18, " + o.ShippedDate.Name + "))")
                        .Where(o.OrderDate <= new DateTime(1999, 7, 1))
                        .DebugText);
        }

        public override void Down()
        {
        }
    }
}