using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWeb_App
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AutoIncrement için bu ekleme yapılır
        public byte ID { get; set; }
        public string FullName { get; set; }
    }
}
