using System.ComponentModel.DataAnnotations;

namespace Demo_Asp_DotNetCoreWebAPI;

public class VillaNumberDTO
{
    [Required]
    public int VillaNo { get; set; }

    [Required]
    public int VillaID { get; set; }

    public string SpecialDetails { get; set; }

    public VillaDTO Villa { get; set; }
}
