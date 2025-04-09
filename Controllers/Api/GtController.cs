using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller{
    [HttpGet("casas-venta-metros-terrono")]
    public IActionResult CasaEnventaConMasDeXMetrosTerrono(int metrosConstruccion){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //Obtener todas las casas en ventas mas de 500 metros de construccion 
        var filtroCasas = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
        var filtroVenta = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");
        var filtroMetros = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, metrosConstruccion);

        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroCasas, filtroVenta, filtroMetros);
        var list = collection.Find(filtroCompuesto).ToList();
        return Ok(list);
    }

[HttpGet("inmuebles-costo-mayor-cien-mil")]
    public IActionResult InmueblesCostoMayorCienMil(int metrosConstruccion){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCosto = Builders<Inmueble>.Filter.Gt(x => x.Costo, 1000000);
        var inmueblesCosto = collection.Find(filtroCosto).Limit(5).ToList();
        return Ok(inmueblesCosto);
    }

[HttpGet("inmuebles-de-mas-de-dos-pisos")]
    public IActionResult InmueblesDeMasDeDosPisos(int metrosConstruccion){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroPisos = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
        var inmueblesPisos = collection.Find(filtroPisos).Limit(5).ToList();
        return Ok(inmueblesPisos);
    }


    [HttpGet("inmuebles-con-mas-de-trescientos-metros-cuadrados")]
    public IActionResult  InmueblesConMasDeTrescientosMetrosCuadrados(int metrosConstruccion){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroConstruccion = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 300);
        var inmueblesConstruccion = collection.Find(filtroConstruccion).Limit(5).ToList();
        return Ok(inmueblesConstruccion);
    }


    [HttpGet("inmuebles-con-mas-de-dos-baños")]
    public IActionResult InmueblesConMasDeDosBaños(int metrosConstruccion){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroBanos = Builders<Inmueble>.Filter.Gt(x => x.Banios, 2);
        var inmueblesBanos = collection.Find(filtroBanos).Limit(5).ToList();
        return Ok(inmueblesBanos);
    }

}