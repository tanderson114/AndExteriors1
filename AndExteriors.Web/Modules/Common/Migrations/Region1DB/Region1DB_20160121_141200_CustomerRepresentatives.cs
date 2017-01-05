﻿using FluentMigrator;

namespace AndExteriors.Migrations.Region1DB
{
    [Migration(20160121141200)]
    public class Region1DB_20160121_141200_CustomerRepresentatives : AutoReversingMigration
    {
        public override void Up()
        {
            IfDatabase(Utils.AllExceptOracle)
                .Create.Table("CustomerRepresentatives")
                    .WithColumn("RepresentativeID").AsInt32().PrimaryKey().Identity().NotNullable()
                    .WithColumn("CustomerID").AsInt32().NotNullable()
                    .WithColumn("EmployeeID").AsInt32().NotNullable();

            IfDatabase("Oracle")
                .Create.Table("CustomerRepresentatives")
                    .WithColumn("RepresentativeID").AsInt32().PrimaryKey().NotNullable()
                    .WithColumn("CustomerID").AsInt32().NotNullable()
                    .WithColumn("EmployeeID").AsInt32().NotNullable();

            Utils.AddOracleIdentity(this, "CustomerRepresentatives", "RepresentativeID");
        }
    }
}