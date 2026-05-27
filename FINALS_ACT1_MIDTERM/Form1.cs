using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALS_ACT1_MIDTERM
{
    public partial class Form1 : Form
    {
        // simple storage for parked vehicles per slot
        private readonly Dictionary<string, Parking_Registration_Calculation> _parked = new Dictionary<string, Parking_Registration_Calculation>();
        // base rates
        private const decimal RatePerHour = 20m;
        private const decimal OvertimeRatePerHour = 30m;
        private Button[] slotButtons;
        public Form1()
        {
            InitializeComponent();
            // wire up slot buttons array for easy access
            slotButtons = new[]
            {
                btn_A1, btn_A2, btn_A3, btn_A4, btn_A5,
                btn_B1, btn_B2, btn_B3, btn_B4, btn_B5,
                btn_C1, btn_C2, btn_C3, btn_C4, btn_C5,
                btn_D1, btn_D2, btn_D3, btn_D4, btn_D5,
                btn_E1, btn_E2, btn_E3, btn_E4, btn_E5
            };

            foreach (var b in slotButtons)
            {
                b.Click += SlotButton_Click;
            }

            btn_Register.Click += Btn_Register_Click;
            btn_Update_Status.Click += Btn_Update_Status_Click;
            btn_process_payment.Click += Btn_process_payment_Click;
            btn_generate_receipt.Click += Btn_generate_receipt_Click;
            btn_Clear_form.Click += Btn_Clear_form_Click;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Vehicle_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nothing required here for now
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            var plate = txt_Platenum.Text.Trim();
            var type = cmb_Vehicle_type.Text.Trim();
            if (string.IsNullOrEmpty(plate) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter plate number and vehicle type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Hours_Parked.Text.Trim(), out var hours) || hours < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number of hours.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // find first available slot
            var slot = slotButtons.FirstOrDefault(b => b.BackColor == System.Drawing.Color.FromArgb(128, 255, 128));
            if (slot == null)
            {
                MessageBox.Show("No available slots.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var reg = new Parking_Registration_Calculation(plate, type, hours);
            _parked[slot.Text] = reg;
            slot.BackColor = System.Drawing.Color.FromArgb(255, 128, 128); // occupied

            // update current transaction display
            txt_Current_platenum.Text = reg.Plate_number;
            txt_Current_Vehicle_info.Text = reg.Vehicle_model;
            txt_Current_duration.Text = reg.Hours_Parked.ToString();
            txt_Current_slot.Text = slot.Text;

            // fee calculations
            var baseFee = RatePerHour * reg.Hours_Parked;
            var overtime = 0m;
            if (reg.Hours_Parked > 24)
            {
                overtime = OvertimeRatePerHour * (reg.Hours_Parked - 24);
            }
            txt_Current_overtime_fee.Text = overtime.ToString("0.00");
            // also fill fee computation area
            txt_fee_plate.Text = reg.Plate_number;
            txt_fee_vehicle_info.Text = reg.Vehicle_model;
            txt_fee_duration.Text = reg.Hours_Parked.ToString();
        }

        private void SlotButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button b)) return;
            // show details if occupied
            if (_parked.TryGetValue(b.Text, out var reg))
            {
                txt_Current_platenum.Text = reg.Plate_number;
                txt_Current_Vehicle_info.Text = reg.Vehicle_model;
                txt_Current_duration.Text = reg.Hours_Parked.ToString();
                txt_Current_slot.Text = b.Text;

                var overtime = 0m;
                if (reg.Hours_Parked > 24) overtime = OvertimeRatePerHour * (reg.Hours_Parked - 24);
                txt_Current_overtime_fee.Text = overtime.ToString("0.00");
            }
            else
            {
                // clear current display
                txt_Current_platenum.Clear();
                txt_Current_Vehicle_info.Clear();
                txt_Current_duration.Clear();
                txt_Current_slot.Clear();
                txt_Current_overtime_fee.Clear();
            }
        }

        private void Btn_Update_Status_Click(object sender, EventArgs e)
        {
            var slot = txt_Current_slot.Text.Trim();
            if (string.IsNullOrEmpty(slot))
            {
                MessageBox.Show("Select a slot to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_parked.ContainsKey(slot))
            {
                // free the slot
                _parked.Remove(slot);
                var b = slotButtons.FirstOrDefault(x => x.Text == slot);
                if (b != null) b.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
                MessageBox.Show($"Slot {slot} is now free.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // clear current
                txt_Current_platenum.Clear(); txt_Current_Vehicle_info.Clear(); txt_Current_duration.Clear(); txt_Current_slot.Clear(); txt_Current_overtime_fee.Clear();
            }
            else
            {
                MessageBox.Show("Slot is already free.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_process_payment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fee_plate.Text))
            {
                MessageBox.Show("No fee to process.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_Current_overtime_fee.Text, out var overtime)) overtime = 0m;
            if (!int.TryParse(txt_fee_duration.Text, out var hours)) hours = 0;

            var subtotal = RatePerHour * hours + overtime;
            var discount = 0m;
            if (cmb_discount.Text == "Employee") discount = 0.3m; // 30%
            else if (cmb_discount.Text == "Senior") discount = 0.2m; // 20%

            var total = subtotal * (1 - discount);

            if (!decimal.TryParse(txt_payed_amount.Text, out var paid))
            {
                MessageBox.Show("Enter a valid paid amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paid < total)
            {
                MessageBox.Show("Insufficient payment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var change = paid - total;
            MessageBox.Show($"Payment successful. Change: {change:0.00}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_generate_receipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fee_plate.Text)) return;
            var sb = new StringBuilder();
            sb.AppendLine("-- Parking Receipt --");
            sb.AppendLine($"Plate: {txt_fee_plate.Text}");
            sb.AppendLine($"Vehicle: {txt_fee_vehicle_info.Text}");
            sb.AppendLine($"Duration: {txt_fee_duration.Text} hours");
            sb.AppendLine($"Overtime Fee: {txt_Current_overtime_fee.Text}");
            sb.AppendLine($"Discount: {cmb_discount.Text}");
            rtx_receiptlist.Text = sb.ToString();
        }

        private void Btn_Clear_form_Click(object sender, EventArgs e)
        {
            txt_Platenum.Clear();
            cmb_Vehicle_type.SelectedIndex = -1;
            txt_Hours_Parked.Clear();
            txt_Current_platenum.Clear();
            txt_Current_Vehicle_info.Clear();
            txt_Current_duration.Clear();
            txt_Current_slot.Clear();
            txt_Current_overtime_fee.Clear();
            txt_fee_plate.Clear();
            txt_fee_vehicle_info.Clear();
            txt_fee_duration.Clear();
            txt_payed_amount.Clear();
            cmb_discount.SelectedIndex = -1;
            rtx_receiptlist.Clear();
        }
    }
}
