# Maximizando el subarray de suma máxima rotando

<strong style="color:red">
    NOTA: Si usted está leyendo este documento sin haber extraído el compactado que se le entregó, ciérrelo ahora, extraiga todos los archivos en el escritorio, y siga trabajando desde ahí. Es un error común trabajar en la solución dentro del compactado, lo cual provoca que los cambios no se guarden. Si usted comete este error y entrega una solución vacía, no tendrá oportunidad de reclamar.
</strong>

---

Su tarea consiste en, dado un array de números enteros, encontrar una rotación del mismo que contenga el subarray cuya suma de elementos es la máxima entre todos los posibles subarrays.

Para ello usted deberá implementar el cuerpo del siguiente método en `C#`:

```cs
public static int[] MejorRotacion(int[] numeros)
{
    // Borre la línea debajo y escriba su código
    throw new NotImplementedException();
}
```

## ¿Qué es un subarray?

Un subarray de un array no es más que el formado por algunos elementos consecutivos del mismo. Dicho formalmente: un subarray `s` de un array `a` es aquel que contiene todos los elementos desde la posición `i` hasta la `j` en el array `a`, siendo `i <= j`. Entonces `s = {a[i], a[i + 1], ..., a[j]}`.

Considere el siguiente ejemplo:

```cs
int[] a = new int[]{3, -6, 2, 7, -5, 3};
```

en este caso tenemos algunos posibles subarrays:

```cs
{3, -6, 2}
{2, 7, -5, 3}
{7, -5}
{-5}
```

ejemplos que **NO** son subarrays:

```cs
{3, 2}
{3, 3}
{7, -5, 4}
```

Si usted comprendió el concepto de subarray, debe entender que:

- Todo array es subarray de sí mismo.
- Un elemento del array conforma un subarray con solo dicho elemento.
- Un array tiene `n * (n + 1) / 2` subarrays.

## ¿Cómo se rota el array?

Al rotar una vez el array lo que se hace el colocar el primer elemento al final, y mover el resto un lugar hacia la izquierda (hacia atrás).

Por ejemplo, si tenemos el array:

```cs
{3, 6, 2, 7, 5, 3}
```

entonces rotar un vez resulta en el siguiente array:

```cs
{6, 2, 7, 5, 3, 3}
```

## ¿Qué es una rotación de un array?

Una rotación de un array es otro array que resulta de rotar una cierta cantidad de veces el array inicial.

Por ejemplo, partiendo del array:

```cs
{3, 6, 2, 7, 5, 3}
```

las siguientes son rotaciones del mismo:

```cs
{2, 7, 5, 3, 3, 6}
{7, 5, 3, 3, 6, 2}
{3, 3, 6, 2, 7, 5}
```

- Note que un array es una rotación de sí mismo, pues se obtiene después de rotar `n` veces, donde `n` es el tamaño de dicho array.

## Encontrando la solución para el ejemplo

Suponiendo que el siguiente array es el que recibe como parámetro el método a implementar

```cs
{3, -6, 2, 7, -5, 3}
```

entonces usted debería retornar el array:

```cs
{-6, 2, 7, -5, 3, 3}
```

cuya subarray de suma máxima es `{2, 7, -5, 3, 3}`, siendo esta la mayor entre todos los subarrays.

## Notas

- Se recomienda encapsular por separado las operaciones que se le definieron para que sea más fácil luego combinar estas en búsqueda de la solución.

- Recuerde que el array puede ser rotado cualquier cantidad de veces.

- El array puede contener elementos repetidos, y nunca será un array vacío.

- Los números que contiene el array pueden tener cualquier signo.

- Pueden existir más de una rotación con el subarray con suma máxima, retorne cualquiera de ellas.

## Explicación de la estructura del código

La solución de C# contiene dos proyectos, el proyecto `Solucion` y el proyecto `Tester`.

El proyecto `Solucion` contiene el archivo `Solucion.cs` que contiene la clase `Solucion` que contiene el método `MejorRotacion` (el cual usted deberá implementar).

El proyecto `Tester` contiene el archivo `Program.cs` que contiene la clase `Program` que contiene el método `Main` que se encarga de ejecutar los casos de pruebas de ejemplo.

El `Case1` es el caso de prueba que se muestra en la orientación a modo de ejemplo, usted puede agregar más casos de prueba para probar su solución.

Para correr esas pruebas debe ejecutar el siguiente comando en la consola parado en la raiz de la solución:

```bash
dotnet run --project Tester
```

Si tiene `make` instalado basta con ejecutar el comando `make` desde la raiz de la solución.

## Sobre la entrega

La entrega de la solución será el archivo `Solucion.cs` que tiene que contener todo el código necesario y no se debe cambiar la signatura del método `MejorRotacion`. El archivo `Solucion.cs` que se entrega debe renombrarse a `Grupo - Nombre Apellido1 Apellido2.cs` (por ejemplo `C111 - Alain Brito Prieto.cs`).
