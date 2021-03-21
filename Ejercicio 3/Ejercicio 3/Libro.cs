using System;

namespace Libro
{
    class Libro
    {
        private string autor;
        private string titulo;
        private string genero;
        private string editorial;
        private int anopublicacion;
        private string fechaPrestamo;
        private string fechaDevolucion;

        //Constructor por defecto
        public Libro()
        {
            autor = "Desconocido";
            titulo = "Desconocido";
            genero = "Desconocido";
            editorial = "Desconocido";
            anopublicacion = 0;
            fechaPrestamo = "";
            fechaDevolucion = "";
        }

        //Constructor con parametros
        public Libro(string Autor, string Titulo, string Genero, string Editorial, int publicacion)
        {
            autor = Autor;
            titulo = Titulo;
            genero = Genero;
            editorial = Editorial;
            anopublicacion = publicacion;
            fechaPrestamo = "";
            fechaDevolucion = "";

        }

        //Setter
        public void setAutor(string Autor)
        {
            autor = Autor;
        }

        public void setTitulo(string Titulo)
        {
            titulo = Titulo;
        }

        public void setGenero(string Genero)
        {
            genero = Genero;
        }

        public void setEditorial(string Editorial)
        {
            editorial = Editorial;
        }

        public void setAnoPublicacion(int Publicacion)
        {
            anopublicacion = Publicacion;
        }

        public void setFechaPrestamo(string fecha_prestamo)
        {
            fechaPrestamo = fecha_prestamo;
        }

        public void setFechaDevolucion(string fecha_devolucion)
        {
            fechaDevolucion = fecha_devolucion;
        }

        //Getters
        public string getTitulo()
        {
            return titulo;
        }

        public string getGenero()
        {
            return genero;
        }

        public string getAutor()
        {
            return autor;
        }

        public string getEditorial()
        {
            return editorial;
        }
        public string getAnoPublicacion()
        {
            return anopublicacion.ToString();
        }

        public string getFechaPrestamo()
        {
            return fechaPrestamo;
        }

        public string getFechaDevolucion()
        {
            return fechaDevolucion;
        }
        public void getInformacion()
        {
            Console.WriteLine("Los datos del libro son:");
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Titulo: " + titulo);
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Año de Publicacion: " + anopublicacion);
            Console.WriteLine("Editorial: " + editorial);            
        }

        //Metodos
        public void Prestamo(string fecha_prestamo)
        {
            fechaPrestamo = fecha_prestamo;
        }

        public void Devolucion(string fecha_devolucion)
        {
            fechaDevolucion = fecha_devolucion;
        }

        static void Main(String[] args)
        {
            string Autor;
            string Titulo;
            string Genero;
            string Editorial;
            int Publicacion;
            string FechaPrestamo;
            string FechaDevolucion;
            string Respuesta;

            Console.WriteLine("Bienvenido!");
            Console.WriteLine("");
            Console.WriteLine("Introduce la informacion del libro: ");
            Console.Write("Autor: ");
            Autor = Console.ReadLine();
            Console.Write("Titulo: ");
            Titulo = Console.ReadLine();
            Console.Write("Genero: ");
            Genero = Console.ReadLine();
            Console.Write("Editorial: ");
            Editorial = Console.ReadLine();
            Console.Write("Año de Publicacion: ");
            Publicacion = Int32.Parse(Console.ReadLine());
            
            Libro Libro1 = new Libro(Autor, Titulo, Genero, Editorial, Publicacion);

            Console.WriteLine("Introduce P si quieres prestarte el libro o D si deseas devolverlo: ");
            Respuesta = Console.ReadLine().ToLower();
            if (Respuesta == "p")
            {
                Console.WriteLine("Introduce la fecha de prestamo en el formato (MM/DD/AA)");
                FechaPrestamo = Console.ReadLine();
                Libro1.setFechaPrestamo(FechaPrestamo);
            }
            else
            {
                if (Respuesta == "d")
                {
                    Console.WriteLine("Introduce la fecha de prestamo en el formato (MM/DD/AA)");
                    FechaPrestamo = Console.ReadLine();
                    Libro1.setFechaDevolucion(FechaPrestamo);
                    Console.WriteLine("Introduce la fecha de devolucion en el formato (MM/DD/AA)");
                    FechaDevolucion = Console.ReadLine();
                    Libro1.setFechaDevolucion(FechaDevolucion);
                }
                else
                {
                    Console.WriteLine("No existe la opcion ingresada");
                }
            }
            Libro1.getInformacion();
            Libro1.setAutor("PEPE Arturo");
            Libro1.getInformacion();
        }

    }
}
