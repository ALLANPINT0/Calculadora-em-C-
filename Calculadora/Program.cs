






internal class Program
{
    enum opcao { somar = 1,subtrair,dividir,multiplicar,sair}
    private static void Main(string[] args)
    {
        menu();
        
            static void menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das operacoes a baixo: ");
            Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicar\n5 - Sair Da Calculadora");
            int Op = int.Parse(Console.ReadLine());
            opcao OpSel = (opcao)Op;
            Console.WriteLine(OpSel);
            switch (OpSel)
            {
                case opcao.somar:
                    soma();
                    break;
                case opcao.subtrair:
                    subtracao();
                    break;
                case opcao.dividir:
                    divisao();
                    break;
                case opcao.multiplicar:
                    multiplicacao();
                    break;
                case opcao.sair:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcao Invalida");
                    Console.ReadKey();
                    menu();
                    break;
            }
        }
            static void soma()
            {
            Console.Clear();
                Console.WriteLine("Escreva o primero valor: ");
                float V1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o Segundo Valor: ");
                float V2 = float.Parse(Console.ReadLine());

                float soma = V1+ V2;

                Console.WriteLine($"O Resultado Da Soma Entre {V1} e {V2} é {soma}");
                Console.ReadKey();
            menu();
        }
            static void subtracao()
            {
            Console.Clear();
            Console.WriteLine("Escreva o primero valor: ");
                float V1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o Segundo Valor: ");
                float V2 = float.Parse(Console.ReadLine());

                float subtracao = V1- V2;

                Console.WriteLine($"O Resultado Da Soma Entre {V1} e {V2} é {subtracao}");
                Console.ReadKey();
            menu();

        }
            static void divisao()
            {
            Console.Clear();
            Console.WriteLine("Escreva o primero valor: ");
                float V1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o Segundo Valor: ");
                float V2 = float.Parse(Console.ReadLine());

                float divisao = V1/ V2;

                Console.WriteLine($"O Resultado Da Divisao Entre {V1} e {V2} é {divisao}");
                Console.ReadKey();
            menu();
        }
            static void multiplicacao()
            {
            Console.Clear();
            Console.WriteLine("Escreva o primero valor: ");
                float V1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o Segundo Valor: ");
                float V2 = float.Parse(Console.ReadLine());

                float multiplicacao = V1* V2;

                Console.WriteLine($"O Resultado Da multiplicacao Entre {V1} e {V2} é {multiplicacao}");
                Console.ReadKey();
            menu();
        }
        
    }
}