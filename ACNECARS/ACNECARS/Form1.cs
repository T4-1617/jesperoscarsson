using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACNECARS
{
    public partial class Form1 : Form
    {
        //Declare array that will hold all Car objects
        System.Collections.ArrayList carsArray;

        public Form1()
        {
            InitializeComponent();
            //Initialize array
            carsArray = new System.Collections.ArrayList();
            //Add 3 premade vehicles to array
            carsArray.Add(new Car() { model = "Volvo s60", make = "Volvo", color = "Red", available = true});
            carsArray.Add(new Car() { model = "Saab 900 Turbo", make = "Saab", color = "Blue", available = true});
            carsArray.Add(new Car() { model = "Volvo 240", make = "Volvo", color = "Green", available = true });
            //Add premade cars to listbox and update available cars counter
            updateListBox();
            updateAvailableCarsCounter();
        }
        //Shows the panel with a listBox, makes sure all other panels are closed so there's no clipping issue
        private void btnShowCars_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = !pnlShowCars.Visible;
            pnlAddCar.Visible = false;
        }
        //Shows the panel with additional car info when an item in the listBox is pressed
        private void listBoxAvailableCarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCarInfo.Visible = true;
            btnBook.Visible = true;

            //Create temp object pointer so we can update carInfo ?POSSIBLE TO GET AROUND?
            Car carTemp = (Car)listBoxAvailableCarsList.SelectedItem;
            lblModel.Text = carTemp.model; lblMake.Text = carTemp.make; lblColor.Text = carTemp.color;
        }
        //Button for booking a selected car from the listBox
        private void btnBook_Click(object sender, EventArgs e)
        {
            //Create a object pointer that lets us update selected object info
            Car carTemp = (Car)listBoxAvailableCarsList.SelectedItem;
            //Sets status to 'hired' for selected car
            carTemp.available = false;
            //Hides extra car info panel and book button
            pnlCarInfo.Visible = false;
            btnBook.Visible = false;
            //Empties labels 
            lblColor.Text = string.Empty; lblModel.Text = string.Empty; lblMake.Text = string.Empty;
            //Updates listbox so the booked car disappears and updates the available cars counter
            updateListBox();
            updateAvailableCarsCounter();
        }
        //Shows new panel Add Car and hides other panels
        private void btnShowAddCar_Click(object sender, EventArgs e)
        {
            pnlAddCar.Visible = !pnlAddCar.Visible;
            pnlShowCars.Visible = false;
        }
        //Adds new car to arrayList, updates available cars counter and listBox and clears labels in Add Car Panel
        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            //Added for ease of use
            txtBoxMake.Focus();
            //Adds new car object
            carsArray.Add(new Car() { model = txtBoxModel.Text, make = txtBoxMake.Text, color = txtBoxColor.Text, available = true });
            //Updates and clears boxes and labels
            updateListBox();
            updateAvailableCarsCounter();
            txtBoxColor.Text = string.Empty; txtBoxModel.Text = string.Empty; txtBoxMake.Text = string.Empty;
        }
        //Updates the available cars label
        private void updateAvailableCarsCounter()
        {
            int counter = 0;

            foreach (Car Item in carsArray)
            {
                if (Item.available)
                {
                    counter++;
                }
            }

            lblCarsAvailable.Text = counter.ToString();
        }
        //Updates list box
        private void updateListBox()
        {
            listBoxAvailableCarsList.Items.Clear();
            foreach (Car item in carsArray)
            {
                if (item.available)
                {
                    listBoxAvailableCarsList.Items.Add(item);
                    listBoxAvailableCarsList.DisplayMember = "model";
                }
            }
        }
    }
}
