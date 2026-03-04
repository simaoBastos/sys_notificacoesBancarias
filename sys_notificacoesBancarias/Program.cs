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



        }
    }
}
