using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModuleWorkModel;

namespace ModuleWorkView
{
    public partial class MainMenu : Form
    {
        private readonly CoffeeMachinesContainer _machinesContainer = new CoffeeMachinesContainer();
        private MachineMenu menu = new MachineMenu();

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
            var usedIngs = menu.GetIngredientsUsing(machine, start, end) as Ingredients;

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
            var refillPeriod = menu.CountRefillPeriod(machine, start, end);
            refillPeriodBox.Text = refillPeriod.ToString();
        }

        private void InitialLoad()
        {
            var drinks1 = new List<Drink>();
            Ingredients composition = new Ingredients(10, 100, 100);
            drinks1.Add(new Drink("Capuccino", composition));
            composition = new Ingredients(5, 0, 25);
            drinks1.Add(new Drink("Espresso", composition));
            composition.Water = 50;
            drinks1.Add(new Drink("American", composition));

            var drinks2 = new List<Drink>();
            composition = new Ingredients(5, 25, 25);
            drinks2.Add(new Drink("Espresso with milk", composition));
            composition = new Ingredients(10, 0, 50);
            drinks2.Add(new Drink("Double espresso", composition));
            composition = new Ingredients(10, 50, 100);
            drinks2.Add(new Drink("Double american with milk", composition));

            Ingredients maxIngredients = new Ingredients(1000, 10000, 10000);
            _machinesContainer.AddMachine(drinks1, "First", maxIngredients);
            maxIngredients = new Ingredients(500, 2000, 2500);
            _machinesContainer.AddMachine(drinks2, "Second", maxIngredients);

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