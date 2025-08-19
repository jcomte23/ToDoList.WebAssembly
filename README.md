# 📝 ToDoList.WebAssembly
Proyecto de ejemplo construido con .NET 8 Blazor WebAssembly. Implementa un CRUD básico de tareas (crear, leer, actualizar y eliminar) totalmente en memoria, con una interfaz moderna construida con Bootstrap y componentes Razor.

## 🚀 Características
- ✅ Crear tareas desde un formulario simple.

- 📋 Listar todas las tareas en una vista dinámica.

- ✏️ Editar tareas directamente en la lista.

- ✔️ Marcar tareas como completadas con checkbox.

- 🗑️ Eliminar tareas fácilmente.

- 🎨 Interfaz amigable con Bootstrap 5.

- 💡 Arquitectura sencilla con separación de Models, Services y Pages.


## 📂 Estructura del proyecto
```
ToDoList.WebAssembly/
│── Models/
│   └── Tarea.cs
│── Services/
│   └── TareaService.cs
│── Pages/
│   └── Index.razor
│── Shared/
│   └── MainLayout.razor
│── Program.cs
│── wwwroot/
│   └── css/bootstrap.min.css
```
## 🛠️ Tecnologías usadas

- Bootstrap

- .NET 8

- Blazor WebAssembly


## ⚡ Ejecución

1. Clona este repositorio:  
   ```bash
   git clone https://github.com/jcomte23/ToDoList.WebAssembly.git
   cd ToDoList.WebAssembly
   ```

2. Compila y ejecuta:  
   ```bash
   dotnet run
   ```

3. Abrir en el navegador:  
   ```bash
   https://localhost:xxxx
   ```

## 📜 Licencia

Este proyecto está licenciado bajo la GNU General Public License v3.0 (GPL-3.0).
Eres libre de usarlo, modificarlo y distribuirlo bajo los términos de esta licencia.

Más información en: https://www.gnu.org/licenses/gpl-3.0.html