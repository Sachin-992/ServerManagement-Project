using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0? false : true;  //ternary operator 
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; } //The ? after string allows it to hold null values.
        [Required]
        public string? City { get; set; }
    }
}
