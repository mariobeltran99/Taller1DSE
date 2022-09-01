using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BG171969Taller1.Models
{
    public class Employee
    {
        [Key] public int id { get; set; }
        [Display(Name = "Código")]
        public int code { get; set; }
        [Display(Name = "Nombres")]
        public string name { get; set; }
        [Display(Name = "Apellidos")]
        public string surname { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateBirthday { get; set; }
        [Display(Name = "Dirección")]
        public string address { get; set; }
        [Display(Name = "Teléfono")]
        public int phone { get; set; }
        [Display(Name = "Cargo")]
        public string position { get; set; }
        [Display(Name = "Salario Base")]
        public decimal salaryBase { get; set; }
    }
    public class EmployeeDBContext: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}