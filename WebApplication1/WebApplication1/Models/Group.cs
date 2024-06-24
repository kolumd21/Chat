using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Group
    {
        [Key]
        public int id_group { get; set; }
        public string group_name { get; set; }
    }
}
