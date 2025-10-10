using System.Numerics;
const int TAMANHOVETOR = 10;
int[] numeros = new int[] { 10, 4, 6, 7, 3, 9 };
int[] ordemCrescente = new int[numeros.Length];
int indice = 0;

for (int i = 0; i < numeros.Length; i++){
    int menor  = numeros[i];
    for (int j = i+1; j < numeros.Length; j++)
    {
   
        if (menor > numeros[j])
        {
            menor = numeros[j];
        }
    }
    ordemCrescente[indice] = menor;
    indice++;
}

for (int i = 0; i < ordemCrescente.Length; i++)
{
    Console.Write($"{ordemCrescente[i]} ");
}