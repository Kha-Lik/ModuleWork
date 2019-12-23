using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModuleWorkModel;

namespace ModulWorkView
{
    public partial class MainMenu : Form
    {
        private readonly CoffeeMachinesContainer _machinesContainer = new CoffeeMachinesContainer();

        public MainMenu()
        {
            InitializeComponent();
            InitialLoad();
            machinesListBox.DataSource = _machinesContainer.GetMachinesNames();
        }

        private void getUsedBtn_Click(object sender, EventArgs e)
        {
            var start = DateTime.Parse(startTimeMaskedBox.Text);
            var end = DateTime.Parse(endTimeMaskedBox.Text);
            var selectedMachine = machinesListBox.SelectedItem.ToString();

            var machine = _machinesContainer.GetMachine(selectedMachine);
            var usedIngs = MachineMenu.GetIngredientsUsing(machine, start, end);

            usedCoffeBox.Text = usedIngs.Coffee.ToString();
            usedMilkBox.Text = usedIngs.Milk.ToString();
            usedWaterBox.Text = usedIngs.Water.ToString();
        }

        private void refillPeriodBtn_Click(object sender, EventArgs e)
        {
            var start = DateTime.Parse(startTimeMaskedBox.Text);
            var end = DateTime.Parse(endTimeMaskedBox.Text);
            var selectedMachine = machinesListBox.SelectedItem.ToString();

            var machine = _machinesContainer.GetMachine(selectedMachine);
            var refillPeriod = MachineMenu.CountRefillPeriod(machine, start, end);
            refillPeriodBox.Text = refillPeriod.ToString();
        }

        private void InitialLoad()
        {
            var drinks1 = new List<Drink>();
            drinks1.Add(new Drink("Capuccino", 10, 100, 100));
            drinks1.Add(new Drink("Espresso", 5, 0, 25));
            drinks1.Add(new Drink("American", 5, 0, 50));

            var drinks2 = new List<Drink>();
            drinks2.Add(new Drink("Espresso with milk", 5, 25, 25));
            drinks2.Add(new Drink("Double espresso", 10, 0, 50));
            drinks2.Add(new Drink("Double american with milk", 10, 50, 100));

            _machinesContainer.AddMachine(drinks1, "First", 1000, 10000, 10000);
            _machinesContainer.AddMachine(drinks2, "Second", 500, 2000, 2500);

            _machinesContainer.GetMachine("First").TakeDrink_dev("Capuccino", new DateTime(2019, 12, 10, 12, 12, 12));
            _machinesContainer.GetMachine("First").TakeDrink_dev("Capuccino", new DateTime(2019, 12, 10, 14, 12, 12));
            _machinesContainer.GetMachine("First").TakeDrink_dev("Capuccino", new DateTime(2019, 12, 10, 16, 12, 12));
            _machinesContainer.GetMachine("First").TakeDrink_dev("American", new DateTime(2019, 12, 14, 16, 12, 12));
            _machinesContainer.GetMachine("First").TakeDrink_dev("Espresso", new DateTime(2019, 12, 18, 16, 12, 12));

            _machinesContainer.GetMachine("Second")
                .TakeDrink_dev("Double american with milk", new DateTime(2019, 12, 10, 12, 12, 12));
            _machinesContainer.GetMachine("Second")
                .TakeDrink_dev("Double espresso", new DateTime(2019, 12, 12, 12, 12, 12));
            _machinesContainer.GetMachine("Second")
                .TakeDrink_dev("Espresso with milk", new DateTime(2019, 12, 13, 12, 12, 12));
            _machinesContainer.GetMachine("Second")
                .TakeDrink_dev("Double american with milk", new DateTime(2019, 12, 14, 12, 12, 12));
        }
    }
}