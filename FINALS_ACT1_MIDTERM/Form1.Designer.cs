namespace FINALS_ACT1_MIDTERM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Vehicle_type = new System.Windows.Forms.ComboBox();
            this.txt_Platenum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Update_Status = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_E5 = new System.Windows.Forms.Button();
            this.btn_E3 = new System.Windows.Forms.Button();
            this.btn_E2 = new System.Windows.Forms.Button();
            this.btn_E1 = new System.Windows.Forms.Button();
            this.btn_E4 = new System.Windows.Forms.Button();
            this.btn_D5 = new System.Windows.Forms.Button();
            this.btn_D3 = new System.Windows.Forms.Button();
            this.btn_D2 = new System.Windows.Forms.Button();
            this.btn_D1 = new System.Windows.Forms.Button();
            this.btn_D4 = new System.Windows.Forms.Button();
            this.btn_C5 = new System.Windows.Forms.Button();
            this.btn_C3 = new System.Windows.Forms.Button();
            this.btn_C2 = new System.Windows.Forms.Button();
            this.btn_C1 = new System.Windows.Forms.Button();
            this.btn_C4 = new System.Windows.Forms.Button();
            this.btn_B5 = new System.Windows.Forms.Button();
            this.btn_B3 = new System.Windows.Forms.Button();
            this.btn_B2 = new System.Windows.Forms.Button();
            this.btn_B1 = new System.Windows.Forms.Button();
            this.btn_B4 = new System.Windows.Forms.Button();
            this.btn_A5 = new System.Windows.Forms.Button();
            this.btn_A3 = new System.Windows.Forms.Button();
            this.btn_A2 = new System.Windows.Forms.Button();
            this.btn_A1 = new System.Windows.Forms.Button();
            this.btn_A4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Current_overtime_fee = new System.Windows.Forms.TextBox();
            this.txt_Current_slot = new System.Windows.Forms.TextBox();
            this.txt_Current_duration = new System.Windows.Forms.TextBox();
            this.txt_Current_Vehicle_info = new System.Windows.Forms.TextBox();
            this.txt_Current_platenum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_generate_receipt = new System.Windows.Forms.Button();
            this.btn_Clear_form = new System.Windows.Forms.Button();
            this.btn_process_payment = new System.Windows.Forms.Button();
            this.rtx_receiptlist = new System.Windows.Forms.RichTextBox();
            this.cmb_discount = new System.Windows.Forms.ComboBox();
            this.txt_payed_amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_fee_duration = new System.Windows.Forms.TextBox();
            this.txt_fee_vehicle_info = new System.Windows.Forms.TextBox();
            this.txt_fee_plate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_Hours_Parked = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.cmb_Vehicle_type);
            this.groupBox1.Controls.Add(this.txt_Hours_Parked);
            this.groupBox1.Controls.Add(this.txt_Platenum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehice Registration";
            // 
            // cmb_Vehicle_type
            // 
            this.cmb_Vehicle_type.FormattingEnabled = true;
            this.cmb_Vehicle_type.Items.AddRange(new object[] {
            "Motorcycle",
            "Car",
            "Van"});
            this.cmb_Vehicle_type.Location = new System.Drawing.Point(30, 131);
            this.cmb_Vehicle_type.Name = "cmb_Vehicle_type";
            this.cmb_Vehicle_type.Size = new System.Drawing.Size(148, 21);
            this.cmb_Vehicle_type.TabIndex = 8;
            this.cmb_Vehicle_type.SelectedIndexChanged += new System.EventHandler(this.cmb_Vehicle_type_SelectedIndexChanged);
            // 
            // txt_Platenum
            // 
            this.txt_Platenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Platenum.Location = new System.Drawing.Point(30, 45);
            this.txt_Platenum.Multiline = true;
            this.txt_Platenum.Name = "txt_Platenum";
            this.txt_Platenum.Size = new System.Drawing.Size(148, 39);
            this.txt_Platenum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vehicle Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hours Parked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plate Number";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.btn_Update_Status);
            this.groupBox2.Controls.Add(this.btn_Register);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btn_Update_Status
            // 
            this.btn_Update_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Status.Location = new System.Drawing.Point(54, 138);
            this.btn_Update_Status.Name = "btn_Update_Status";
            this.btn_Update_Status.Size = new System.Drawing.Size(208, 59);
            this.btn_Update_Status.TabIndex = 1;
            this.btn_Update_Status.Text = "Update Status";
            this.btn_Update_Status.UseVisualStyleBackColor = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(54, 54);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(208, 59);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register Device";
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_E5);
            this.groupBox3.Controls.Add(this.btn_E3);
            this.groupBox3.Controls.Add(this.btn_E2);
            this.groupBox3.Controls.Add(this.btn_E1);
            this.groupBox3.Controls.Add(this.btn_E4);
            this.groupBox3.Controls.Add(this.btn_D5);
            this.groupBox3.Controls.Add(this.btn_D3);
            this.groupBox3.Controls.Add(this.btn_D2);
            this.groupBox3.Controls.Add(this.btn_D1);
            this.groupBox3.Controls.Add(this.btn_D4);
            this.groupBox3.Controls.Add(this.btn_C5);
            this.groupBox3.Controls.Add(this.btn_C3);
            this.groupBox3.Controls.Add(this.btn_C2);
            this.groupBox3.Controls.Add(this.btn_C1);
            this.groupBox3.Controls.Add(this.btn_C4);
            this.groupBox3.Controls.Add(this.btn_B5);
            this.groupBox3.Controls.Add(this.btn_B3);
            this.groupBox3.Controls.Add(this.btn_B2);
            this.groupBox3.Controls.Add(this.btn_B1);
            this.groupBox3.Controls.Add(this.btn_B4);
            this.groupBox3.Controls.Add(this.btn_A5);
            this.groupBox3.Controls.Add(this.btn_A3);
            this.groupBox3.Controls.Add(this.btn_A2);
            this.groupBox3.Controls.Add(this.btn_A1);
            this.groupBox3.Controls.Add(this.btn_A4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 543);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parking Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "Sean\'s Parking Spot";
            // 
            // btn_E5
            // 
            this.btn_E5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_E5.Location = new System.Drawing.Point(437, 457);
            this.btn_E5.Name = "btn_E5";
            this.btn_E5.Size = new System.Drawing.Size(64, 52);
            this.btn_E5.TabIndex = 39;
            this.btn_E5.Text = "E5";
            this.btn_E5.UseVisualStyleBackColor = false;
            // 
            // btn_E3
            // 
            this.btn_E3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_E3.Location = new System.Drawing.Point(231, 457);
            this.btn_E3.Name = "btn_E3";
            this.btn_E3.Size = new System.Drawing.Size(64, 52);
            this.btn_E3.TabIndex = 38;
            this.btn_E3.Text = "E3";
            this.btn_E3.UseVisualStyleBackColor = false;
            // 
            // btn_E2
            // 
            this.btn_E2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_E2.Location = new System.Drawing.Point(129, 457);
            this.btn_E2.Name = "btn_E2";
            this.btn_E2.Size = new System.Drawing.Size(64, 52);
            this.btn_E2.TabIndex = 37;
            this.btn_E2.Text = "E2";
            this.btn_E2.UseVisualStyleBackColor = false;
            // 
            // btn_E1
            // 
            this.btn_E1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_E1.Location = new System.Drawing.Point(27, 457);
            this.btn_E1.Name = "btn_E1";
            this.btn_E1.Size = new System.Drawing.Size(64, 52);
            this.btn_E1.TabIndex = 36;
            this.btn_E1.Text = "E1";
            this.btn_E1.UseVisualStyleBackColor = false;
            // 
            // btn_E4
            // 
            this.btn_E4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_E4.Location = new System.Drawing.Point(334, 457);
            this.btn_E4.Name = "btn_E4";
            this.btn_E4.Size = new System.Drawing.Size(64, 52);
            this.btn_E4.TabIndex = 35;
            this.btn_E4.Text = "E4";
            this.btn_E4.UseVisualStyleBackColor = false;
            // 
            // btn_D5
            // 
            this.btn_D5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_D5.Location = new System.Drawing.Point(437, 379);
            this.btn_D5.Name = "btn_D5";
            this.btn_D5.Size = new System.Drawing.Size(64, 52);
            this.btn_D5.TabIndex = 34;
            this.btn_D5.Text = "D5";
            this.btn_D5.UseVisualStyleBackColor = false;
            // 
            // btn_D3
            // 
            this.btn_D3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_D3.Location = new System.Drawing.Point(231, 379);
            this.btn_D3.Name = "btn_D3";
            this.btn_D3.Size = new System.Drawing.Size(64, 52);
            this.btn_D3.TabIndex = 33;
            this.btn_D3.Text = "D3";
            this.btn_D3.UseVisualStyleBackColor = false;
            // 
            // btn_D2
            // 
            this.btn_D2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_D2.Location = new System.Drawing.Point(129, 379);
            this.btn_D2.Name = "btn_D2";
            this.btn_D2.Size = new System.Drawing.Size(64, 52);
            this.btn_D2.TabIndex = 32;
            this.btn_D2.Text = "D2";
            this.btn_D2.UseVisualStyleBackColor = false;
            // 
            // btn_D1
            // 
            this.btn_D1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_D1.Location = new System.Drawing.Point(27, 379);
            this.btn_D1.Name = "btn_D1";
            this.btn_D1.Size = new System.Drawing.Size(64, 52);
            this.btn_D1.TabIndex = 31;
            this.btn_D1.Text = "D1";
            this.btn_D1.UseVisualStyleBackColor = false;
            // 
            // btn_D4
            // 
            this.btn_D4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_D4.Location = new System.Drawing.Point(334, 379);
            this.btn_D4.Name = "btn_D4";
            this.btn_D4.Size = new System.Drawing.Size(64, 52);
            this.btn_D4.TabIndex = 30;
            this.btn_D4.Text = "D4";
            this.btn_D4.UseVisualStyleBackColor = false;
            // 
            // btn_C5
            // 
            this.btn_C5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_C5.Location = new System.Drawing.Point(437, 280);
            this.btn_C5.Name = "btn_C5";
            this.btn_C5.Size = new System.Drawing.Size(64, 52);
            this.btn_C5.TabIndex = 29;
            this.btn_C5.Text = "C5";
            this.btn_C5.UseVisualStyleBackColor = false;
            // 
            // btn_C3
            // 
            this.btn_C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_C3.Location = new System.Drawing.Point(231, 280);
            this.btn_C3.Name = "btn_C3";
            this.btn_C3.Size = new System.Drawing.Size(64, 52);
            this.btn_C3.TabIndex = 28;
            this.btn_C3.Text = "C3";
            this.btn_C3.UseVisualStyleBackColor = false;
            // 
            // btn_C2
            // 
            this.btn_C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_C2.Location = new System.Drawing.Point(129, 280);
            this.btn_C2.Name = "btn_C2";
            this.btn_C2.Size = new System.Drawing.Size(64, 52);
            this.btn_C2.TabIndex = 27;
            this.btn_C2.Text = "C2";
            this.btn_C2.UseVisualStyleBackColor = false;
            // 
            // btn_C1
            // 
            this.btn_C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_C1.Location = new System.Drawing.Point(27, 280);
            this.btn_C1.Name = "btn_C1";
            this.btn_C1.Size = new System.Drawing.Size(64, 52);
            this.btn_C1.TabIndex = 26;
            this.btn_C1.Text = "C1";
            this.btn_C1.UseVisualStyleBackColor = false;
            // 
            // btn_C4
            // 
            this.btn_C4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_C4.Location = new System.Drawing.Point(334, 280);
            this.btn_C4.Name = "btn_C4";
            this.btn_C4.Size = new System.Drawing.Size(64, 52);
            this.btn_C4.TabIndex = 25;
            this.btn_C4.Text = "C4";
            this.btn_C4.UseVisualStyleBackColor = false;
            // 
            // btn_B5
            // 
            this.btn_B5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_B5.Location = new System.Drawing.Point(437, 175);
            this.btn_B5.Name = "btn_B5";
            this.btn_B5.Size = new System.Drawing.Size(64, 52);
            this.btn_B5.TabIndex = 24;
            this.btn_B5.Text = "B5";
            this.btn_B5.UseVisualStyleBackColor = false;
            // 
            // btn_B3
            // 
            this.btn_B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_B3.Location = new System.Drawing.Point(231, 175);
            this.btn_B3.Name = "btn_B3";
            this.btn_B3.Size = new System.Drawing.Size(64, 52);
            this.btn_B3.TabIndex = 23;
            this.btn_B3.Text = "B3";
            this.btn_B3.UseVisualStyleBackColor = false;
            // 
            // btn_B2
            // 
            this.btn_B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_B2.Location = new System.Drawing.Point(129, 175);
            this.btn_B2.Name = "btn_B2";
            this.btn_B2.Size = new System.Drawing.Size(64, 52);
            this.btn_B2.TabIndex = 22;
            this.btn_B2.Text = "B2";
            this.btn_B2.UseVisualStyleBackColor = false;
            // 
            // btn_B1
            // 
            this.btn_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_B1.Location = new System.Drawing.Point(27, 175);
            this.btn_B1.Name = "btn_B1";
            this.btn_B1.Size = new System.Drawing.Size(64, 52);
            this.btn_B1.TabIndex = 21;
            this.btn_B1.Text = "B1";
            this.btn_B1.UseVisualStyleBackColor = false;
            // 
            // btn_B4
            // 
            this.btn_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_B4.Location = new System.Drawing.Point(334, 175);
            this.btn_B4.Name = "btn_B4";
            this.btn_B4.Size = new System.Drawing.Size(64, 52);
            this.btn_B4.TabIndex = 20;
            this.btn_B4.Text = "B4";
            this.btn_B4.UseVisualStyleBackColor = false;
            // 
            // btn_A5
            // 
            this.btn_A5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_A5.Location = new System.Drawing.Point(437, 87);
            this.btn_A5.Name = "btn_A5";
            this.btn_A5.Size = new System.Drawing.Size(64, 52);
            this.btn_A5.TabIndex = 19;
            this.btn_A5.Text = "A5";
            this.btn_A5.UseVisualStyleBackColor = false;
            // 
            // btn_A3
            // 
            this.btn_A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_A3.Location = new System.Drawing.Point(231, 87);
            this.btn_A3.Name = "btn_A3";
            this.btn_A3.Size = new System.Drawing.Size(64, 52);
            this.btn_A3.TabIndex = 18;
            this.btn_A3.Text = "A3";
            this.btn_A3.UseVisualStyleBackColor = false;
            // 
            // btn_A2
            // 
            this.btn_A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_A2.Location = new System.Drawing.Point(129, 87);
            this.btn_A2.Name = "btn_A2";
            this.btn_A2.Size = new System.Drawing.Size(64, 52);
            this.btn_A2.TabIndex = 17;
            this.btn_A2.Text = "A2";
            this.btn_A2.UseVisualStyleBackColor = false;
            // 
            // btn_A1
            // 
            this.btn_A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_A1.Location = new System.Drawing.Point(27, 87);
            this.btn_A1.Name = "btn_A1";
            this.btn_A1.Size = new System.Drawing.Size(64, 52);
            this.btn_A1.TabIndex = 16;
            this.btn_A1.Text = "AI";
            this.btn_A1.UseVisualStyleBackColor = false;
            // 
            // btn_A4
            // 
            this.btn_A4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_A4.Location = new System.Drawing.Point(334, 87);
            this.btn_A4.Name = "btn_A4";
            this.btn_A4.Size = new System.Drawing.Size(64, 52);
            this.btn_A4.TabIndex = 15;
            this.btn_A4.Text = "A4";
            this.btn_A4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Available";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(76, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 52);
            this.button4.TabIndex = 1;
            this.button4.Text = "Occupied";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.txt_Current_overtime_fee);
            this.groupBox4.Controls.Add(this.txt_Current_slot);
            this.groupBox4.Controls.Add(this.txt_Current_duration);
            this.groupBox4.Controls.Add(this.txt_Current_Vehicle_info);
            this.groupBox4.Controls.Add(this.txt_Current_platenum);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(885, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 303);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Transaction";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txt_Current_overtime_fee
            // 
            this.txt_Current_overtime_fee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Current_overtime_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_overtime_fee.Location = new System.Drawing.Point(128, 218);
            this.txt_Current_overtime_fee.Multiline = true;
            this.txt_Current_overtime_fee.Name = "txt_Current_overtime_fee";
            this.txt_Current_overtime_fee.ReadOnly = true;
            this.txt_Current_overtime_fee.Size = new System.Drawing.Size(148, 23);
            this.txt_Current_overtime_fee.TabIndex = 13;
            this.txt_Current_overtime_fee.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txt_Current_slot
            // 
            this.txt_Current_slot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Current_slot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_slot.Location = new System.Drawing.Point(128, 165);
            this.txt_Current_slot.Multiline = true;
            this.txt_Current_slot.Name = "txt_Current_slot";
            this.txt_Current_slot.ReadOnly = true;
            this.txt_Current_slot.Size = new System.Drawing.Size(148, 23);
            this.txt_Current_slot.TabIndex = 12;
            this.txt_Current_slot.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_Current_duration
            // 
            this.txt_Current_duration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Current_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_duration.Location = new System.Drawing.Point(128, 119);
            this.txt_Current_duration.Multiline = true;
            this.txt_Current_duration.Name = "txt_Current_duration";
            this.txt_Current_duration.ReadOnly = true;
            this.txt_Current_duration.Size = new System.Drawing.Size(148, 23);
            this.txt_Current_duration.TabIndex = 11;
            this.txt_Current_duration.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_Current_Vehicle_info
            // 
            this.txt_Current_Vehicle_info.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Current_Vehicle_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_Vehicle_info.Location = new System.Drawing.Point(128, 73);
            this.txt_Current_Vehicle_info.Multiline = true;
            this.txt_Current_Vehicle_info.Name = "txt_Current_Vehicle_info";
            this.txt_Current_Vehicle_info.ReadOnly = true;
            this.txt_Current_Vehicle_info.Size = new System.Drawing.Size(148, 23);
            this.txt_Current_Vehicle_info.TabIndex = 10;
            this.txt_Current_Vehicle_info.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_Current_platenum
            // 
            this.txt_Current_platenum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Current_platenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Current_platenum.Location = new System.Drawing.Point(128, 31);
            this.txt_Current_platenum.Multiline = true;
            this.txt_Current_platenum.Name = "txt_Current_platenum";
            this.txt_Current_platenum.ReadOnly = true;
            this.txt_Current_platenum.Size = new System.Drawing.Size(148, 23);
            this.txt_Current_platenum.TabIndex = 9;
            this.txt_Current_platenum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Duration";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Slot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Overtime fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vehicle Info";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plate Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(0, 334);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 209);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vehice Registration";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox8.Controls.Add(this.btn_generate_receipt);
            this.groupBox8.Controls.Add(this.btn_Clear_form);
            this.groupBox8.Controls.Add(this.btn_process_payment);
            this.groupBox8.Controls.Add(this.rtx_receiptlist);
            this.groupBox8.Controls.Add(this.cmb_discount);
            this.groupBox8.Controls.Add(this.txt_payed_amount);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(1265, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(374, 543);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Payments and Receipts";
            // 
            // btn_generate_receipt
            // 
            this.btn_generate_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_receipt.Location = new System.Drawing.Point(21, 452);
            this.btn_generate_receipt.Name = "btn_generate_receipt";
            this.btn_generate_receipt.Size = new System.Drawing.Size(329, 40);
            this.btn_generate_receipt.TabIndex = 6;
            this.btn_generate_receipt.Text = "Generate Receipt";
            this.btn_generate_receipt.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_form
            // 
            this.btn_Clear_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_form.Location = new System.Drawing.Point(21, 497);
            this.btn_Clear_form.Name = "btn_Clear_form";
            this.btn_Clear_form.Size = new System.Drawing.Size(329, 40);
            this.btn_Clear_form.TabIndex = 5;
            this.btn_Clear_form.Text = "Clear Form";
            this.btn_Clear_form.UseVisualStyleBackColor = true;
            // 
            // btn_process_payment
            // 
            this.btn_process_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process_payment.Location = new System.Drawing.Point(21, 406);
            this.btn_process_payment.Name = "btn_process_payment";
            this.btn_process_payment.Size = new System.Drawing.Size(329, 40);
            this.btn_process_payment.TabIndex = 2;
            this.btn_process_payment.Text = "Process Payment";
            this.btn_process_payment.UseVisualStyleBackColor = true;
            // 
            // rtx_receiptlist
            // 
            this.rtx_receiptlist.Location = new System.Drawing.Point(21, 149);
            this.rtx_receiptlist.Name = "rtx_receiptlist";
            this.rtx_receiptlist.Size = new System.Drawing.Size(329, 244);
            this.rtx_receiptlist.TabIndex = 4;
            this.rtx_receiptlist.Text = "";
            // 
            // cmb_discount
            // 
            this.cmb_discount.FormattingEnabled = true;
            this.cmb_discount.Items.AddRange(new object[] {
            "Employee",
            "Senior"});
            this.cmb_discount.Location = new System.Drawing.Point(130, 53);
            this.cmb_discount.Name = "cmb_discount";
            this.cmb_discount.Size = new System.Drawing.Size(220, 21);
            this.cmb_discount.TabIndex = 3;
            // 
            // txt_payed_amount
            // 
            this.txt_payed_amount.Location = new System.Drawing.Point(130, 109);
            this.txt_payed_amount.Name = "txt_payed_amount";
            this.txt_payed_amount.Size = new System.Drawing.Size(220, 20);
            this.txt_payed_amount.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pay Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox9.Controls.Add(this.txt_fee_duration);
            this.groupBox9.Controls.Add(this.txt_fee_vehicle_info);
            this.groupBox9.Controls.Add(this.txt_fee_plate);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Location = new System.Drawing.Point(885, 323);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(368, 232);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Fee computation";
            // 
            // txt_fee_duration
            // 
            this.txt_fee_duration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fee_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fee_duration.Location = new System.Drawing.Point(128, 158);
            this.txt_fee_duration.Multiline = true;
            this.txt_fee_duration.Name = "txt_fee_duration";
            this.txt_fee_duration.ReadOnly = true;
            this.txt_fee_duration.Size = new System.Drawing.Size(148, 23);
            this.txt_fee_duration.TabIndex = 11;
            this.txt_fee_duration.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txt_fee_vehicle_info
            // 
            this.txt_fee_vehicle_info.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fee_vehicle_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fee_vehicle_info.Location = new System.Drawing.Point(128, 112);
            this.txt_fee_vehicle_info.Multiline = true;
            this.txt_fee_vehicle_info.Name = "txt_fee_vehicle_info";
            this.txt_fee_vehicle_info.ReadOnly = true;
            this.txt_fee_vehicle_info.Size = new System.Drawing.Size(148, 23);
            this.txt_fee_vehicle_info.TabIndex = 10;
            this.txt_fee_vehicle_info.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txt_fee_plate
            // 
            this.txt_fee_plate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_fee_plate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fee_plate.Location = new System.Drawing.Point(128, 70);
            this.txt_fee_plate.Multiline = true;
            this.txt_fee_plate.Name = "txt_fee_plate";
            this.txt_fee_plate.ReadOnly = true;
            this.txt_fee_plate.Size = new System.Drawing.Size(148, 23);
            this.txt_fee_plate.TabIndex = 9;
            this.txt_fee_plate.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Duration";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Vehicle Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Plate Number";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox10.Location = new System.Drawing.Point(0, 334);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(374, 209);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Vehice Registration";
            // 
            // txt_Hours_Parked
            // 
            this.txt_Hours_Parked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hours_Parked.Location = new System.Drawing.Point(30, 199);
            this.txt_Hours_Parked.Multiline = true;
            this.txt_Hours_Parked.Name = "txt_Hours_Parked";
            this.txt_Hours_Parked.Size = new System.Drawing.Size(148, 39);
            this.txt_Hours_Parked.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1653, 593);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cmb_Vehicle_type;
        private System.Windows.Forms.TextBox txt_Platenum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update_Status;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_E5;
        private System.Windows.Forms.Button btn_E3;
        private System.Windows.Forms.Button btn_E2;
        private System.Windows.Forms.Button btn_E1;
        private System.Windows.Forms.Button btn_E4;
        private System.Windows.Forms.Button btn_D5;
        private System.Windows.Forms.Button btn_D3;
        private System.Windows.Forms.Button btn_D2;
        private System.Windows.Forms.Button btn_D1;
        private System.Windows.Forms.Button btn_D4;
        private System.Windows.Forms.Button btn_C5;
        private System.Windows.Forms.Button btn_C3;
        private System.Windows.Forms.Button btn_C2;
        private System.Windows.Forms.Button btn_C1;
        private System.Windows.Forms.Button btn_C4;
        private System.Windows.Forms.Button btn_B5;
        private System.Windows.Forms.Button btn_B3;
        private System.Windows.Forms.Button btn_B2;
        private System.Windows.Forms.Button btn_B1;
        private System.Windows.Forms.Button btn_B4;
        private System.Windows.Forms.Button btn_A5;
        private System.Windows.Forms.Button btn_A3;
        private System.Windows.Forms.Button btn_A2;
        private System.Windows.Forms.Button btn_A1;
        private System.Windows.Forms.Button btn_A4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Current_overtime_fee;
        private System.Windows.Forms.TextBox txt_Current_slot;
        private System.Windows.Forms.TextBox txt_Current_duration;
        private System.Windows.Forms.TextBox txt_Current_Vehicle_info;
        private System.Windows.Forms.TextBox txt_Current_platenum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_fee_duration;
        private System.Windows.Forms.TextBox txt_fee_vehicle_info;
        private System.Windows.Forms.TextBox txt_fee_plate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_generate_receipt;
        private System.Windows.Forms.Button btn_Clear_form;
        private System.Windows.Forms.Button btn_process_payment;
        private System.Windows.Forms.RichTextBox rtx_receiptlist;
        private System.Windows.Forms.ComboBox cmb_discount;
        private System.Windows.Forms.TextBox txt_payed_amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Hours_Parked;
    }
}

