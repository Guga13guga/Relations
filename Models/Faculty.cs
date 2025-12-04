using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models;
[Table("Faculties")]

public class Faculty : BaseModel
{
    public string? Building {  get; set; }

    public string ? Name { get; set; }

    [ForeignKey("Dean")]
    public int DeanId{ get; set; }

    public Dean? Dean { get; set; }

   // public List<Departament>? Departaments { get; set; }
}
