using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Alumno
    {
        string nombre;

        string carrera;

        int matricula;

        int semestre;

        public Alumno(string nombre, string carrera, int matricula, int semestre)
        {
        this.nombre = nombre;

        this.carrera = carrera;

        this.matricula = matricula;
        
        this.semestre = semestre;

        }

        public int ConsultarPorMatricula(int matricula)
        {
            for (int i = 0; i < alumnosSet.Count; i++)
            {
                if (alumnosSet[i].matricula == matricula)
                {
                    return AlumnosSet.matricula;
                }
            }
        }

        

    }
}