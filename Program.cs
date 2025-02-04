//made by jheinel brown 
//matricula 20240017

namespace PooCSharp
{
    class MiembroDeLaComunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public MiembroDeLaComunidad(int id, string nombre, string apellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}");
        }
    }

    class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }
        public string Puesto { get; set; }

        public Empleado(int id, string nombre, string apellido, string departamento, string puesto)
            : base(id, nombre, apellido)
        {
            this.Departamento = departamento;
            this.Puesto = puesto;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Departamento: {Departamento}, Puesto: {Puesto}");
        }
    }

    class Alumno : MiembroDeLaComunidad
    {
        public string Grado { get; set; }

        public Alumno(int id, string nombre, string apellido, string grado)
            : base(id, nombre, apellido)
        {
            this.Grado = grado;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Grado: {Grado}");
        }
    }

    class ExAlumnos : MiembroDeLaComunidad
    {
        public string FechaGraduacion { get; set; }

        public ExAlumnos(int id, string nombre, string apellido, string fechaGraduacion)
            : base(id, nombre, apellido)
        {
            this.FechaGraduacion = fechaGraduacion;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Fecha de graduación: {FechaGraduacion}");
        }
    }

    class Docentes : Empleado
    {
        public string Especialidad { get; set; }

        public Docentes(int id, string nombre, string apellido, string departamento, string puesto, string especialidad)
            : base(id, nombre, apellido, departamento, puesto)
        {
            this.Especialidad = especialidad;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    }

    class Administrativo : Empleado
    {
        public string Estado { get; set; }

        public Administrativo(int id, string nombre, string apellido, string departamento, string puesto, string estado)
            : base(id, nombre, apellido, departamento, puesto)
        {
            this.Estado = estado;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Estado: {Estado}");
        }
    }

    class Administrador : Docentes
    {
        public string Responsabilidades { get; set; }

        public Administrador(int id, string nombre, string apellido, string departamento, string puesto, string responsabilidades)
            : base(id, nombre, apellido, departamento, puesto, "Administración")
        {
            this.Responsabilidades = responsabilidades;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Responsabilidades: {Responsabilidades}");
        }
    }

    class Maestro : Docentes
    {
        public string GradoAsignado { get; set; }
        public string Materia { get; set; }

        public Maestro(int id, string nombre, string apellido, string departamento, string puesto, string gradoAsignado, string materia)
            : base(id, nombre, apellido, departamento, puesto, "Docencia")
        {
            this.GradoAsignado = gradoAsignado;
            this.Materia = materia;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"Grado asignado: {GradoAsignado}, Materia: {Materia}");
        }
    }

    class Program
    {
        static void Main()
        {
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad(1, "Harry", "Potter");
            miembro.Imprimir();
            Console.WriteLine();

            Empleado empleado = new Empleado(20241234, "Germione", "Granger", "Biblioteca", "Asistente");
            empleado.Imprimir();
            Console.WriteLine();

            Alumno alumno = new Alumno(20240018, "Ron", "Weasly", "5to Grado");
            alumno.Imprimir();
            Console.WriteLine();

            ExAlumnos exAlumnos = new ExAlumnos(4, "Remus", "Lupin", "17/05/1978");
            exAlumnos.Imprimir();
            Console.WriteLine();

            Docentes docente = new Docentes(5, "Albert", "Dumblendore", "Dirección", "Director", "Magia");
            docente.Imprimir();
            Console.WriteLine();

            Administrativo administrativo = new Administrativo(6, "Sirius", "Black", "Salud", "Asistente", "Activo");
            administrativo.Imprimir();
            Console.WriteLine();

            Maestro maestro = new Maestro(7, "Severus", "Snape", "Pociones", "Profesor", "6to Grado", "Pociones Avanzadas");
            maestro.Imprimir();
            Console.WriteLine();


            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}