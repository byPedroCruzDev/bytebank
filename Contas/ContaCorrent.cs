using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;
/* Criação de classe public, tornado valores publicos */
namespace bytebank.Contas {
    public class ContaCorrente{
        private int numero_agencia;
        public int Numeero_agencia{
            get{ return this.numero_agencia;}
            set{
                if(value > 0){
                    this.numero_agencia = value;
                }
            }
        }
        //cria uma propriedade privada e atribui metodos publicos
        public string Conta { get; set;}
        public Client Titular {get; set;}
        private double saldo;

        public void Depositar(double value){
            this.saldo += value; 
        }

        public bool Sacar(double value){
            if(this.saldo < value){
            Console.WriteLine("saldo insuficiente");
            return false;
            }else{
              this.saldo -= value;  
              return true;
            }
            
        }

        public bool Tranferir(double value, ContaCorrente conta){
            if(this.saldo < value){
                Console.WriteLine("saldo insuficiente");
                return false;
                
            }else{
                //reutilização de codigo para fazer operações existentes
                this.Sacar(value);
                conta.Depositar(value);
                return true;
            }
          
        }

        public void SetSaldo(double valor){
            if(valor < 0){
                return;
            }else{
                this.saldo = valor;
                Console.WriteLine($"Saldo igual a {this.saldo}");
            }
        }
        public double GetSaldo(){
            return this.saldo;
        }
        
    }
}
