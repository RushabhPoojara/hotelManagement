using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Asp_DotNetCoreWebAPI.Controllers.v2;

// [Route("api/[controller]")]
[Route("api/v{version:apiVersion}/VillaNumberAPI")]
[ApiController]
[ApiVersion("2.0")]
public class VillaNumberAPIController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IVillaNumberRepository _dbVillaNumber;
    protected APIResponse _response;
    public readonly IVillaRepository _dbVilla;

    public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
    {
        _mapper = mapper;
        _dbVillaNumber = dbVillaNumber;
        this._response = new();
        _dbVilla = dbVilla;
    }

    // [MapToApiVersion("2.0")]
    [HttpGet("GetString")]
    public IEnumerable<string> Get()
    {
        return new string[] { "Rushabh", "Web API Beginner" };
    }
}
