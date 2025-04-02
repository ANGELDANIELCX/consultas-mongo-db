using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [httpGet("listar-agencias")]
    public IActionResult ListarAgencias(){
        return Ok();
    }
}