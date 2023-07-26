using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternExample.Data.Entities;

[Table("Category")]
public class Category:EntityBase
{
    [Required]
    [StringLength(30)]
    public required string Name { get; set; }
}
