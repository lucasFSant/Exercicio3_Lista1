string? n;
int num = 0;
double media = 0;

Console.Write("Número de valores reais: ");
n = Console.ReadLine();
Int32.TryParse(n, out num);

double[] vet = new double[num];

for (int i = 0; i < vet.Length; i++)
{
    Console.Write("Valor do " + i + "º número: ");
    n = Console.ReadLine();
    Double.TryParse(n, out vet[i]);
    media += vet[i];
}

media = media / (double)num;
Console.WriteLine("Média aritmética: " + media);