using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0914_CarProject_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Collections.ArrayList carList = new System.Collections.ArrayList(); //Holds all car objects
            //Creates 5 car objects and adds them to listBox & arrayList
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                //Added placeholder values so program doesn't read null
                car.model = "Placeholder";
                car.available = true;
                car.baggageSpace = "n/a";
                car.seats = 0;
                car.doors = 0;
                car.propelant = "n/a";
                car.regNumb = "XXX000";
                
                carList.Add(car);
            }
            //Prints all items to listBox
            for (int i = 0; i < carList.Count; i++)
            {
                listBoxCarList.Items.Add(carList[i].ToString());
            }
        }

        private void listBoxCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Visible = true;
        }
    }
}
