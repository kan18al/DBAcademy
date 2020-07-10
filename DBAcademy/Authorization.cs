using System.ComponentModel.DataAnnotations;

namespace DBAcademy
{
    public class Authorization
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User User { get; set; }
    }
}
