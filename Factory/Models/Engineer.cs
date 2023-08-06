using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer name is needed")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "Engineer license is needed")]
    public int EngineerLicense { get; set; }
    [Required(ErrorMessage = "Engineer speciality is needed")]
    public string EngineerSpecialty { get; set; }

    public int MachineId { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }

  }
}