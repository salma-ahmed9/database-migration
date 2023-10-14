using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Hospital.Migrations.Migrations;

namespace Hospital.Migrations.Seed;

public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int AssignedDoctorID { get; set; }
}

[Migration(4)]
public class _0102_PatientTableSeed : Migration
{
    public List<Patient> ExisitingPatients = new()
    {
        new Patient
        {
            FirstName="Omar",
            LastName="Galal",
            Email="OmarG@gmail.com",
            Address="9 Mosaddak Street,Dokki",
            AssignedDoctorID=2

        },
        new Patient
        {
            FirstName="Noran",
            LastName="Mahmoud",
            Email="NoranMahmoud@gmail.com",
            Address="14 El Teseen El Ganouby,Downtown",
            AssignedDoctorID=1
        },
        new Patient
        {
            FirstName="Zeina",
            LastName="Ahmed",
            Email="ZeinaAhmed@gmail.com",
            Address="15 Ahmed Oraby,Mohandeseen",
            AssignedDoctorID=4
        }
    };
    public override void Up()
    {
        foreach (var item in ExisitingPatients)
        {
            Insert.IntoTable(Tables.Patient).Row(new
            {
                first_name = item.FirstName,
                last_name = item.LastName,
                email = item.Email,
                address = item.Address,
                assigned_doctor_id = item.AssignedDoctorID
            });
        }
    }
    public override void Down()
    {

    }

}
