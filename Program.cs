using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> nombresDeAlumnos = new List<string>();
          nombresDeAlumnos.Add("Ramiro");
          nombresDeAlumnos.Add("Ramon");
          nombresDeAlumnos.Add("Roberto");
          nombresDeAlumnos.Add("Rodolfo");
          nombresDeAlumnos.Add("Reinaldo");
          nombresDeAlumnos.Add("Rafael");
          nombresDeAlumnos.Add("Rodrigo");
          nombresDeAlumnos.Add("Regina");
          nombresDeAlumnos.Add("Ramses");
          nombresDeAlumnos.Add("Rachel");

          List<string> nombresDeAlumnosSet = new List<string>();
          nombresDeAlumnosSet.Add("Ramiro");
          nombresDeAlumnosSet.Add("Ramon");
          nombresDeAlumnosSet.Add("Roberto");
          nombresDeAlumnosSet.Add("Rodolfo");
          nombresDeAlumnosSet.Add("Reinaldo");
          nombresDeAlumnosSet.Add("Rafael");
          nombresDeAlumnosSet.Add("Rodrigo");
          nombresDeAlumnosSet.Add("Regina");
          nombresDeAlumnosSet.Add("Ramses");
          nombresDeAlumnosSet.Add("Rachel");

          Console.WriteLine("Cant. de Alumnos en lista nombres de alumnos: " + nombresDeAlumnos.Count);
          Console.WriteLine("Cant. de Alumnos en lista nombres de alumnosSet: " + nombresDeAlumnosSet.Count);

            HashSet<Alumno> alumnosSet = new HashSet<Alumno>();
            alumnosSet.Add(new Alumno("Ramiro","Derecho", 3002, 3));
            alumnosSet.Add(new Alumno("Ramiro","Danza", 2504, 3));
            alumnosSet.Add(new Alumno("Ramon","Arquitectura", 3502, 2));
            alumnosSet.Add(new Alumno("Roberto","Ing. Mecanica", 7816, 6));
            alumnosSet.Add(new Alumno("Rodolfo","Ing.Sistemas", 7919, 9));
            alumnosSet.Add(new Alumno("Regina","Danza", 2556, 3));
            alumnosSet.Add(new Alumno("Ramses","Danza", 2506, 3));

            Console.WriteLine("Cant. de alumnos en AlumnosSet: " + alumnosSet.Count);
            
            Dictionary<String, String> semestreDeAlumnosEnTercero = new Dictionary<string, string>();
            semestreDeAlumnosEnTercero.Add("Ramiro", "3er semestre de Derecho");
            semestreDeAlumnosEnTercero.Add("Regina", "3er semestre de Danza");
            semestreDeAlumnosEnTercero.Add("Ramses", "3er semestre de Danza");

            //if (semestreDeAlumnosEnTercero.TryGetValue("Ramiro", out string semestreDeAlumnosEnTercero))
            //{
            //    Console.WriteLine("semestreDeAlumnosEnTercero" + semestreDeAlumnosEnTercero);
            //} 
            //else
            //{
            //    Console.WriteLine("Ramiro no esta en tercero.");
            //}

            Console.WriteLine("------");
            Console.WriteLine("Lista");
            for (int i = 0; i < nombresDeAlumnos.Count; i++)
            {
                Console.WriteLine(nombresDeAlumnos[i]);
            }

            
         //  Console.WriteLine("-------");
         //  Console.WriteLine("Set");
         // foreach (String nombresDeAlumnos in nombresDeAlumnosSet )
         // {
         //     Console.WriteLine("lista: " + nombresDeAlumnos);
         // }
            Console.WriteLine("-------");
            Console.WriteLine("Dictionary");
            foreach (var key in semestreDeAlumnosEnTercero)
            {
                Console.WriteLine(key);
            }

            foreach (var value in semestreDeAlumnosEnTercero.Values)
            {
                Console.WriteLine(value);
            }

            
        }    
    }
}