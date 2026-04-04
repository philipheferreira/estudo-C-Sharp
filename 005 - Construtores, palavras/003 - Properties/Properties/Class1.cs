using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties{
    internal class Class1{
        private string _Nome;
        private string _PalavraChave;

        public Class1(string nome, string palavraChave){ // O construtor recebendo as variaveis no objeto
            _Nome = nome;
            _PalavraChave= palavraChave;
        }

        public string Nome { // implementação de uma properties
            get { return _Nome; } 
            set { _Nome = value; }
        }

        public string PalavraChave{
            get { return _PalavraChave; }
            set {
                if (_PalavraChave != null){
                    _PalavraChave = value;
                }
            }
        }

    }
}
