namespace sys_notificacoesBancarias
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string titular;
            int opcaoMenu;

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

            ContaBancaria conta = new ContaBancaria(titular, 10000, 50000);
            Console.Clear();

            #endregion

            #region Menu inicial
            Console.WriteLine($"Olá, {conta.Titular}\n" +
                $"\n" +
                $"Selecione uma opção abaixo para prosseguir:\n" +
                $"1.Ver saldo\n" +
                $"2.Solicitar limite\n" +
                $"3.Sacar\n" +
                $"4.Depositar\n" +
                $"5.Verificar todas as informações\n" +
                $"6.Sair da aplicação");
            opcaoMenu = Convert.ToInt32(Console.ReadLine());

            #endregion


        }
    }
}
