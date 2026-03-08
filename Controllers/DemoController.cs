using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DemoController : ControllerBase
{
    private readonly IGuidService _service1;
    private readonly IGuidService _service2;
    private readonly IGuidService _service3;

    public DemoController(IGuidService service1, IGuidService service2, IGuidService service3)
    {
        _service1 = service1;
        _service2 = service2;
        _service3 = service3;
    }

    [HttpGet]
    public string Get()
    {
        return $"Service1: {_service1.GetGuid()} \nService2: {_service2.GetGuid()} \nService3: {_service3.GetGuid()}";
    }
}