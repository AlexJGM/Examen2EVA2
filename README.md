# Examen  
Exámen de comprobación de conocimientos sobre pruebas unitarias y TDD

## Enunciado
Se te proporcionan dos proyectos `dotnet` para realizar las *Pruebas Unitarias* asociadas a un `Sistema`.  
Nuestro `Sistema` consta de un tipo de datos `Persona`. Con atributos/propiedades como el nombre, la edad, y el sexo, que tendrás que codificar.

El `Sistema` tiene como finalidad indicarnos si una `Persona` puede tener descendencia natural con otra `Persona`.


**Objetivo del Sistema**   
Dos personas pueden tener descendencia si son de distinto sexo, su edad no difiere en más de 12 años, y pertenecen a rangos de edad consecutivos. Modela el `RangoDeEdad` como un atributo o un metodo del tipo Persona.

**Rangos de Edad**:  
- 0-19 MuyJoven  
- 20-29 Joven  
- 30-39 Plenitud  
- 40-49 Madurez  
- 50.. Vejez  

Nuestro Sistema tendrá codificados 10+ personas, y constará de `2 métodos` uno que indica si dos personas `AdmitenDescendencia`, y otro que calculará las `PosibleParejas` entre todos las personas anteriores.

_Sobre el primer método_:  
Dibuja en una hoja, identificada con tu nombre, el `diagrama de flujo`, `calcula la complejidad ciclomática` y presenta una tabla con el diseño de las `pruebas unitarias` que vas a realizar. 

_Para subir nota_:  
Programa el segundo método.

## Entrega
  La entrega se realiza subiendo el proyecto a un repositorio `Git` de acceso público que tu profesor evaluará. Introduce tu nombre y la url a tu repositorio en este documento.
  Se pide que en un (documento)[https://docs.google.com/document/d/1jgvz3u1SCS6zmqXtNA4e5FnsMvDf2lnLji2syLJzpZk/edit?usp=sharing] PDF/md, que muestra explicación y las capturas de pantalla que demuestran que tu programa y los test son correctos.

## Preparación
Utiliza los proyectos que tú hayas creado en clase o la siguiente plantilla:
```
   git clone https://github.com/srlopez/Examen2EVPruebasUnitarias2Base.git
   cd Examen2EVPruebasUnitarias2Base
   rd /q/s .git
```
Los datos proporcionados en ella, son orientativos y para que los adaptes a tu desarrollo.  
Ejecutando en Windows los comandos anteriores, obtienes dos proyectos, uno del `Sistema` y otro de `pruebas unitarias` preparado para los tests. El último comando borra cualquier traza del origen en github, para que tú puedas realizar los necesarios para subirlo a al repositorio que crees para la entrega.  
Limpia el código que no sea necesario. 

