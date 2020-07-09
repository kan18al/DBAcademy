using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DBAcademy
{
    public class User
    {
        [Key]
        [ForeignKey("authorization")]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        public Authorization authorization { get; set; }
    }
}
