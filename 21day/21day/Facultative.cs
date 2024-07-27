using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Facultative")]
class Facultative
{
    [Key]
    public int FacultativeId { get; set; }

    [Column("Title")]
    public string Title { get; set; }

    [Column("Hours")]
    public int Hours { get; set; }

    [Column("Type")]
    public string Type { get; set; }

    public Facultative(string title,int hours,string type)
    {
        Title = title;
        Hours = hours;
        Type = type;
    }
    public Facultative() { }
}
