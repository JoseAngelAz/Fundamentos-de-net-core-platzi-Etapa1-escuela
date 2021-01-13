using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela(
                                "Angel Escuela",
                                1993,
                                TiposEscuela.Primaria,
                                pais: "El Salvador",
                                ciudad: "San Salvador"
                                );

            //Creamos arreglo de cursos, la escuela.curso es igual a un nuevo
            //array de cursos
            escuela.Cursos = new Curso[]{
                    new Curso(){Nombre = "101"},
                    new Curso(){Nombre = "201"},
                    new Curso(){Nombre = "301"}
            };

            //escribir los cursos de la escuela
            ImprimirCUrsosEscuela(escuela);

        }

        private static void ImprimirCUrsosEscuela(Escuela escuela)
        {
            //validar si el arreglo viene vacio
            //corto circuito de expresion de evaluaciones
            //escuela.Cursos != null && escuela != null
            if (escuela?.Cursos != null)
            {
                WriteLine("===========================");
                WriteLine("Cursos de la Escuela");
                WriteLine("===========================");
                //recorrer array de la escuela con foreach

                foreach (var curso in escuela.Cursos)
                {
                    WriteLine(
                    $"Nombre: {curso.Nombre}\n" +
                    $"Id: {curso.UniqueId}"
                    );
                }

            }
            //si el array no es nulo 
            else
            {
                //return para salir de ese metodo
                return;
            }

        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine(
                $"Nombre: {curso.Nombre}\n" +
                $"Id: {curso.UniqueId}"
                );
            }
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine(
                $"Nombre: {arregloCursos[i].Nombre}\n" +
                $"Id: {arregloCursos[i].UniqueId}"
                );
            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {//formas de recorrer un arreglo

            //con un WHILE
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine(
                $"Nombre: {arregloCursos[contador].Nombre}\n" +
                $"Id: {arregloCursos[contador].UniqueId}"
                );
                contador++;
            }
        }
        //con DoWhile
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {//La diferencia es que recorrera desde la posicon 1 del array

            //con un DO-WHILE
            int contador = 0;
            do
            {
                WriteLine(
                $"Nombre: {arregloCursos[contador].Nombre}\n" +
                $"Id: {arregloCursos[contador].UniqueId}"
                );
                contador++;//aqui le sumamos 1 al cero
            } while (contador < arregloCursos.Length);//contador ya va en 1
        }
    }
}
