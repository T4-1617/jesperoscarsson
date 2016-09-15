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

        System.Collections.ArrayList carsArray;

        public Form1()
        {
            InitializeComponent();
            carsArray = new System.Collections.ArrayList();
            //Initialize with 3 premade vehicles
            carsArray.Add(new Car() { model = "Volvo s60", make = "Volvo", color = "Red" });
            carsArray.Add(new Car() { model = "Saab 900 Turbo", make = "Saab", color = "Blue" });
            carsArray.Add(new Car() { model = "Volvo 240", make = "Volvo", color = "Green" });
            //Add premade cars to listbox
            foreach (Car item in carsArray)
            {
                listBoxAvailableCarsList.Items.Add(item);
                listBoxAvailableCarsList.DisplayMember = "model";
            }
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = true;
        }

        private void listBoxAvailableCarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCarInfo.Visible = true;
            btnBook.Visible = true;

            //Create temp object so we can update carInfo
            Car carTemp = (Car)listBoxAvailableCarsList.SelectedItem;
            lblModel.Text = carTemp.model; lblMake.Text = carTemp.make; lblColor.Text = carTemp.color;
        }
    }
}
