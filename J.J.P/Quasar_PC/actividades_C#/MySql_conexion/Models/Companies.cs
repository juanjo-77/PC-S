namespace MySql_Conexion.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Industria { get; set; }
        public string Pais { get; set; }
        public int UsuarioId { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Industria: {Industria}, Pais: {Pais}, UsuarioID: {UsuarioId}";
        }
    }
}