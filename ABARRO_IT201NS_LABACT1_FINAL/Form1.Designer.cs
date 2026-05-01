namespace ABARRO_IT201NS_LABACT1_FINAL
{
    partial class FrmParkingSystem
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
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpParkingSlots = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblSlot = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblStandardFee = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.txtSlot);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.txtPlateNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Registration";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Car",
            "Motorcycle",
            "Van"});
            this.cmbVehicleType.Location = new System.Drawing.Point(18, 81);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(135, 21);
            this.cmbVehicleType.TabIndex = 7;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(19, 160);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(135, 20);
            this.txtSlot.TabIndex = 6;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(18, 121);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(135, 20);
            this.txtHours.TabIndex = 5;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(18, 42);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(135, 20);
            this.txtPlateNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigned Slot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Parked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(19, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 37);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(19, 38);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 37);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register Vehicle";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpParkingSlots
            // 
            this.grpParkingSlots.Location = new System.Drawing.Point(204, 14);
            this.grpParkingSlots.Name = "grpParkingSlots";
            this.grpParkingSlots.Size = new System.Drawing.Size(321, 422);
            this.grpParkingSlots.TabIndex = 2;
            this.grpParkingSlots.TabStop = false;
            this.grpParkingSlots.Text = "Parking Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOvertime);
            this.groupBox4.Controls.Add(this.lblSlot);
            this.groupBox4.Controls.Add(this.lblDuration);
            this.groupBox4.Controls.Add(this.lblVehicle);
            this.groupBox4.Controls.Add(this.lblPlate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(531, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Transaction";
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Location = new System.Drawing.Point(133, 142);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(0, 13);
            this.lblOvertime.TabIndex = 9;
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Location = new System.Drawing.Point(133, 114);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(0, 13);
            this.lblSlot.TabIndex = 8;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(133, 82);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(0, 13);
            this.lblDuration.TabIndex = 7;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(133, 54);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(0, 13);
            this.lblVehicle.TabIndex = 6;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(133, 24);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(0, 13);
            this.lblPlate.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Overtime Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Vehicle Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Slot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plate Number";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblServiceCharge);
            this.groupBox5.Controls.Add(this.lblStandardFee);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(531, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 127);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fee Calculation";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(133, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 5;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Location = new System.Drawing.Point(133, 58);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(0, 13);
            this.lblServiceCharge.TabIndex = 4;
            // 
            // lblStandardFee
            // 
            this.lblStandardFee.AutoSize = true;
            this.lblStandardFee.Location = new System.Drawing.Point(133, 30);
            this.lblStandardFee.Name = "lblStandardFee";
            this.lblStandardFee.Size = new System.Drawing.Size(0, 13);
            this.lblStandardFee.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Service Charge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Standard Fee";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblChange);
            this.groupBox6.Controls.Add(this.txtPayAmount);
            this.groupBox6.Controls.Add(this.cmbDiscount);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.rtbReceipt);
            this.groupBox6.Controls.Add(this.btnClear);
            this.groupBox6.Controls.Add(this.btnReceipt);
            this.groupBox6.Controls.Add(this.btnProcessPayment);
            this.groupBox6.Location = new System.Drawing.Point(737, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 424);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Payments and Receipts";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(84, 87);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 13);
            this.lblChange.TabIndex = 9;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(87, 56);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(115, 20);
            this.txtPayAmount.TabIndex = 8;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "None",
            "Employee",
            "Senior"});
            this.cmbDiscount.Location = new System.Drawing.Point(87, 23);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(115, 21);
            this.cmbDiscount.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Change";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Pay Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Discount";
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.Location = new System.Drawing.Point(23, 105);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.Size = new System.Drawing.Size(166, 206);
            this.rtbReceipt.TabIndex = 3;
            this.rtbReceipt.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(23, 353);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(166, 30);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Generate Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.Location = new System.Drawing.Point(23, 317);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(166, 30);
            this.btnProcessPayment.TabIndex = 0;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = true;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click_1);
            // 
            // FrmParkingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 463);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpParkingSlots);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmParkingSystem";
            this.Text = "Smart Parking Management System";
            this.Load += new System.EventHandler(this.FrmParkingSystem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpParkingSlots;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label lblStandardFee;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnProcessPayment;
    }
}

