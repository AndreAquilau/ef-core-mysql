using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace AuthAPI.Models
{

    [Table("user")]
    public class User
    {
        [Key()]
        public int Id { get; set; }

        [Required()]
        [Column(name: "email", TypeName = "VARCHAR(100)")]
        public string Email { get; set; }

        [Required()]
        [Column(name: "senha", TypeName = "VARCHAR(1000)")]
        public string Senha { get; set; }

    }
}
