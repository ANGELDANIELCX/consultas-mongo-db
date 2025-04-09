using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/in")]
public class InController : Controller {
    [HttpGet("inmuebles-que-sean-casa-o-departamento")]
    public IActionResult ListarPorpiedadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

        var tipos = new List<string> { "Casa", "Departamento" };
        var filtroTipo = Builders<Inmueble>.Filter.In(x => x.Tipo, tipos);
        var inmueblesTipo = collection.Find(filtroTipo).Limit(5).ToList();
        return Ok(inmueblesTipo);
        }
    
        [HttpGet("inmuebles-de-torresRealty-o-FernándezInmuebles")]
    public IActionResult InmueblesDeTorresRealtyoFernandezInmuebles(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

        var agencias = new List<string> { "Torres Realty", "Fernández Inmuebles" };
        var filtroAgencia = Builders<Inmueble>.Filter.In(x => x.Agencia, agencias);
        var inmueblesAgencia = collection.Find(filtroAgencia).Limit(5).ToList();
return Ok(inmueblesAgencia);
    }

    [HttpGet("inmuebles-que-sean-casa-o-departamento")]
    public IActionResult ListarPorpiedadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");
    }

    [HttpGet("inmuebles-que-sean-casa-o-departamento")]
    public IActionResult ListarPorpiedadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");
    }

    [HttpGet("inmuebles-que-sean-casa-o-departamento")]
    public IActionResult ListarPorpiedadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");
    }
}