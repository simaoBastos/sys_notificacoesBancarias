namespace sys_notificacoesBancarias
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string titular;
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

            


        }
    }
}
