using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.GUI
{
    public partial class Form1 : Form
    {
        BerrasEntities anka = new BerrasEntities();

        public Form1()
        {
            InitializeComponent();

            //Testar att skapa en ny bil
            anka.Cars.Add(new Car() { Make = "BMW", Model = "530d" });
            anka.SaveChanges();

            //Ta kontakt med EF och se till att hämta data!
            foreach (Car item in anka.Cars)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
