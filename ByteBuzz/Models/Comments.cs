using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteBuzz.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The UserName is Required")]
        [MaxLength(100, ErrorMessage = "The UserName Cannot Exceed 100 Characters")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostId {  get; set; }

        public Post Post { get; set; }
    }
}
