using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternExample.Data.Entities;

[Table("Blog")]
public class Blog : EntityBase
{
    [Required]
    [StringLength(70, ErrorMessage = "Subject name must be less than 70 character")]
    public required string Subject { get; set; }
    [Required]
    [StringLength(100, ErrorMessage = "Content name must be less than 100 character")]

    public required string Content { get; set; }
    public Guid CategoryId { get; set; }
}
