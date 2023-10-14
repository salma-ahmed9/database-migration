using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Hospital.Migrations;
using Hospital.Migrations.Migrations;

namespace Hospital.Migrations.Seed;

public class Doctor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}

[Migration(3)]
public class _0101_DoctorTableSeed : Migration
{
    public List<Doctor> ExisitingDoctors = new()
    {
        new Doctor
        {
            FirstName="Ahmed",
            LastName="Mohsen",
            Email="AhmedM@gmail.com",
            Address="12 Nasr Street,Maadi"

        },
        new Doctor
        {
            FirstName="Mohamed",
            LastName="Emad",
            Email="MohamedEmad@gmail.com",
            Address="4 Al Sheikh Mostafa Tomom,Manial"
        },
        new Doctor
        {
            FirstName="Salma",
            LastName="Ahmed",
            Email="SalmaAhmed@gmail.com",
            Address="9 El Azhar Street,Nasr City"
        },
        new Doctor
        {
            FirstName="Nada",
            LastName="Ahmed",
            Email="NadaAhmed@gmail.com",
            Address="2 El Bostan Street,Haram"

        }
    };

    public override void Up()
    {
        foreach (var item in ExisitingDoctors)
        {
            Insert.IntoTable(Tables.Doctor).Row(new
            {
                first_name = item.FirstName,
                last_name = item.LastName,
                email = item.Email,
                address = item.Address
            });
        }
    }
    public override void Down()
    {

    }

}
