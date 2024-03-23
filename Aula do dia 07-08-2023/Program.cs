/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica II
 * Professor Clayton Ferraz Andrade
 * 
 * Acadêmico Vinicius de Oliveira Pinheiro
 * Aula do dia 07-08-2024 
 * - Introdução a Arrays
 */
// variável com vetor:
string[] name = new string [5]; // essa variável acomodará 5 nomes.


for(int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"Digite o {i}º nome: ");
    name[i] = Console.ReadLine();
}
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"O {i}º nome é {name[i]}");
}

int x = 0;
//variável com o tamanho dos vetores escolhido pelo usuário:
Console.WriteLine("Digite quantos números quer: ");
x = Convert.ToInt32 (Console.ReadLine()); 

int[] valores = new int [x];
double[] price = new double[x];  

// aqui, o 'for' é usado dinamicamente em cada índice.
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine("\nDigite um valor: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());

}
for(int i = 0; i < valores.Length ; i++)
{
    Console.WriteLine($"O {i}º valor  é {valores[i]}");
}

name = new string[4]; // aqui ela pode ser alterada;
