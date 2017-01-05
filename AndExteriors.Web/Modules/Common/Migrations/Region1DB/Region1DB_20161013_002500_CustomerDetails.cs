using FluentMigrator;

namespace AndExteriors.Migrations.Region1DB
{
    [Migration(20161013002500)]
    public class Region1DB_20161013_002500_CustomerDetails : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("CustomerDetails")
                .WithColumn("ID").AsInt32().PrimaryKey().NotNullable()
                .WithColumn("LastContactDate").AsDateTime().Nullable()
                .WithColumn("LastContactedBy").AsInt32().Nullable()
                    .ForeignKey("FK_CustomerDetails_LastContactedBy", "Employees", "EmployeeID")
                .WithColumn("Email").AsString(100).Nullable()
                .WithColumn("SendBulletin").AsBoolean().NotNullable().WithDefaultValue(0);
        }
    }
}