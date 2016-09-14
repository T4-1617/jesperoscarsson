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

        System.Collections.ArrayList carList = new System.Collections.ArrayList(); //Holds all car objects
        Car tempforSave;

        public Form1()
        {
            InitializeComponent();
            //Creates 5 car objects and adds them to listBox & arrayList
            Car car1 = new Car() { model = "Volkswagen Golf", regNumb = "EXE275", propelant = "Petrol", doors = 2, seats = 5, baggageSpace = "2 small handbags", transmission = "Manual", available = true };
            Car car2 = new Car() { model = "Volvo XC90", regNumb = "BLA797", propelant = "Petrol", doors = 4, seats = 5, baggageSpace = "2 Large bags", transmission = "Manual", available = true };
            Car car3 = new Car() { model = "Strv122", regNumb = "DOM666", propelant = "Diesel", doors = 0, seats = 4, baggageSpace = "None", transmission = "Automatic", available = true };
            Car car4 = new Car() { model = "Audi R8", regNumb = "PEN155", propelant = "Petrol", doors = 4, seats = 5, baggageSpace = "4 small bags", transmission = "Automatic", available = true };
            Car car5 = new Car() { model = "Tesla S", regNumb = "EXK875", propelant = "Electric", doors = 4, seats = 5, baggageSpace = "4 small bags", transmission = "Automatic", available = true };

            carList.Add(car1); carList.Add(car2); carList.Add(car3); carList.Add(car4); carList.Add(car5);

            /*for (int i = 0; i < 5; i++) //This loop has been kept incase one wants to create X amount of cars
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
            }*/
            //Prints all items to listBox
            for (int i = 0; i < carList.Count; i++)
            {
                listBoxCarList.Items.Add(carList[i].ToString());
            }
        }

        private void listBoxCarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel.Visible = true;
            //Temp points to Selected object
            Car temp = (Car)carList[listBoxCarList.SelectedIndex];
            //Prints values to textBoxes
            txtModel.Text       = temp.model;
            txtTrans.Text       = temp.transmission;
            txtSeats.Text       = temp.seats.ToString();
            txtDoors.Text       = temp.doors.ToString();
            txtProp.Text        = temp.propelant;
            txtBag.Text         = temp.baggageSpace;
            txtRegNumb.Text     = temp.regNumb;
            txtAvailable.Text   = temp.available.ToString();

            tempforSave = temp;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Allows for editing, left out regNumb so it can't be edited
            txtAvailable.ReadOnly   = false;
            txtDoors.ReadOnly       = false;
            txtSeats.ReadOnly       = false;
            txtTrans.ReadOnly       = false;
            txtBag.ReadOnly         = false;
            txtModel.ReadOnly       = false;
            txtProp.ReadOnly        = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update new edited values
            tempforSave.model        = txtModel.Text;
            tempforSave.available    = Convert.ToBoolean(txtAvailable.Text);
            tempforSave.doors        = Convert.ToInt32(txtDoors.Text);
            tempforSave.seats        = Convert.ToInt32(txtSeats.Text);
            tempforSave.propelant    = txtProp.Text;
            tempforSave.baggageSpace = txtBag.Text;
            tempforSave.transmission = txtTrans.Text;
            //So you can't edit further
            txtAvailable.ReadOnly   = true;
            txtDoors.ReadOnly       = true;
            txtSeats.ReadOnly       = true;
            txtTrans.ReadOnly       = true;
            txtBag.ReadOnly         = true;
            txtModel.ReadOnly       = true;
            txtProp.ReadOnly        = true;
            //Prints all items to listBox
            listBoxCarList.Items.Clear();
            for (int i = 0; i < carList.Count; i++)
            {
                listBoxCarList.Items.Add(carList[i].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAvailable.ReadOnly = true;
            txtDoors.ReadOnly = true;
            txtSeats.ReadOnly = true;
            txtTrans.ReadOnly = true;
            txtBag.ReadOnly = true;
            txtModel.ReadOnly = true;
            txtProp.ReadOnly = true;
            //Prints all items to listBox
            listBoxCarList.Items.Clear();
            for (int i = 0; i < carList.Count; i++)
            {
                listBoxCarList.Items.Add(carList[i].ToString());
            }
            //Hides panel
            panel.Visible = false;
        }
    }
}
