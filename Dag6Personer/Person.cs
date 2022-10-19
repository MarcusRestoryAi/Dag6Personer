using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag6Personer
{
    internal class Person
    {
        //Attribut
        public string fName;
        public string lName;
        public int age;

        //Konstruktor
        public Person(string fName, string lName, int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }

        public string Greetings()
        {
            string output = "Mitt namn är "+fName+" "+lName+" och jag är "+age+" år gammal!";
            return output;
            
            // return "Mitt namn är "+fName+" "+lName+" och jag är "+age+" är gammal!";
        }

        public string HelloToYou(Person otherPerson)
        {
            string oName = otherPerson.fName;
            string output = "Hejsan "+oName+". Mitt namn är "+fName;
            return output;
        }
    }
}
