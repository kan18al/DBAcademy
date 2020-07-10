using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DBAcademy
{
    public class User
    {
        [Key]
        [ForeignKey("Authorization")]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        public Authorization Authorization { get; set; }
    }
}
