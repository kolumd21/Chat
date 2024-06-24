using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Message
    {
        [Key]
        public int id_message { get; set; }
        public string text_message { get; set; }
        public int id_group { get; set; }
        public long id_user { get; set; }
    }
}
