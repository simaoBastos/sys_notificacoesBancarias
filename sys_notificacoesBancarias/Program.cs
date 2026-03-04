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

            ContaBancaria conta = new ContaBancaria(titular, 0,0);
            Console.Clear();

            #endregion

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


        }
    }
}
