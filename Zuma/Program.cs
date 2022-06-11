using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*namespace Weboo.Examen
{
    public class Zuma
    {*/
int[] col1 = { 1, 1, 2, 1 };
int[] pos1 = { -3, 0, 2, 0 };
int[] pista = { 1, 2, 2, 1, 1, 2, 1, 6 };

pista = Simula(col1, pos1, pista);
for (int j = 0; j < pista.Length; j++)
{
    System.Console.WriteLine(pista[j]);
}
static int[] Simula(int[] colores, int[] pos, int[] pista)
{
    for (int i = 0; i < colores.Length; i++)
    {
        if (pos[i] < 0)
        {
            pos[i] = 0;
        }
        else
        {
            pos[i] = Math.Min(pos[i], pista.Length);
        }
        pista = Actualizarpista(colores[i], pos[i], pista);

        //actualizando pista
        pista = FindAndDeleteCombinations(pista, pos[i]);
    }
    return pista;
}

static int[] Actualizarpista(int color, int pos, int[] pista)
{
    int[] pistaactualizada = new int[pista.Length + 1];
    for (int i = 0; i < pos; i++)
    {
        pistaactualizada[i] = pista[i];
    }
    for (int j = pos + 1; j < pista.Length + 1; j++)
    {
        pistaactualizada[j] = pista[j - 1];
    }
    pistaactualizada[pos] = color;
    return pistaactualizada;
}

static int[] FindAndDeleteCombinations(int[] pistaactualizada, int pos)
{
    //como si originalmente la pista venia con combinaciones estas no son eliminadas sin interactuar con una bola, se busca directamente por vecindades de bolas ingresadas.
    int fin = pos;
    int inicio = pos;
    while (inicio > 0 && pistaactualizada[inicio - 1] == pistaactualizada[pos])
    {
        inicio--;
    }
    while (fin < pistaactualizada.Length - 1 && pistaactualizada[fin + 1] == pistaactualizada[pos])
    {
        fin++;
    }
    if (fin - inicio + 1 >= 3)
    {
        //borrar combinaciones
        pistaactualizada = DeletingComb(pistaactualizada, inicio, fin);
    }
    return pistaactualizada;
}

static int[] DeletingComb(int[] pistaactualizada, int inicio, int fin)
{
    int[] copy = new int[pistaactualizada.Length - (fin - inicio + 1)];
    int amountofsamecolorballs = fin - inicio + 1;
    for (int i = 0; i < inicio; i++)
    {
        copy[i] = pistaactualizada[i];
    }
    for (int j = fin + 1; j < pistaactualizada.Length; j++)
    {
        copy[j - amountofsamecolorballs] = pistaactualizada[j];
    }
    return copy;
}
