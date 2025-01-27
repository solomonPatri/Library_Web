using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;


namespace Library_Web.Object.Model
{
    [Table("library")]

    public class Library
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }


        [Required]
        [Column("Name")]
        public string Name { get; set; }


        [Required]
        [Column("Places")]
        public int Places { get; set; }


        [Required]
        [Column("Address")]
        public string Address { get; set; }


        [Required]
        [Column("SoldBooks")]
        public int SoldBooks { get; set; }



        [Required]
        [Column("Inauguration")]
        public DateOnly Inauguration { get; set; }










    }




}