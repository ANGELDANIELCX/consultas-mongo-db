using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/in")]
public class InController : Controller {
    [HttpGet("listar-propiedades-agencia-agente")]
    public IActionResult ListarPorpiedadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

        List<string> agentes = new List<string>();
        agentes.Add("Juan Pérez");
        agentes.Add("María López");
        agentes.Add("Ana Torres");

        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Inmboliaria Pérez");
        var filtroAgentes = Builders<Inmueble>.Filter.In(x => x.NombreAgente, agentes );
        return Ok();
    }
}