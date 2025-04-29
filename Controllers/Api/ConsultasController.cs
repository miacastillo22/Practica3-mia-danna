using Microsoft.AsNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/consultas")]
public class ConsultasdController : Controller {
    public IActionResult LIstarVuelos(){
        return Ok();
    }
}