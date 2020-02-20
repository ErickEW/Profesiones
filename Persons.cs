using System;

namespace Prof
{
    class Person{
        private string name;
        private string job;

        public Person (string name, string job) {
            this.name = name;
            this.job = job;
        }

        public void SayHello () {
            Console.WriteLine("Hola, mi nombre es "+ this.name + this.job);
        }
    }
}