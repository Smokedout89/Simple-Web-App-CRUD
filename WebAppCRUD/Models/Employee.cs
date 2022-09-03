namespace WebAppCRUD.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [DisplayName("Full Name")]
        [Column(TypeName = "nvarchar(250)")]
        public string FullName { get; set; }

        [DisplayName("Employee Code")]
        [Column(TypeName = "varchar(10)")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}