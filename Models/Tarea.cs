namespace ToDoList.WebAssembly.Models;

public class Tarea(string descripcion)
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Descripcion { get; set; } = descripcion;
    public bool Completada { get; set; } = false; // Por defecto, la tarea inicia como pendiente
}
