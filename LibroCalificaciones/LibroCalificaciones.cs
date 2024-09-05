public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso para este LibroCalificaciones
    //propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }// fin del get
        set
        {
            nombreCurso = value;
        }// fin del set
    }//fin de la propiedad nombreCurso

    //muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    public void MostrarMensaje()
    {
        //usa la propiedad NombreCurso para obtener el nombre del curso representa este LibroCalificaciones
        Console.WriteLine("bienvenido al libro de claificaciones para \n{0]", NombreCurso); // muestra la propiedad NombreCurso

    }// fi del metodo MostrarMensaje
}// fin de la clase LibroCaificaciones

    