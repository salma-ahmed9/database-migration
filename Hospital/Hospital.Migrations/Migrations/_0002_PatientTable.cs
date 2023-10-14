using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Hospital.Migrations.Migrations;

[Migration(2)]
public class _0002_PatientTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(Tables.Patient)
            .WithColumn("id").AsInt64().PrimaryKey().Identity()
            .WithColumn("first_name").AsString(100).NotNullable()
            .WithColumn("last_name").AsString(100).NotNullable()
            .WithColumn("email").AsString().NotNullable()
            .WithColumn("address").AsString().NotNullable()
            .WithColumn("assigned_doctor_id").AsInt64().NotNullable().ForeignKey(Tables.Doctor,"id");

    }
}
