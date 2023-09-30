using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi_Factory;

namespace Taxi_Form
{
    public partial class Form1 : Form
    {
        IAFactory factory;
        Form1 form1;
        private ICar _car;
        private IDriver _driver;
        private IPassenger _passenger;
        public Form1()
        {
            factory = GetFactory();
            InitializeComponent();
            form1 = this;
            _passenger = factory.CreatePasseger();
            _car = factory.CreateCar();
            _driver = factory.CreateDriver();

            if (factory.GetType() == typeof(EconomyTaxiFactory))
            {
                button1.Text = @"Economy Taxi";
            }
            else if (factory.GetType() == typeof(BusinessTaxiFactory))
            {
                button1.Text = @"Business Taxi"; 
            }
            else if (factory.GetType() == typeof(PremiumTaxiFactory))
            {
                button1.Text = @"Premium Taxi"; 
            }
            
            //form1.Text = passenger.GetNameAndRank().ToString();
        }
        
        private static readonly Random Rand = new Random();

        private readonly int _randnumber = Rand.Next(3);

        private IAFactory GetFactory()
        {
            switch (_randnumber)
            {
                case 0: return new EconomyTaxiFactory();
                case 1: return new BusinessTaxiFactory();
                case 2: return new PremiumTaxiFactory();
            }

            throw new InvalidOperationException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] caranddriver = {"Your car is: " + _car.CreateCar(), "Your driver is: " + _driver.GetNameAndRank() };
            listBox1.Items.AddRange(caranddriver);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            form1.Text = _passenger.GetNameAndRank().ToString(); 
        }
    }
}