using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sys_notificacoesBancarias
{
    delegate void NotificacaoAlerta(string mensagem);
    class ContaBancaria
    {
        #region Atributos
        private string _titular;
        private double _saldo;
        private double _limiteExtra;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            private set {_saldo = value; }
        }
        public double LimiteExtra{
            get{ return _limiteExtra; }

            set
            {
               if (value < 0)
                {
                    throw new ArgumentException($"O limite não pode ser negativo.");
                    
                }
                _limiteExtra = value;
            }
            
        }
        #endregion

        #region Construtor
        public ContaBancaria(string titular, double saldo, double limiteExtra)
        {
            this.Titular = titular;

            this.Saldo = saldo;

            this.LimiteExtra = limiteExtra;

        }
        #endregion

        #region Métodos
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException($"O depósito deve ser de um valor acima de 0.");
            }
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
            Saldo += valor;
        }
        public void Sacar(double valor, NotificacaoAlerta alerta)
        {
            if (valor > Saldo + LimiteExtra)
            {
                throw new InvalidOperationException($"Saldo insuficiente para realizar o saque de R${valor}.");
            }
            else if (valor>=1000 || valor > Saldo)
            {
                alerta($"ALERTA: Saque de alto valor ou uso de limite detectado na conta de {Titular}.");
            }

            Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
            Saldo -= valor;

        }
        #endregion
    }
}
