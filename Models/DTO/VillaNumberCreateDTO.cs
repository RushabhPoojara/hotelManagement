using System.ComponentModel.DataAnnotations;

namespace Demo_Asp_DotNetCoreWebAPI;

public class VillaNumberCreateDTO
{
    [Required]
    public int VillaNo { get; set; }

    [Required]
    public int VillaID { get; set; }

    public string SpecialDetails { get; set; }
}
