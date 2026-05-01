using SmartParkingSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABARRO_IT201NS_LABACT1_FINAL
{
    public partial class FrmParkingSystem : Form
    {
        Dictionary<string, bool> slots = new Dictionary<string, bool>();
        Parking currentParking = null;
        Button selectedButton = null;

        public FrmParkingSystem()
        {
            InitializeComponent();
        }

        private void FrmParkingSystem_Load(object sender, EventArgs e)
        {
            GenerateSlots();
        }

        private void GenerateSlots()
        {
            int x = 10, y = 20;

            for (char row = 'A'; row <= 'G'; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    string slotName = row.ToString() + col;

                    Button btn = new Button();
                    btn.Text = slotName;
                    btn.Size = new Size(50, 40);
                    btn.Location = new Point(x, y);
                    btn.BackColor = Color.LimeGreen;

                    btn.Click += Slot_Click;

                    grpParkingSlots.Controls.Add(btn);
                    slots[slotName] = false;

                    x += 60;
                }

                x = 10;
                y += 50;
            }
        }

        private void Slot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (slots[btn.Text])
            {
                MessageBox.Show("Slot already occupied!");
                return;
            }

            txtSlot.Text = btn.Text;
            selectedButton = btn;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedButton == null)
                {
                    MessageBox.Show("Please select a parking slot!");
                    return;
                }

                string plate = txtPlateNumber.Text;
                string type = cmbVehicleType.Text;
                int hours = int.Parse(txtHours.Text);
                string slot = txtSlot.Text;

                if (slots[slot])
                {
                    MessageBox.Show("Slot already taken!");
                    return;
                }

                currentParking = new Parking(plate, type, hours, slot);

                slots[slot] = true;

                selectedButton.BackColor = Color.Red;
                selectedButton.Enabled = false;

                DisplayTransaction();

                MessageBox.Show("Vehicle Registered!");
            }
            catch
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void DisplayTransaction()
        {
            lblPlate.Text = currentParking.PlateNumber;
            lblVehicle.Text = currentParking.VehicleType;
            lblDuration.Text = currentParking.HoursParked + " hrs";
            lblSlot.Text = currentParking.SlotNumber;
            lblOvertime.Text = "₱" + currentParking.GetOvertimeFee();

            double baseFee = currentParking.HoursParked * GetRate(currentParking.VehicleType);

            lblStandardFee.Text = "₱" + baseFee;
            lblServiceCharge.Text = "₱20";
            lblTotal.Text = "₱" + currentParking.ComputeFee();
        }

        private double GetRate(string type)
        {
            if (type == "Car") return 50;
            if (type == "Motorcycle") return 30;
            if (type == "Van") return 70;
            return 0;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentParking == null)
                {
                    MessageBox.Show("No active parking transaction.");
                    return;
                }

                double total = ApplyDiscount(currentParking.ComputeFee());
                double payment = double.Parse(txtPayAmount.Text);

                if (payment < total)
                {
                    MessageBox.Show("Insufficient payment!");
                    return;
                }

                double change = payment - total;
                lblChange.Text = "₱" + change;

                MessageBox.Show("Payment Successful!");
            }
            catch
            {
                MessageBox.Show("Invalid payment.");
            }
        }

        private double ApplyDiscount(double total)
        {
            if (cmbDiscount.Text == "Employee")
                return total * 0.9;

            if (cmbDiscount.Text == "Senior")
                return total * 0.8;

            return total;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (currentParking == null)
            {
                MessageBox.Show("No transaction available.");
                return;
            }

            rtbReceipt.Text =
                "SMART PARKING RECEIPT\n" +
                "------------------------\n" +
                "Plate: " + currentParking.PlateNumber +
                "\nType: " + currentParking.VehicleType +
                "\nSlot: " + currentParking.SlotNumber +
                "\nHours: " + currentParking.HoursParked +
                "\nTotal: ₱" + currentParking.ComputeFee() +
                "\n------------------------";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentParking = null;
            selectedButton = null;

            txtPlateNumber.Clear();
            txtHours.Clear();
            txtSlot.Clear();
            txtPayAmount.Clear();

            cmbVehicleType.SelectedIndex = -1;
            cmbDiscount.SelectedIndex = -1;

            lblPlate.Text = "";
            lblVehicle.Text = "";
            lblDuration.Text = "";
            lblSlot.Text = "";
            lblOvertime.Text = "";
            lblStandardFee.Text = "";
            lblServiceCharge.Text = "";
            lblTotal.Text = "";
            lblChange.Text = "";

            foreach (Control ctrl in grpParkingSlots.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = true;
                    btn.BackColor = Color.LimeGreen;

                    if (slots.ContainsKey(btn.Text))
                    {
                        slots[btn.Text] = false;
                    }
                }
            }

            MessageBox.Show("Form cleared successfully!");
        }

        private void btnProcessPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (currentParking == null)
                {
                    MessageBox.Show("No active parking transaction.");
                    return;
                }

                double total = ApplyDiscount(currentParking.ComputeFee());
                double payment = double.Parse(txtPayAmount.Text);

                if (payment < total)
                {
                    MessageBox.Show("Insufficient payment!");
                    return;
                }

                double change = payment - total;
                lblChange.Text = "₱" + change;

                MessageBox.Show("Payment Successful!");
            }
            catch
            {
                MessageBox.Show("Invalid payment.");
            }
        }
    }
}