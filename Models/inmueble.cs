using MongoDB.Bson.Serialization.Attributes;

public class Inmueble {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Tipo { get; set; } = string.Empty; 
    public string Operacion { get; set; } = string.Empty;
    public string NombreAgente { get; set; } = string.Empty;
    public int Banios { get; set; } 
    public int Banios 
}