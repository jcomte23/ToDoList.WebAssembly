using ToDoList.WebAssembly.Models;

namespace ToDoList.WebAssembly.Services;

public class TareaService
{
    private readonly List<Tarea> _tareas = [
        new Tarea("Comprar frutas y verduras 🍎🥦"),
        new Tarea("Lavar el carro 🚗"),
        new Tarea("Pasear al perro 🐶"),
        new Tarea("Hacer ejercicio 30 minutos 🏃‍♂️"),
        new Tarea("Leer un capítulo del libro 📖"),
        new Tarea("Enviar correo al jefe 📧"),
        new Tarea("Preparar la cena 🍝"),
        new Tarea("Organizar escritorio 🗂️"),
        new Tarea("Regar las plantas 🌱"),
        new Tarea("Ver un episodio de la serie favorita 📺")
    ];

    public IEnumerable<Tarea> ObtenerTodas() => _tareas;

    public Tarea? ObtenerPorId(Guid id) => _tareas.FirstOrDefault(t => t.Id == id);

    public void Agregar(string descripcion)
    {
        var tarea = new Tarea(descripcion);
        _tareas.Add(tarea);
    }

    public void Actualizar(Guid id, string nuevaDescripcion, bool completada)
    {
        var tarea = ObtenerPorId(id);
        if (tarea is not null)
        {
            tarea.Descripcion = nuevaDescripcion;
            tarea.Completada = completada;
        }
    }

    public void Eliminar(Guid id)
    {
        var tarea = ObtenerPorId(id);
        if (tarea is not null)
        {
            _tareas.Remove(tarea);
        }
    }
}
