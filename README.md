# 📦 **InventoryApp: Sistema de Kardex para Inventarios**

**InventoryApp** es una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms** o **WPF**, diseñada para gestionar inventarios a través de un completo sistema **Kardex**. Esta aplicación utiliza **SQL Server** como base de datos y permite un control detallado de entradas, salidas y existencias de productos.  

---

## ✨ **Características principales**  
- **📋 Gestión de inventarios:** Administra entradas, salidas y stock de productos.  
- **📈 Kardex detallado:** Genera un registro completo del movimiento de inventarios.  
- **🛠️ Interfaz intuitiva:** Desarrollada con Visual Studio para una experiencia de usuario fluida.  
- **🗄️ Base de datos personalizada:** El archivo `BaseDeDatos.txt` contiene los scripts necesarios para crear la base de datos en **SQL Server**.  

---

## 🛠️ **Tecnologías utilizadas**  
- **C#:** Desarrollo de la lógica de negocio y la interfaz gráfica.  
- **Visual Studio:** Entorno de desarrollo integrado (IDE).  
- **SQL Server:** Base de datos relacional para almacenar los datos del inventario.  
- **ADO.NET:** Comunicación con la base de datos.  

---

## ⚙️ **Instalación y configuración**  

### 1️⃣ Requisitos previos  
- **Visual Studio 2019+** con el paquete de desarrollo para C#.  
- **SQL Server 2017+** instalado y configurado.  
- **.NET Framework 4.7.2+** o **.NET 5+**, según el proyecto.  

### 2️⃣ Creación de la base de datos  
1. Encuentra el archivo `BaseDeDatos.txt` en la raíz del proyecto.  
2. Abre **SQL Server Management Studio (SSMS)**.  
3. Copia y pega el contenido de `BaseDeDatos.txt` en una nueva consulta.  
4. Ejecuta el script para crear la base de datos y las tablas necesarias.  

### 3️⃣ Configuración del proyecto  
1. Abre el proyecto en Visual Studio.  
2. En el archivo `App.config` (o `appsettings.json`, dependiendo del framework):  
   - Configura la cadena de conexión con tu instancia de SQL Server. Ejemplo:  
     ```xml
     <connectionStrings>
       <add name="InventoryDB" connectionString="Server=MI_SERVIDOR;Database=InventoryAppDB;User Id=USUARIO;Password=CONTRASEÑA;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```  
3. Compila y ejecuta el proyecto desde Visual Studio.  

---

## 📊 **Funcionalidades principales**  
1. **Control de inventario:**  
   - Registro de entradas y salidas de productos.  
   - Actualización automática de existencias.  
2. **Configuración flexible:**  
   - Permite agregar categorías y personalizar productos.  

---

---

## 🤝 **Contribuciones**  
¿Tienes ideas o mejoras para **InventoryApp**?  
- Abre un **Issue** para sugerir características o reportar errores.  
- Envía un **Pull Request** con tu contribución.  

---

💡 **Nota:**  
Este proyecto está diseñado para ejecutarse localmente y es ideal para negocios pequeños o medianos que buscan un sistema de gestión de inventarios robusto y personalizable.  
