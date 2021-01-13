namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        //setter y getter para nombre
        public string Nombre{
            //devuelve nombre con el texto copia
            get {return nombre;}
                                //mayuscula
            set {nombre = value.ToUpper();}
        }
        //otra manera de encapsular 
        public int AñoDeCreacion{get;set;}
        //hecho con prop
        public string Pais { get; set; }
        //hecho con prop
        public string Ciudad { get; set; }

        //propiedad encapsulada tipo de Escuela
        public TiposEscuela TipoEscuela { get; set; }

        //propiedad encapsulada para los cursos
        public Curso[] Cursos { get; set; }
       
       //CONSTRUCTOR
       /* public Escuela(string nombre, int año)
       {
           this.Nombre = nombre;
           AñoDeCreacion = año;
       } */

       //otra forma de hacer CONSTRUCTOR mas corto
       //esto seria una igualacion por tuplas
       /* public Escuela(string nombre, int año) => (Nombre,AñoDeCreacion) = (nombre,año); */

        //CONSTRUCTOR con otra logica y parametros opcionales
        public Escuela(
            string nombre,
            int año,
            TiposEscuela tipos,
            string pais = "",
            string ciudad = ""
            ){//asignacion por tuplas
               (Nombre, AñoDeCreacion) = (nombre,año);
               Ciudad = ciudad;
             }

        //sobreescribir
        //este metodo devuelve un string
        public override string ToString()
        {
            return $"\nTodo esto es la copia:\n"+
            $"Nombre: {Nombre}\nTipo: {TipoEscuela}\n"+
            $"Pais: {Pais}\nCiudad: {Ciudad}";
        }
    }
}