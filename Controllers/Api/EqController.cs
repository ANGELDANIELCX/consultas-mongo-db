using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-transaccion")]
   public IActionResult ListarTransaccion() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Venta");
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet("lista-de-propiedades")]
   public IActionResult ListarDePropiedades() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtroCasa = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
var casas = collection.Find(filtroCasa).ToList();
return Ok(casas);
}

[HttpGet("lista-de-terrenos")]
   public IActionResult ListaDeTerrenos() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtroTerreno = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
var terrenos = collection.Find(filtroTerreno).Limit(5).ToList();
return Ok(terrenos);
}

[HttpGet("lista-de-inmueble-carlos")]
   public IActionResult ListaDeInmuebleCarlos() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Carlos García");
var inmueblesAgente = collection.Find(filtroAgente).Limit(5).ToList();
return Ok(inmueblesAgente);
   
   }



[HttpGet("lista-de-inmobiliario-perez")]
   public IActionResult ListaDeInmobiliarioPerez() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Inmobiliaria Pérez");
var inmueblesAgencia = collection.Find(filtroAgencia).Limit(5).ToList();
return Ok(inmueblesAgencia);
}      
}