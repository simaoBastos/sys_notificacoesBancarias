namespace sys_notificacoesBancarias
{
    class Program
    {

        static void Main(string[] args)
        {
            string titular;
            int opcaoMenu = 0;

            static void VoltarParaMenu()
            {
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            static void EnviarEmail(string mensagem)
            {
                Console.WriteLine($"Enviando email: {mensagem}");
            }
            static void EnviarSMS(string mensagem)
            {
                Console.WriteLine($"Enviando SMS: {mensagem}");
            }

            #region Criando conta bancária
            Console.WriteLine("Insira as informações da conta bancária:");

            Console.Write("Titular: ");
            titular = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(titular, 1000, 0);
            Console.Clear();

            #endregion

            while (opcaoMenu != 4)
            {
                #region Menu inicial
                Console.WriteLine($"Olá, {conta.Titular}!\n" +
                    $"Saldo: {conta.Saldo:c2} || Limite: {conta.LimiteExtra:c2}\n" +
                    $"\n" +
                    $"Selecione uma opção abaixo para prosseguir:\n" +
                    $"1.Sacar\n" +
                    $"2.Depositar\n" +
                    $"3.Solicitar limite\n" +
                    $"4.Sair da aplicação");
                Console.Write("Opção: ");
                opcaoMenu = Convert.ToInt32(Console.ReadLine());

                #endregion

                switch (opcaoMenu)
                {
                    case 1: //Sacar
                        Console.Write($"Insira o valor a ser sacado:");
                        conta.Sacar(Convert.ToDouble(Console.ReadLine()), EnviarEmail);
                        Console.WriteLine();
                        VoltarParaMenu();
                        break;

                    case 2: //Depositar
                        Console.Write("Insira o valor a ser depositado: ");
                        conta.Depositar(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine();
                        VoltarParaMenu();
                        break;

                    case 3: //Solicitar limite
                        Console.Write("Insira o limite desejado: ");
                        conta.LimiteExtra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        VoltarParaMenu();
                        break;

                    case 4: //Sair da aplicacao

                        break;

                    default:
                        Console.WriteLine("Opçao nao disponivel, tente novamente...");
                        break;
                }
            }
            Console.WriteLine("Voce saiu da aplicacao.");
        }
    }
}