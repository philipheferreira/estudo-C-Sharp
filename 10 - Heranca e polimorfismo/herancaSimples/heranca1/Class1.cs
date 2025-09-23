using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca1{
        class Animal{ // Base class (parent)
        public virtual void somdeAnimal(){
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Porco : Animal{ // Derived class (child)
        public override void somdeAnimal(){
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Cachorro : Animal{// Derived class (child)
        public override void somdeAnimal(){
                Console.WriteLine("The dog says: bow wow");
            }
        }

    }
