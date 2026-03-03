using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sys_notificacoesBancarias
{
    internal class ContaBancaria
    {
        private string _titular;
        private double _saldo;
        private double _limiteExtra;

        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteExtra{
            get;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O limite extra não pode ser negativo.");
                }
            }
            
        }

        public ContaBancaria(string titular, double saldo, double limiteExtra)
        {
            titular = Titular;

            saldo = Saldo;

            limiteExtra = LimiteExtra;
                ;

        }
    }
}
