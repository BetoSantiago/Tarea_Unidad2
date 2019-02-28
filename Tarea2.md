# <p align = "center"> Unidad 2. Clases y Objetos</p>

## Declaración de clases: atributos, métodos, encapsulamiento

**Lee y escribe un resumen con tus palabras del siguiente documento: [Clases y estructuras (Guía de programación de C#).](http://msdn.microsoft.com/es-es/library/ms173109.aspx)**

>Las clases y estructuras son parecidas a encapsulamientos de datos los cuales incluyen los métodos y las propiedades.

>Una clase es un tipo de referencia, si se crea un objeto y se asigna a una variable, la variable es la que obtiene la referencia del objeto principal.

>Una estructura es un tipo valor ya que si se asigna a una variable guarda los datos reales y si se asigna a una nueva variable solo se crea una copia con los mismos datos aunque no se afectan entre si.

>**Miembros**

Campos, Constantes, Propiedades, Métodos, Constructores, Eventos, Finalizadores, Indizadores, Operadores, Tipos anidados

>**Accesibilidad**

En algunas ocasiones es necesario mantener los datos protegidos para que solo el cliente pueda acceder a él.

>- Modificadores de acceso; public, protected, internal, protected internal, private y private protected.

>**Herencia**
Solo clases, sin estructuras, aceptan la herencia de otras clases (clases base) contiene básicamente todo excepto los constructores y finalizadores.

>**Interfaces**
Significa que el tipo implementa todos los métodos definidos en la interfaz.

>**Tipos genéricos**
Las clases y estructuras pueden definirse con uno o varios parámetros de tipo.

>**Tipos estáticos**
Las clases (pero no las estructuras) pueden declararse como static. Una clase estática puede contener solo miembros estáticos y no se puede crear una instancia de ellos con la palabra clave new.

>**Tipos anidados**
Una clase o estructura se puede anidar dentro de otra clase o estructura.

**Tipos parciales**
Solo obtiene parte de una clase, estructura o método en un archivo de código y otra parte en un archivo de código independiente.

>**Inicializadores de objeto**
Puede crear instancias de objetos de clase o estructura y de colecciones de objetos e iniciarlizarlos, sin llamar de forma explícita a su constructor.

>**Tipos anónimos**
En situaciones donde no es conveniente o necesario crear una clase con nombre.

## Instanciación de una clase

>**Investiga sobre el operador "new" visto en clase. Describe algunos de sus usos.**

>El operador new sirve para reservar memoria dinámica.
Se usa para crear objetos e invocar constructores. Por ejemplo:

>- Class1 obj = new Class1();

>El operador new también se usa para invocar el constructor predeterminado para tipos de valor. Por ejemplo:

>- int i = new int();

## Métodos: declaración, mensajes, paso de parámetros, retorno de valores

Lee y escribe un resumen con tus palabras de los siguientes documentos:

1. [Parámetros de métodos (Referencia de C#)](https://msdn.microsoft.com/es-ES/library/8f1hz171.aspx)

> Si se declaran parámetros sin in, ref o out se pasan al método llamado por valor. Ese valor se puede cambiar en el método, pero el cambio se perderá cuando se devuelva el control al procedimiento que ha realizado la llamada. Si usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.

> - in: este parámetro se pasa por referencia, pero solo se lee mediante el método llamado.

2. [params (Referencia de C#)](https://msdn.microsoft.com/es-es/library/w5zay9db.aspx)

> - params: un parámetro que toma un número variable de argumentos.

> Enviá una lista argumentos del tipo especificado. También puede no enviar ningún argumento.
Si no enviá es igual a cero.

3. [out (Referencia de C#)](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx)

> - out: este parámetro se pasa por referencia y se escribe mediante el método llamado.

>Le permite pasar un argumento a un método mediante una referencia en lugar de mediante un valor.

4. [ref (Referencia de C#)](https://msdn.microsoft.com/es-es/library/14akc2c7.aspx)

- ref: este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.

>la palabra "Ref" indica que el valor ha sido pasado por referencia. Lo que causa al pasar por referencia es que si se cambia o modifica el parámetro también se modifica en donde due llamada.
