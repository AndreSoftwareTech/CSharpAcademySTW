using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modulo03.models
{
        //Recurso computacional
        internal class Pessoa
        {

            private static int _id;
            //get pega o valor da propriedade (Exibe)
            //Set Permiter inserir um valor
            public   int Id { get; private set; }
            
            public string Nome { get; set; }

            private byte _idade;
            public byte Idade   
                            { 
                                get
                                {
                                    return _idade;
                                }
                                set
                                 {
                                    while(value <= 0)
                                    {
                                        Console.Write("Digite sua idade");
                                         value = byte.Parse(Console.ReadLine());
                                    }
                                    this._idade = value;
                                }
                            }
            //Condicao
            public Pessoa() 
            {
                 geraId();
            }

            public Pessoa(string nome, byte idade) 
            { 
                this.Nome = nome;
                this.Idade = idade;
                geraId();
            }
            
            private void geraId()
            {
                this.Id = ++_id;
            }

        public override string ToString()
        {
            return $"{this.Id} {this.Nome} {this.Idade}" ;
        }
        public override bool Equals(object? obj)
        {
            Pessoa objeto = obj as Pessoa;
            if (objeto.Nome == this.Nome) 
            {
                return true;
            }
            return false;
        }

    }
 }
