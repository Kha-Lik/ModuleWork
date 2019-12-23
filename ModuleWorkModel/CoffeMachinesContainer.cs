using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ModuleWorkModel
{
    public class CoffeMachinesContainer
    {
        List<CoffeMachine> machines = new List<CoffeMachine>();

        public void AddMachine(List<Drink> drinks, string name, int coffe, int milk, int water)
        {
            if (machines.FirstOrDefault(x => x.Name == name) != null) 
                throw new ArgumentException("Already exists machine with this name");
            machines.Add(new CoffeMachine(drinks, name, coffe, milk, water));
        }

        public CoffeMachine GetMachine(string name) => machines.Find(x => x.Name == name);

        public List<string> GetMachinesNames() => machines.Select(x => x.Name).ToList();
    }
}
