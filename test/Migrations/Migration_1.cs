using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace test.Migrations
{
    [Migration(1)]
    public class Migration_1 : Migration
    {
        public override void Down()
        {
            Delete.Table("Student");
        }

        public override void Up()
        {
            Create.Table("Student")
                 .WithColumn("Id").AsInt64().PrimaryKey().Identity().NotNullable()
                 .WithColumn("Name").AsString().NotNullable()
                 .WithColumn("Email").AsString().NotNullable();
        }

       
    }
}
