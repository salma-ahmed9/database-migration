using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Hospital.Migrations.Migrations;

[Migration(1)]
public class _0001_DoctorTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(Tables.Doctor)
            .WithColumn("id").AsInt64().PrimaryKey().Identity()
            .WithColumn("first_name").AsString(100).NotNullable()
            .WithColumn("last_name").AsString(100).NotNullable()
            .WithColumn("email").AsString().NotNullable()
            .WithColumn("address").AsString().NotNullable();
             
    }
}
