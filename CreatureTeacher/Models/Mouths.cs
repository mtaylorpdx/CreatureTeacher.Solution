using System.Collections.Generic;

namespace CreatureTeacher.Models
{
  public class Mouth 
  {
    public int MouthId { get; set; }
    public string Codon { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Creature> Creatures { get; set; }
    public Mouth()
    {
      this.Creatures = new HashSet<Creature>();
    }
  }
}