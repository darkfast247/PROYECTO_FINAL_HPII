using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    public class Usuario
    {

        // Clase base

        string CorreoInstitucional;
        string DocumentoIdentidad;
        string nombre;
        string contrasena;

        public Usuario(string correoInstitucional, string contrasena)
        {
            CorreoInstitucional1 = correoInstitucional;
            this.contrasena = contrasena;
        }

        public Usuario(string correoInstitucional, string documentoIdentidad, string nombre, string contrasena)
        {
            CorreoInstitucional = correoInstitucional;
            DocumentoIdentidad = documentoIdentidad;
            this.nombre = nombre;
            this.contrasena = contrasena;
        }

        public string CorreoInstitucional1 { get => CorreoInstitucional; set => CorreoInstitucional = value; }
        public string DocumentoIdentidad1 { get => DocumentoIdentidad; set => DocumentoIdentidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public bool Validar(string _correoinstitucional, string _contrasena)
        {
            bool ban = false;

            if (CorreoInstitucional1 == _correoinstitucional && Contrasena == _contrasena)
            {
                ban = true;
            }

            return ban;
        }
    }

    // Clase derivada Estudiante
    public class Estudiante : Usuario
    {
        public Estudiante(string correoInstitucional, string documentoIdentidad, string nombre, string contrasena) : base(correoInstitucional, documentoIdentidad, nombre, contrasena)
        {
        }

        public string Programa { get; set; }
    }

    // Clase derivada Video
    public class Video : Usuario
    {
        public Video(string correoInstitucional, string documentoIdentidad, string nombre, string contrasena) : base(correoInstitucional, documentoIdentidad, nombre, contrasena)
        {
        }

        public string Titulo { get; set; }
        public string Asignatura { get; set; }
        public string Descripcion { get; set; }

        public void SubirVideo()
        {
            // Lógica para subir un video
        }

        public void ModificarVideo()
        {
            // Lógica para modificar un video
        }

        public void EliminarVideo()
        {
            // Lógica para eliminar un video
        }
    }

    // Clase derivada Ejercicios
    public class Ejercicios : Usuario
    {
        public Ejercicios(string correoInstitucional, string documentoIdentidad, string nombre, string contrasena) : base(correoInstitucional, documentoIdentidad, nombre, contrasena)
        {
        }

        public string Titulo { get; set; }
        public string Asignatura { get; set; }
        public string Descripcion { get; set; }

        public void SubirPublicacion()
        {
            // Lógica para subir una publicación de ejercicios
        }

        public void ModificarPublicacion()
        {
            // Lógica para modificar una publicación de ejercicios
        }

        public void EliminarPublicacion()
        {
            // Lógica para eliminar una publicación de ejercicios
        }
    }

    // Clase Material
    public class Material
    {
        // Lógica para almacenar y gestionar materiales
    }

    // Clase derivada Administrador
    public class Administrador : Usuario, IAdministrador
    {
        public Administrador(string correoInstitucional, string documentoIdentidad, string nombre, string contrasena) : base(correoInstitucional, documentoIdentidad, nombre, contrasena)
        {
        }

        public void AceptarPublicacion()
        {
            // Lógica para aceptar una publicación
        }

        public void AceptarVideo()
        {
            // Lógica para aceptar un video
        }

        public void EliminarPublicacion()
        {
            // Lógica para eliminar una publicación
        }

        public void EliminarVideo()
        {
            // Lógica para eliminar un video
        }
    }


}

