namespace ExamenPractico1clave2
{
    class Program
{
    static string[] artista = new string[10];
    static string[] titulo = new string[10];
    static int[] duracion = new int[10];
    static int[] tamano = new int[10];
    static int totalCanciones = 0;

    static int[] codigo = new int[10];
    static string[] nombre = new string[10];
    static DateTime[] fechaNacimiento = new DateTime[10];
    static string[] grado = new string[10];
    static int[] anoRegistro = new int[10];
    static int totalAlumnos = 0;

    static void Main(string[] args)
    {
        bool menuInicio = true;

        while (menuInicio)
        {
            Console.WriteLine("MENÚ PRINCIPAL:");
            Console.WriteLine("1- Gestión Canciones (mp3)");
            Console.WriteLine("2- Gestión Alumnos");
            Console.WriteLine("3- Salir");
            Console.Write("Por favor seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    GestionCancion();
                    break;
                case 2:
                    GestionAlumnos();
                    break;
                case 3:
                    menuInicio = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida,intentelo de nuevo.");
                    break;
            }
        }
    }

    static void GestionCancion()
    {
        bool regresar = false;

        do
        {
            Console.WriteLine("Menú de Gestión de Canciones:");
            Console.WriteLine("1- Agregar una canción");
            Console.WriteLine("2- Mostrar lista de canciones");
            Console.WriteLine("3- Volver al menú principal");
            Console.Write("Por favor seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarCancion();
                    break;
                case 2:
                    MostrarCanciones();
                    break;
                case 3:
                    regresar = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (!regresar);
    }

    static void AgregarCancion()
    {
        Console.WriteLine("Ingrese el nombre del artista: ");
        artista[totalCanciones] = Console.ReadLine();
        Console.Write("Ingrese el título de la canción: ");
        titulo[totalCanciones] = Console.ReadLine();
        Console.WriteLine("Ingrese la duración en segundos: ");
        duracion[totalCanciones] = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tamaño del fichero en KB: ");
        tamano[totalCanciones] = int.Parse(Console.ReadLine());

        totalCanciones++;

        Console.WriteLine("Canción agregada exitosamente.");
    }

    static void MostrarCanciones()
    {
        Console.WriteLine("Lista de Canciones:");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("| Artista          | Título           | Duración  | Tamaño(KB) |");
        Console.WriteLine("----------------------------------------------------------------");

        for (int i = 0; i < totalCanciones; i++)
        {
            Console.WriteLine($"| {artista[i],-16} | {titulo[i],-16} | {duracion[i],-10} | {tamano[i],-11} |");
        }

        Console.WriteLine("---------------------------------------------------------------");
    }

    static void GestionAlumnos()
    {
        bool regresar = false;

        do
        {
            Console.WriteLine("Menú de Gestión Alumnos:");
            Console.WriteLine("1- Agregar un alumno");
            Console.WriteLine("2- Mostrar lista de alumnos");
            Console.WriteLine("3- Buscar alumno por código");
            Console.WriteLine("4- Editar información de un alumno por código");
            Console.WriteLine("5- Volver al menú principal");
            Console.Write("Elija una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarAlumnos();
                    break;
                case 3:
                    BuscarAlumnoPorCodigo();
                    break;
                case 4:
                    EditarAlumnoPorCodigo();
                    break;
                case 5:
                    regresar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (regresar);
    }

    static void AgregarAlumno()
    {
        Console.WriteLine("Ingrese el código del alumno: ");
        codigo[totalAlumnos] = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre completo del alumno: ");
        nombre[totalAlumnos] = Console.ReadLine();
        Console.WriteLine("Ingrese la fecha de nacimiento (DD-MM-YYYY): ");
        fechaNacimiento[totalAlumnos] = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el grado del alumno: ");
        grado[totalAlumnos] = Console.ReadLine();
        Console.Write("Ingrese el año de registro (DD-MM-YYYY): ");
        anoRegistro[totalAlumnos] = int.Parse(Console.ReadLine());

        totalAlumnos++;

        Console.WriteLine("Alumno agregado exitosamente.");
    }

    static void MostrarAlumnos()
    {
        Console.WriteLine("Lista de Alumnos:");
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("| Código   | Nombre Completo        | Fecha de Nacimiento | Grado | Año de Registro |");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        for (int i = 0; i < totalAlumnos; i++)
        {
            Console.WriteLine($"| {codigo[i],-9} | {nombre[i],-23} | {fechaNacimiento[i].ToString("dd-MM-yyyy"),-20} | {grado[i],-6} | {anoRegistro[i].ToString("dd-MM-yyyy"),-15} |");
        }

        Console.WriteLine("------------------------------------------------------------------------------------");
    }

    static void BuscarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a buscar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());

        int indice = -1;

        for (int i = 0; i < totalAlumnos; i++)
        {
            if (codigo[i] == codigoBuscado)
            {
                indice = i;
                break;
            }
        }

        if (indice != -1)
        {
            Console.WriteLine("Información del alumno encontrado:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Código: {codigo[indice]}");
            Console.WriteLine($"Nombre Completo: {nombre[indice]}");
            Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento[indice].ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Grado: {grado[indice]}");
            Console.WriteLine($"Año de Registro: {anoRegistro[indice].ToString("dd-MM-yyyy")}");
            Console.WriteLine("---------------------------------------------");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }

    static void EditarAlumnoPorCodigo()
    {
        Console.WriteLine("Ingrese el código del alumno a editar: ");
        int codigoBuscado = int.Parse(Console.ReadLine());

        int indice = -1;

        for (int i = 0; i < totalAlumnos; i++)
        {
            if (codigo[i] == codigoBuscado)
            {
                indice = i;
                break;
            }
        }

        if (indice != -1)
        {
            Console.WriteLine("Información actual del alumno:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Código: {codigo[indice]}");
            Console.WriteLine($"Nombre Completo: {nombre[indice]}");
            Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento[indice].ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Grado: {grado[indice]}");
            Console.WriteLine($"Año de Registro: {anoRegistro[indice].ToString("dd-MM-yyyy")}");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Ingrese la nueva información:");

            Console.Write("Nombre Completo: ");
            nombre[indice] = Console.ReadLine();

            Console.WriteLine("Fecha de Nacimiento (DD-MM-YYYY): ");
            fechaNacimiento[indice] = DateTime.Parse(Console.ReadLine());

            Console.Write("Grado: ");
            grado[indice] = Console.ReadLine();

            Console.WriteLine("Año de Registro (DD-MM-YYYY): ");
            anoRegistro[indice] = int.Parse(Console.ReadLine());

            Console.WriteLine("Información del alumno actualizada.");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }
}

}