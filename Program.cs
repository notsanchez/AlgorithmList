using System;

namespace Lista_app
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcao;

            Console.WriteLine("Digite o exercicio");
            opcao = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // A = IDADE
                    // B = ANO DE NASCIMENTO
                    int a, b;

                    a = 0;
                    b = 0;

                    Console.WriteLine("Digite a sua idade: ");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Ano que você nasceu: ");
                    b = int.Parse(Console.ReadLine());

                    a = b;
                    b = a;


                    Console.WriteLine(a);
                    Console.WriteLine(b);


                    break;

                case 2:
                    double altura, peso_ideal;
                    string nome, sexo;
                    peso_ideal = 0;
                    sexo = "";

                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("ALtura (Em metros): ");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sexo (M ou F): ");
                    sexo = Console.ReadLine();

                    if (sexo == "M")
                    {
                        peso_ideal = (72.7 * altura) - 58;
                        Console.WriteLine("Seu peso ideal: " + peso_ideal);
                    }
                    if (sexo == "F")
                    {
                        peso_ideal = (62.1 * altura) - 44.7;
                        Console.WriteLine("Seu peso ideal: " + peso_ideal);
                    }
                    break;

                case 3:
                    int qtd_atual, qtd_max, qtd_min, qtd_media;

                    Console.WriteLine("Digite a quantidade atual em estoque: ");
                    qtd_atual = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade maxima em estoque: ");
                    qtd_max = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade minima em estoque: ");
                    qtd_min = int.Parse(Console.ReadLine());

                    qtd_media = (qtd_max + qtd_min) / 2;

                    if (qtd_atual >= qtd_media)
                    {
                        Console.WriteLine("Não efetuar a compra");
                    }
                    else
                    {
                        Console.WriteLine("Efetuar a compra");
                    }

                    break;

                case 4:
                    int valor;

                    valor = int.Parse(Console.ReadLine());

                    if (valor == 0)
                    {
                        Console.WriteLine("Valor = 0");
                    }
                    if (valor > 0)
                    {
                        Console.WriteLine("Valor = positivo");
                    }
                    if (valor < 0)
                    {
                        Console.WriteLine("Valor = negativo");
                    }

                    break;

                case 5:
                    int num1, num2;

                    Console.WriteLine("Digite o valor 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor 2: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (num1 == num2)
                    {
                        Console.WriteLine("Numeros Iguais");
                    }
                    if (num1 > num2)
                    {
                        Console.WriteLine("Primeiro é maior");
                    }
                    if (num2 > num1)
                    {
                        Console.WriteLine("Segundo é maior");
                    }

                    break;

                case 6:
                    int h1 = 0, h2 = 0, m1 = 0, m2 = 0, h_velho = 0, h_novo = 0, m_velha = 0, m_nova = 0;
                    int soma1, soma2;

                    Console.WriteLine("Digite a idade do homem 1: ");
                    h1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a idade do homem 2: ");
                    h2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a idade da mulher 1: ");
                    m1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a idade da mulher 2: ");
                    m2 = int.Parse(Console.ReadLine());

                    if (h1 > h2)
                    {
                        h1 = h_velho;
                        h2 = h_novo;
                    }
                    else
                    {
                        h1 = h_novo;
                        h2 = h_velho;
                    }
                    if (m1 > m2)
                    {
                        m1 = m_velha;
                        m2 = m_nova;
                    }
                    else
                    {
                        m1 = m_nova;
                        m2 = m_velha;
                    }

                    soma1 = h_velho + m_nova;
                    soma2 = h_novo + m_velha;

                    Console.WriteLine("Soma 1: " + soma1);
                    Console.WriteLine("Soma 2: " + soma2);


                    break;

                case 7:
                    int valor2, valor3 = 0, resultado;

                    valor2 = int.Parse(Console.ReadLine());

                    while (valor3 == 0)
                    {
                        valor3 = int.Parse(Console.ReadLine());
                    }

                    resultado = valor2 / valor3;

                    Console.WriteLine("Resultado da divisão: " + resultado);

                    break;

                case 8:
                    int valor4, valor5 = 0;

                    valor4 = int.Parse(Console.ReadLine());

                    while (valor5 == 0)
                    {
                        valor5 = int.Parse(Console.ReadLine());

                    }

                    resultado = valor4 / valor5;

                    Console.WriteLine("Resultado da divisão: " + resultado);

                    break;

                case 9:

                    int i = 0, valor6, valor7 = 0;
                    string nova;

                    while (i <= 0)
                    {
                        valor6 = int.Parse(Console.ReadLine());

                        while (valor7 == 0)
                        {
                            valor7 = int.Parse(Console.ReadLine());
                            if (valor7 == 0)
                            {
                                Console.WriteLine("O valor precisa ser diferente de zero");

                            }
                        }

                        resultado = valor6 / valor7;

                        Console.WriteLine("Resultado da divisão: " + resultado);

                        Console.WriteLine("Nova divisão? (S/N)");

                        nova = Console.ReadLine();
                        if (nova == "s")
                        {
                            return;
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
