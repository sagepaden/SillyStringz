using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "Machine name is needed")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "Machine number is needed")]
    public int MachineNumber { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }
  }
}