﻿using FluentMigrator;
using FluentMigrator.Builders.Create.Table;
using System;

namespace AndExteriors.Migrations.Region1DB
{
    [Migration(20161118195400)]
    public class Region1DB_20161118_195400_DragDropSample : AutoReversingMigration
    {
        public override void Up()
        {
            Action<ICreateTableWithColumnSyntax> addColumns = expr => expr
                .WithColumn("ParentId").AsInt32().Nullable()
                .WithColumn("Title").AsString(100).NotNullable();

            addColumns(IfDatabase(Utils.AllExceptOracle)
                .Create.Table("DragDropSample")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable());

            addColumns(IfDatabase("Oracle")
                .Create.Table("DragDropSample")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable());

            Utils.AddOracleIdentity(this, "DragDropSample", "Id");
        }
    }
}