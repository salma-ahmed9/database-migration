using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace test1.Seed;

[Migration(2)]
public class Seeding : Migration
{
    public override void Up()
    {
        Insert.IntoTable("Student").Row(new
        {
            Id = 1,
            Name = "Salma Ahmed",
            Email = "salma@gmail.com"
        });

        Insert.IntoTable("Student").Row(new
        {
            Id = 2,
            Name = "Nada Mohammed",
            Email = "nada22@gmail.com"
        });
    }
    public override void Down()
    {

    }
}
