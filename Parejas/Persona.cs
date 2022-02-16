namespace Parejas
{
    public class Persona
    {
        public enum rango{
            MuyJoven,Joven,Plenitud,Madurez,Vejez
        }

        public Persona( string nombre, int edad, char sexo) {
            this.edad = edad;
            this.sexo = sexo;
            this.nombre = nombre;
        }
        public char sexo {get;set;}
        public string nombre {get; set;}
        public int edad {get; set;}
        

        public rango rangoEdad() {
             switch (edad)
    {
        case < 20:
            return rango.MuyJoven;
        case < 30:
            return rango.Joven;
        case < 40:
            return rango.Plenitud;
        case < 50:
            return rango.Madurez;
        default:
            return rango.Vejez;
    }
}


        public override string ToString() => nombre+" "+edad+" "+sexo;
    }
}