### Identificar y explciar por que se esta violacioletando el principio de SRP.

```
Se esta violentando el pricipio ya que a la clase "person" le estamos dando la responsabilidad de enviar correos
y esto no es algo que la clase "person" deberia hacer. 

Además si la lógica de envio de emails cambia, es probable que también se deba modificar la clase "person", incluso
si no hay cambios en la gestión de datos de la persona. Esto lo que haria es generar acoplamiento entre las responsabilidades 
lo que dificultaria el mantenimiento y la reutilización del código. 
```
