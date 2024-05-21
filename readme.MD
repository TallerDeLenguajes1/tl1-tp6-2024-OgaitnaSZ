String es un tipo por referencia.

El tipo string en C# soporta varias secuencias de escape, que permiten incluir caracteres especiales en las cadenas de texto. Las secuencias de escape más comunes son:
- `\\` : Barra invertida
- `\'` : Comilla simple
- `\"` : Comilla doble
- `\n` : Nueva línea
- `\r` : Retorno de carro
- `\t` : Tabulación horizontal
- `\b` : Retroceso
- `\f` : Avance de página
- `\v` : Tabulación vertical
- `\0` : Carácter nulo

En C#, los caracteres `@` y `$` tienen significados especiales cuando se colocan antes de una cadena de texto:

Cuando se usa el carácter `@` antes de una cadena de texto, se crea una cadena literal verificada. Esto significa que las secuencias de escape no se procesan, y la cadena puede incluir caracteres especiales como comillas dobles y nuevas líneas directamente.
Cuando se usa el carácter `$` antes de una cadena de texto, se habilita la interpolación de cadenas. Esto permite incluir expresiones dentro de la cadena que se evaluarán y sustituirán por sus valores correspondientes.
