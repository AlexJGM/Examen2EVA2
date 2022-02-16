using System.Collections.Generic;
using System;

namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; } = new()
        {
         new Persona("Manuel",18,'M'),
         new Persona("Fernando",32,'M'),
         new Persona("Carmen",60,'F'),
         new Persona("Fernanda",31,'F'),
         new Persona("Alex",23,'M'),
         new Persona("Anuel",45,'M'),
         new Persona("Sara",15,'F'),
         new Persona("Luis",53,'M'),
         new Persona("Johan",63,'M'),
         new Persona("Irene",53,'F')
            
            
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            
            if(a.sexo != b.sexo && Math.Abs(a.rangoEdad()-b.rangoEdad())<=1 && Math.Abs(a.edad-b.edad)<=12)
                return true;

        
            return false;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();
        for(int i=0; i<personas.Count-1;i++){
                for (int j=i+1; j<personas.Count;j++){
                    if (AdmitenDescendencia(personas[i],personas[j]))
                        parejas.Add((personas[i],personas[j]));
                }
            }
           
            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}