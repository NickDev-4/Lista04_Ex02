Console.Clear();

double emprestimo, renda, resultado, valorParcelas;
int parcela;

Console.Write("Digite o valor do empréstimo solicitado: ");
emprestimo = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de parcelas para quitar o empréstimo: ");
parcela = int.Parse(Console.ReadLine());

Console.Write("Digite a sua renda mensal: ");
renda = double.Parse(Console.ReadLine());

valorParcelas = emprestimo / parcela;

resultado = (valorParcelas / renda) * 100;

if (resultado <= 30){
    Console.WriteLine("Seu empréstimo foi APROVADO!");
}

else {
    Console.WriteLine("Seu empréstimo foi NEGADO!");
}