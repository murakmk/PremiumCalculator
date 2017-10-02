namespace WindowsFormsApplication4
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
            this.lab_date = new System.Windows.Forms.Label();
            this.lab_type_of_vehicle = new System.Windows.Forms.Label();
            this.lab_age_of_vehicle = new System.Windows.Forms.Label();
            this.lab_cubic_capacity = new System.Windows.Forms.Label();
            this.lab_insured_declared_value = new System.Windows.Forms.Label();
            this.lab_no_claim_bonus = new System.Windows.Forms.Label();
            this.lab_discount = new System.Windows.Forms.Label();
            this.lab_vehicle_zone = new System.Windows.Forms.Label();
            this.combo_type_of_vehicle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combo_age_of_vehicle = new System.Windows.Forms.ComboBox();
            this.combo_n0_claim_bonus = new System.Windows.Forms.ComboBox();
            this.combo_vehicle_zone = new System.Windows.Forms.ComboBox();
            this.lab_add_tonnage = new System.Windows.Forms.Label();
            this.lab_nil_dep = new System.Windows.Forms.Label();
            this.lab_total_amount = new System.Windows.Forms.Label();
            this.lab_imt_23 = new System.Windows.Forms.Label();
            this.lab_ser_tax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_tot_prem = new System.Windows.Forms.Label();
            this.lab_ncb = new System.Windows.Forms.Label();
            this.lab_tp_total = new System.Windows.Forms.Label();
            this.lab_od_total = new System.Windows.Forms.Label();
            this.lab_pa_unnamed_pass = new System.Windows.Forms.Label();
            this.lab_tp_basic = new System.Windows.Forms.Label();
            this.lab_pa_dr_cl = new System.Windows.Forms.Label();
            this.lab_tp_trailor = new System.Windows.Forms.Label();
            this.lab_non_fare_passenger = new System.Windows.Forms.Label();
            this.lab_pa_owner_dr = new System.Windows.Forms.Label();
            this.lab_ll_liab_passenger = new System.Windows.Forms.Label();
            this.lab_ll_dr_cl = new System.Windows.Forms.Label();
            this.lab_od_basic = new System.Windows.Forms.Label();
            this.text_od_basic = new System.Windows.Forms.TextBox();
            this.text_addl_tonnage = new System.Windows.Forms.TextBox();
            this.text_nil_dep_premium = new System.Windows.Forms.TextBox();
            this.text_imt_23 = new System.Windows.Forms.TextBox();
            this.text_disc = new System.Windows.Forms.TextBox();
            this.text_no_claim_bonus = new System.Windows.Forms.TextBox();
            this.text_od_total = new System.Windows.Forms.TextBox();
            this.text_tp_basic = new System.Windows.Forms.TextBox();
            this.text_tp_trl_basic = new System.Windows.Forms.TextBox();
            this.text_pa_to_owner_dr = new System.Windows.Forms.TextBox();
            this.text_ll_to_dr_cl = new System.Windows.Forms.TextBox();
            this.text_to_passengers = new System.Windows.Forms.TextBox();
            this.text_non_fare_pass = new System.Windows.Forms.TextBox();
            this.text_pa_dr_cl = new System.Windows.Forms.TextBox();
            this.text_pa_unnamed_pass = new System.Windows.Forms.TextBox();
            this.text_tp_total = new System.Windows.Forms.TextBox();
            this.text_total_premium = new System.Windows.Forms.TextBox();
            this.text_service_tax = new System.Windows.Forms.TextBox();
            this.text_total_amount = new System.Windows.Forms.TextBox();
            this.but_calculatr = new System.Windows.Forms.Button();
            this.lab_nil_dep_req = new System.Windows.Forms.Label();
            this.combo_nil_dep = new System.Windows.Forms.ComboBox();
            this.lab_gvw = new System.Windows.Forms.Label();
            this.lab_pa_owner_driver = new System.Windows.Forms.Label();
            this.combo_pa_owner_driver = new System.Windows.Forms.ComboBox();
            this.lab_pa_to_dr_cl = new System.Windows.Forms.Label();
            this.combo_pa_dr_cl = new System.Windows.Forms.ComboBox();
            this.lab_pa_sum_dr_cl = new System.Windows.Forms.Label();
            this.lab_lg_lia_dr_cl_no = new System.Windows.Forms.Label();
            this.combo_lg_lia_dr_cl = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.num_cubic_capacity = new System.Windows.Forms.NumericUpDown();
            this.num_insured_declared_value = new System.Windows.Forms.NumericUpDown();
            this.num_discount = new System.Windows.Forms.NumericUpDown();
            this.num_gvw = new System.Windows.Forms.NumericUpDown();
            this.num_pa_sum_insured = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cubic_capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_insured_declared_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pa_sum_insured)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_date.Location = new System.Drawing.Point(41, 38);
            this.lab_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(122, 15);
            this.lab_date.TabIndex = 0;
            this.lab_date.Text = "To day\'s Date      :";
            this.lab_date.Click += new System.EventHandler(this.lab_date_Click);
            // 
            // lab_type_of_vehicle
            // 
            this.lab_type_of_vehicle.AutoSize = true;
            this.lab_type_of_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_type_of_vehicle.Location = new System.Drawing.Point(41, 70);
            this.lab_type_of_vehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_type_of_vehicle.Name = "lab_type_of_vehicle";
            this.lab_type_of_vehicle.Size = new System.Drawing.Size(124, 15);
            this.lab_type_of_vehicle.TabIndex = 1;
            this.lab_type_of_vehicle.Text = "Type of Vehicle    :";
            this.lab_type_of_vehicle.Click += new System.EventHandler(this.lab_type_of_vehicle_Click);
            // 
            // lab_age_of_vehicle
            // 
            this.lab_age_of_vehicle.AutoSize = true;
            this.lab_age_of_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_age_of_vehicle.Location = new System.Drawing.Point(41, 103);
            this.lab_age_of_vehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_age_of_vehicle.Name = "lab_age_of_vehicle";
            this.lab_age_of_vehicle.Size = new System.Drawing.Size(134, 15);
            this.lab_age_of_vehicle.TabIndex = 2;
            this.lab_age_of_vehicle.Text = "Age of the Vehicle  :";
            this.lab_age_of_vehicle.Click += new System.EventHandler(this.lab_age_of_vehicle_Click);
            // 
            // lab_cubic_capacity
            // 
            this.lab_cubic_capacity.AutoSize = true;
            this.lab_cubic_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cubic_capacity.Location = new System.Drawing.Point(41, 137);
            this.lab_cubic_capacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_cubic_capacity.Name = "lab_cubic_capacity";
            this.lab_cubic_capacity.Size = new System.Drawing.Size(109, 15);
            this.lab_cubic_capacity.TabIndex = 3;
            this.lab_cubic_capacity.Text = "Cubic Capacity :";
            this.lab_cubic_capacity.Click += new System.EventHandler(this.lab_cubic_capacity_Click);
            // 
            // lab_insured_declared_value
            // 
            this.lab_insured_declared_value.AutoSize = true;
            this.lab_insured_declared_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_insured_declared_value.Location = new System.Drawing.Point(41, 168);
            this.lab_insured_declared_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_insured_declared_value.Name = "lab_insured_declared_value";
            this.lab_insured_declared_value.Size = new System.Drawing.Size(169, 15);
            this.lab_insured_declared_value.TabIndex = 4;
            this.lab_insured_declared_value.Text = "Insured Declared Value  :";
            this.lab_insured_declared_value.Click += new System.EventHandler(this.lab_insured_declared_value_Click);
            // 
            // lab_no_claim_bonus
            // 
            this.lab_no_claim_bonus.AutoSize = true;
            this.lab_no_claim_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_no_claim_bonus.Location = new System.Drawing.Point(41, 203);
            this.lab_no_claim_bonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_no_claim_bonus.Name = "lab_no_claim_bonus";
            this.lab_no_claim_bonus.Size = new System.Drawing.Size(118, 15);
            this.lab_no_claim_bonus.TabIndex = 5;
            this.lab_no_claim_bonus.Text = "No Claim Bonus :";
            this.lab_no_claim_bonus.Click += new System.EventHandler(this.lab_no_claim_bonus_Click);
            // 
            // lab_discount
            // 
            this.lab_discount.AutoSize = true;
            this.lab_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_discount.Location = new System.Drawing.Point(41, 238);
            this.lab_discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_discount.Name = "lab_discount";
            this.lab_discount.Size = new System.Drawing.Size(79, 15);
            this.lab_discount.TabIndex = 6;
            this.lab_discount.Text = "Discount   :";
            this.lab_discount.Click += new System.EventHandler(this.lab_discount_Click);
            // 
            // lab_vehicle_zone
            // 
            this.lab_vehicle_zone.AutoSize = true;
            this.lab_vehicle_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_vehicle_zone.Location = new System.Drawing.Point(41, 273);
            this.lab_vehicle_zone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_vehicle_zone.Name = "lab_vehicle_zone";
            this.lab_vehicle_zone.Size = new System.Drawing.Size(114, 15);
            this.lab_vehicle_zone.TabIndex = 7;
            this.lab_vehicle_zone.Text = "Vehicle Zone     :";
            this.lab_vehicle_zone.Click += new System.EventHandler(this.lab_vehicle_zone_Click);
            // 
            // combo_type_of_vehicle
            // 
            this.combo_type_of_vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_type_of_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_type_of_vehicle.FormattingEnabled = true;
            this.combo_type_of_vehicle.Items.AddRange(new object[] {
            "Two Wheeler",
            "Private Car",
            "3 Wheeler Goods Auto public",
            "3 Wheeler Goods Auto Private",
            "3 Wheeled Auto pass<6",
            "3 Wheeled Auto pass>6",
            "4 Wheeler upto 6 pass.",
            "4 Wheeler more 6 pass.",
            "Goods Carriage Public",
            "Goods Carriage Private",
            "Misc. Type of Vehicle"});
            this.combo_type_of_vehicle.Location = new System.Drawing.Point(257, 67);
            this.combo_type_of_vehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_type_of_vehicle.Name = "combo_type_of_vehicle";
            this.combo_type_of_vehicle.Size = new System.Drawing.Size(160, 23);
            this.combo_type_of_vehicle.TabIndex = 8;
            this.combo_type_of_vehicle.SelectedIndexChanged += new System.EventHandler(this.combo_type_of_vehicle_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 33);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 21);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // combo_age_of_vehicle
            // 
            this.combo_age_of_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_age_of_vehicle.FormattingEnabled = true;
            this.combo_age_of_vehicle.Items.AddRange(new object[] {
            "<5",
            "<7",
            "<11",
            ">10"});
            this.combo_age_of_vehicle.Location = new System.Drawing.Point(257, 100);
            this.combo_age_of_vehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_age_of_vehicle.Name = "combo_age_of_vehicle";
            this.combo_age_of_vehicle.Size = new System.Drawing.Size(160, 23);
            this.combo_age_of_vehicle.TabIndex = 10;
            this.combo_age_of_vehicle.SelectedIndexChanged += new System.EventHandler(this.combo_age_of_vehicle_SelectedIndexChanged);
            // 
            // combo_n0_claim_bonus
            // 
            this.combo_n0_claim_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_n0_claim_bonus.FormattingEnabled = true;
            this.combo_n0_claim_bonus.Items.AddRange(new object[] {
            "0",
            "20",
            "25",
            "35",
            "50"});
            this.combo_n0_claim_bonus.Location = new System.Drawing.Point(257, 200);
            this.combo_n0_claim_bonus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_n0_claim_bonus.Name = "combo_n0_claim_bonus";
            this.combo_n0_claim_bonus.Size = new System.Drawing.Size(160, 23);
            this.combo_n0_claim_bonus.TabIndex = 12;
            this.combo_n0_claim_bonus.SelectedIndexChanged += new System.EventHandler(this.combo_n0_claim_bonus_SelectedIndexChanged);
            // 
            // combo_vehicle_zone
            // 
            this.combo_vehicle_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_vehicle_zone.FormattingEnabled = true;
            this.combo_vehicle_zone.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.combo_vehicle_zone.Location = new System.Drawing.Point(257, 270);
            this.combo_vehicle_zone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_vehicle_zone.Name = "combo_vehicle_zone";
            this.combo_vehicle_zone.Size = new System.Drawing.Size(160, 23);
            this.combo_vehicle_zone.TabIndex = 13;
            this.combo_vehicle_zone.SelectedIndexChanged += new System.EventHandler(this.combo_vehicle_zone_SelectedIndexChanged);
            // 
            // lab_add_tonnage
            // 
            this.lab_add_tonnage.AutoSize = true;
            this.lab_add_tonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_add_tonnage.Location = new System.Drawing.Point(495, 53);
            this.lab_add_tonnage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_add_tonnage.Name = "lab_add_tonnage";
            this.lab_add_tonnage.Size = new System.Drawing.Size(162, 13);
            this.lab_add_tonnage.TabIndex = 39;
            this.lab_add_tonnage.Text = "Addl. Tonnage                 :";
            this.lab_add_tonnage.Click += new System.EventHandler(this.lab_add_tonnage_Click);
            // 
            // lab_nil_dep
            // 
            this.lab_nil_dep.AutoSize = true;
            this.lab_nil_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nil_dep.Location = new System.Drawing.Point(495, 78);
            this.lab_nil_dep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_nil_dep.Name = "lab_nil_dep";
            this.lab_nil_dep.Size = new System.Drawing.Size(161, 13);
            this.lab_nil_dep.TabIndex = 40;
            this.lab_nil_dep.Text = "NIL. Dep Premium            :";
            this.lab_nil_dep.Click += new System.EventHandler(this.lab_nil_dep_Click);
            // 
            // lab_total_amount
            // 
            this.lab_total_amount.AutoSize = true;
            this.lab_total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total_amount.Location = new System.Drawing.Point(495, 485);
            this.lab_total_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_total_amount.Name = "lab_total_amount";
            this.lab_total_amount.Size = new System.Drawing.Size(162, 13);
            this.lab_total_amount.TabIndex = 56;
            this.lab_total_amount.Text = "Total Amount                   :";
            this.lab_total_amount.Click += new System.EventHandler(this.lab_total_amount_Click);
            // 
            // lab_imt_23
            // 
            this.lab_imt_23.AutoSize = true;
            this.lab_imt_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_imt_23.Location = new System.Drawing.Point(495, 104);
            this.lab_imt_23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_imt_23.Name = "lab_imt_23";
            this.lab_imt_23.Size = new System.Drawing.Size(161, 13);
            this.lab_imt_23.TabIndex = 41;
            this.lab_imt_23.Text = "IMT 23 Pre,ium                :";
            this.lab_imt_23.Click += new System.EventHandler(this.lab_imt_23_Click);
            // 
            // lab_ser_tax
            // 
            this.lab_ser_tax.AutoSize = true;
            this.lab_ser_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ser_tax.Location = new System.Drawing.Point(495, 459);
            this.lab_ser_tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ser_tax.Name = "lab_ser_tax";
            this.lab_ser_tax.Size = new System.Drawing.Size(163, 13);
            this.lab_ser_tax.TabIndex = 55;
            this.lab_ser_tax.Text = "Service Tax                     :";
            this.lab_ser_tax.Click += new System.EventHandler(this.lab_ser_tax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Discount                         :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_tot_prem
            // 
            this.lab_tot_prem.AutoSize = true;
            this.lab_tot_prem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tot_prem.Location = new System.Drawing.Point(495, 434);
            this.lab_tot_prem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_tot_prem.Name = "lab_tot_prem";
            this.lab_tot_prem.Size = new System.Drawing.Size(163, 13);
            this.lab_tot_prem.TabIndex = 54;
            this.lab_tot_prem.Text = "Total Premium                  :";
            this.lab_tot_prem.Click += new System.EventHandler(this.lab_tot_prem_Click);
            // 
            // lab_ncb
            // 
            this.lab_ncb.AutoSize = true;
            this.lab_ncb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ncb.Location = new System.Drawing.Point(495, 155);
            this.lab_ncb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ncb.Name = "lab_ncb";
            this.lab_ncb.Size = new System.Drawing.Size(160, 13);
            this.lab_ncb.TabIndex = 43;
            this.lab_ncb.Text = "No Claim Bonus               :";
            this.lab_ncb.Click += new System.EventHandler(this.lab_ncb_Click);
            // 
            // lab_tp_total
            // 
            this.lab_tp_total.AutoSize = true;
            this.lab_tp_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tp_total.Location = new System.Drawing.Point(495, 408);
            this.lab_tp_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_tp_total.Name = "lab_tp_total";
            this.lab_tp_total.Size = new System.Drawing.Size(164, 13);
            this.lab_tp_total.TabIndex = 53;
            this.lab_tp_total.Text = "TP Total                          :";
            this.lab_tp_total.Click += new System.EventHandler(this.lab_tp_total_Click);
            // 
            // lab_od_total
            // 
            this.lab_od_total.AutoSize = true;
            this.lab_od_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_od_total.Location = new System.Drawing.Point(495, 180);
            this.lab_od_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_od_total.Name = "lab_od_total";
            this.lab_od_total.Size = new System.Drawing.Size(162, 13);
            this.lab_od_total.TabIndex = 44;
            this.lab_od_total.Text = "OD Total                         :";
            this.lab_od_total.Click += new System.EventHandler(this.lab_od_total_Click);
            // 
            // lab_pa_unnamed_pass
            // 
            this.lab_pa_unnamed_pass.AutoSize = true;
            this.lab_pa_unnamed_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pa_unnamed_pass.Location = new System.Drawing.Point(495, 383);
            this.lab_pa_unnamed_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pa_unnamed_pass.Name = "lab_pa_unnamed_pass";
            this.lab_pa_unnamed_pass.Size = new System.Drawing.Size(165, 13);
            this.lab_pa_unnamed_pass.TabIndex = 52;
            this.lab_pa_unnamed_pass.Text = "PA to Unnamed passenger :";
            this.lab_pa_unnamed_pass.Click += new System.EventHandler(this.lab_pa_unnamed_pass_Click);
            // 
            // lab_tp_basic
            // 
            this.lab_tp_basic.AutoSize = true;
            this.lab_tp_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tp_basic.Location = new System.Drawing.Point(495, 205);
            this.lab_tp_basic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_tp_basic.Name = "lab_tp_basic";
            this.lab_tp_basic.Size = new System.Drawing.Size(162, 13);
            this.lab_tp_basic.TabIndex = 45;
            this.lab_tp_basic.Text = "TP Basic                         :";
            this.lab_tp_basic.Click += new System.EventHandler(this.lab_tp_basic_Click);
            // 
            // lab_pa_dr_cl
            // 
            this.lab_pa_dr_cl.AutoSize = true;
            this.lab_pa_dr_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pa_dr_cl.Location = new System.Drawing.Point(495, 358);
            this.lab_pa_dr_cl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pa_dr_cl.Name = "lab_pa_dr_cl";
            this.lab_pa_dr_cl.Size = new System.Drawing.Size(155, 13);
            this.lab_pa_dr_cl.TabIndex = 51;
            this.lab_pa_dr_cl.Text = "PA to Dr and Cl              :";
            this.lab_pa_dr_cl.Click += new System.EventHandler(this.lab_pa_dr_cl_Click);
            // 
            // lab_tp_trailor
            // 
            this.lab_tp_trailor.AutoSize = true;
            this.lab_tp_trailor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tp_trailor.Location = new System.Drawing.Point(495, 231);
            this.lab_tp_trailor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_tp_trailor.Name = "lab_tp_trailor";
            this.lab_tp_trailor.Size = new System.Drawing.Size(162, 13);
            this.lab_tp_trailor.TabIndex = 46;
            this.lab_tp_trailor.Text = "TP Trailor Basic               :";
            this.lab_tp_trailor.Click += new System.EventHandler(this.lab_tp_trailor_Click);
            // 
            // lab_non_fare_passenger
            // 
            this.lab_non_fare_passenger.AutoSize = true;
            this.lab_non_fare_passenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_non_fare_passenger.Location = new System.Drawing.Point(495, 332);
            this.lab_non_fare_passenger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_non_fare_passenger.Name = "lab_non_fare_passenger";
            this.lab_non_fare_passenger.Size = new System.Drawing.Size(159, 13);
            this.lab_non_fare_passenger.TabIndex = 50;
            this.lab_non_fare_passenger.Text = "Non_Fare Passengers      :";
            this.lab_non_fare_passenger.Click += new System.EventHandler(this.lab_non_fare_passenger_Click);
            // 
            // lab_pa_owner_dr
            // 
            this.lab_pa_owner_dr.AutoSize = true;
            this.lab_pa_owner_dr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pa_owner_dr.Location = new System.Drawing.Point(495, 256);
            this.lab_pa_owner_dr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pa_owner_dr.Name = "lab_pa_owner_dr";
            this.lab_pa_owner_dr.Size = new System.Drawing.Size(160, 13);
            this.lab_pa_owner_dr.TabIndex = 47;
            this.lab_pa_owner_dr.Text = "PA to Owner Driver          :";
            this.lab_pa_owner_dr.Click += new System.EventHandler(this.lab_pa_owner_dr_Click);
            // 
            // lab_ll_liab_passenger
            // 
            this.lab_ll_liab_passenger.AutoSize = true;
            this.lab_ll_liab_passenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ll_liab_passenger.Location = new System.Drawing.Point(495, 307);
            this.lab_ll_liab_passenger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ll_liab_passenger.Name = "lab_ll_liab_passenger";
            this.lab_ll_liab_passenger.Size = new System.Drawing.Size(157, 13);
            this.lab_ll_liab_passenger.TabIndex = 49;
            this.lab_ll_liab_passenger.Text = "LL to Passengers            :";
            this.lab_ll_liab_passenger.Click += new System.EventHandler(this.lab_ll_liab_passenger_Click);
            // 
            // lab_ll_dr_cl
            // 
            this.lab_ll_dr_cl.AutoSize = true;
            this.lab_ll_dr_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ll_dr_cl.Location = new System.Drawing.Point(495, 282);
            this.lab_ll_dr_cl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ll_dr_cl.Name = "lab_ll_dr_cl";
            this.lab_ll_dr_cl.Size = new System.Drawing.Size(157, 13);
            this.lab_ll_dr_cl.TabIndex = 48;
            this.lab_ll_dr_cl.Text = "LL to Dr and Cl               :";
            this.lab_ll_dr_cl.Click += new System.EventHandler(this.lab_ll_dr_cl_Click);
            // 
            // lab_od_basic
            // 
            this.lab_od_basic.AutoSize = true;
            this.lab_od_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_od_basic.Location = new System.Drawing.Point(495, 28);
            this.lab_od_basic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_od_basic.Name = "lab_od_basic";
            this.lab_od_basic.Size = new System.Drawing.Size(160, 13);
            this.lab_od_basic.TabIndex = 38;
            this.lab_od_basic.Text = "OD Basic                        :";
            this.lab_od_basic.Click += new System.EventHandler(this.lab_od_basic_Click);
            // 
            // text_od_basic
            // 
            this.text_od_basic.Enabled = false;
            this.text_od_basic.Location = new System.Drawing.Point(725, 20);
            this.text_od_basic.Name = "text_od_basic";
            this.text_od_basic.Size = new System.Drawing.Size(100, 21);
            this.text_od_basic.TabIndex = 57;
            // 
            // text_addl_tonnage
            // 
            this.text_addl_tonnage.Enabled = false;
            this.text_addl_tonnage.Location = new System.Drawing.Point(725, 45);
            this.text_addl_tonnage.Name = "text_addl_tonnage";
            this.text_addl_tonnage.Size = new System.Drawing.Size(100, 21);
            this.text_addl_tonnage.TabIndex = 58;
            // 
            // text_nil_dep_premium
            // 
            this.text_nil_dep_premium.Enabled = false;
            this.text_nil_dep_premium.Location = new System.Drawing.Point(725, 70);
            this.text_nil_dep_premium.Name = "text_nil_dep_premium";
            this.text_nil_dep_premium.Size = new System.Drawing.Size(100, 21);
            this.text_nil_dep_premium.TabIndex = 59;
            // 
            // text_imt_23
            // 
            this.text_imt_23.Enabled = false;
            this.text_imt_23.Location = new System.Drawing.Point(725, 96);
            this.text_imt_23.Name = "text_imt_23";
            this.text_imt_23.Size = new System.Drawing.Size(100, 21);
            this.text_imt_23.TabIndex = 60;
            // 
            // text_disc
            // 
            this.text_disc.Enabled = false;
            this.text_disc.Location = new System.Drawing.Point(725, 121);
            this.text_disc.Name = "text_disc";
            this.text_disc.Size = new System.Drawing.Size(100, 21);
            this.text_disc.TabIndex = 61;
            // 
            // text_no_claim_bonus
            // 
            this.text_no_claim_bonus.Enabled = false;
            this.text_no_claim_bonus.Location = new System.Drawing.Point(725, 147);
            this.text_no_claim_bonus.Name = "text_no_claim_bonus";
            this.text_no_claim_bonus.Size = new System.Drawing.Size(100, 21);
            this.text_no_claim_bonus.TabIndex = 62;
            // 
            // text_od_total
            // 
            this.text_od_total.Enabled = false;
            this.text_od_total.Location = new System.Drawing.Point(725, 175);
            this.text_od_total.Name = "text_od_total";
            this.text_od_total.Size = new System.Drawing.Size(100, 21);
            this.text_od_total.TabIndex = 63;
            // 
            // text_tp_basic
            // 
            this.text_tp_basic.Enabled = false;
            this.text_tp_basic.Location = new System.Drawing.Point(725, 197);
            this.text_tp_basic.Name = "text_tp_basic";
            this.text_tp_basic.Size = new System.Drawing.Size(100, 21);
            this.text_tp_basic.TabIndex = 64;
            // 
            // text_tp_trl_basic
            // 
            this.text_tp_trl_basic.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_tp_trl_basic.Enabled = false;
            this.text_tp_trl_basic.Location = new System.Drawing.Point(725, 223);
            this.text_tp_trl_basic.Name = "text_tp_trl_basic";
            this.text_tp_trl_basic.Size = new System.Drawing.Size(100, 21);
            this.text_tp_trl_basic.TabIndex = 65;
            // 
            // text_pa_to_owner_dr
            // 
            this.text_pa_to_owner_dr.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_pa_to_owner_dr.Enabled = false;
            this.text_pa_to_owner_dr.Location = new System.Drawing.Point(725, 248);
            this.text_pa_to_owner_dr.Name = "text_pa_to_owner_dr";
            this.text_pa_to_owner_dr.Size = new System.Drawing.Size(100, 21);
            this.text_pa_to_owner_dr.TabIndex = 66;
            // 
            // text_ll_to_dr_cl
            // 
            this.text_ll_to_dr_cl.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_ll_to_dr_cl.Enabled = false;
            this.text_ll_to_dr_cl.Location = new System.Drawing.Point(725, 277);
            this.text_ll_to_dr_cl.Name = "text_ll_to_dr_cl";
            this.text_ll_to_dr_cl.Size = new System.Drawing.Size(100, 21);
            this.text_ll_to_dr_cl.TabIndex = 67;
            // 
            // text_to_passengers
            // 
            this.text_to_passengers.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_to_passengers.Enabled = false;
            this.text_to_passengers.Location = new System.Drawing.Point(725, 302);
            this.text_to_passengers.Name = "text_to_passengers";
            this.text_to_passengers.Size = new System.Drawing.Size(100, 21);
            this.text_to_passengers.TabIndex = 68;
            // 
            // text_non_fare_pass
            // 
            this.text_non_fare_pass.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_non_fare_pass.Enabled = false;
            this.text_non_fare_pass.Location = new System.Drawing.Point(725, 327);
            this.text_non_fare_pass.Name = "text_non_fare_pass";
            this.text_non_fare_pass.Size = new System.Drawing.Size(100, 21);
            this.text_non_fare_pass.TabIndex = 69;
            // 
            // text_pa_dr_cl
            // 
            this.text_pa_dr_cl.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_pa_dr_cl.Enabled = false;
            this.text_pa_dr_cl.Location = new System.Drawing.Point(725, 350);
            this.text_pa_dr_cl.Name = "text_pa_dr_cl";
            this.text_pa_dr_cl.Size = new System.Drawing.Size(100, 21);
            this.text_pa_dr_cl.TabIndex = 70;
            // 
            // text_pa_unnamed_pass
            // 
            this.text_pa_unnamed_pass.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_pa_unnamed_pass.Enabled = false;
            this.text_pa_unnamed_pass.Location = new System.Drawing.Point(725, 377);
            this.text_pa_unnamed_pass.Name = "text_pa_unnamed_pass";
            this.text_pa_unnamed_pass.Size = new System.Drawing.Size(100, 21);
            this.text_pa_unnamed_pass.TabIndex = 71;
            // 
            // text_tp_total
            // 
            this.text_tp_total.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_tp_total.Enabled = false;
            this.text_tp_total.Location = new System.Drawing.Point(725, 400);
            this.text_tp_total.Name = "text_tp_total";
            this.text_tp_total.Size = new System.Drawing.Size(100, 21);
            this.text_tp_total.TabIndex = 72;
            // 
            // text_total_premium
            // 
            this.text_total_premium.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_total_premium.Enabled = false;
            this.text_total_premium.Location = new System.Drawing.Point(725, 426);
            this.text_total_premium.Name = "text_total_premium";
            this.text_total_premium.Size = new System.Drawing.Size(100, 21);
            this.text_total_premium.TabIndex = 73;
            // 
            // text_service_tax
            // 
            this.text_service_tax.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_service_tax.Enabled = false;
            this.text_service_tax.Location = new System.Drawing.Point(725, 454);
            this.text_service_tax.Name = "text_service_tax";
            this.text_service_tax.Size = new System.Drawing.Size(100, 21);
            this.text_service_tax.TabIndex = 74;
            // 
            // text_total_amount
            // 
            this.text_total_amount.AutoCompleteCustomSource.AddRange(new string[] {
            "0.00"});
            this.text_total_amount.Enabled = false;
            this.text_total_amount.Location = new System.Drawing.Point(725, 480);
            this.text_total_amount.Name = "text_total_amount";
            this.text_total_amount.Size = new System.Drawing.Size(100, 21);
            this.text_total_amount.TabIndex = 75;
            // 
            // but_calculatr
            // 
            this.but_calculatr.Location = new System.Drawing.Point(365, 560);
            this.but_calculatr.Name = "but_calculatr";
            this.but_calculatr.Size = new System.Drawing.Size(161, 42);
            this.but_calculatr.TabIndex = 77;
            this.but_calculatr.Text = "Calculate";
            this.but_calculatr.UseVisualStyleBackColor = true;
            this.but_calculatr.Click += new System.EventHandler(this.but_calculatr_Click);
            // 
            // lab_nil_dep_req
            // 
            this.lab_nil_dep_req.AutoSize = true;
            this.lab_nil_dep_req.Location = new System.Drawing.Point(41, 333);
            this.lab_nil_dep_req.Name = "lab_nil_dep_req";
            this.lab_nil_dep_req.Size = new System.Drawing.Size(126, 15);
            this.lab_nil_dep_req.TabIndex = 78;
            this.lab_nil_dep_req.Text = "NIL Dep. Required";
            // 
            // combo_nil_dep
            // 
            this.combo_nil_dep.FormattingEnabled = true;
            this.combo_nil_dep.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.combo_nil_dep.Location = new System.Drawing.Point(257, 330);
            this.combo_nil_dep.Name = "combo_nil_dep";
            this.combo_nil_dep.Size = new System.Drawing.Size(160, 23);
            this.combo_nil_dep.TabIndex = 79;
            // 
            // lab_gvw
            // 
            this.lab_gvw.AutoSize = true;
            this.lab_gvw.Location = new System.Drawing.Point(41, 305);
            this.lab_gvw.Name = "lab_gvw";
            this.lab_gvw.Size = new System.Drawing.Size(45, 15);
            this.lab_gvw.TabIndex = 80;
            this.lab_gvw.Text = "G V W";
            // 
            // lab_pa_owner_driver
            // 
            this.lab_pa_owner_driver.AutoSize = true;
            this.lab_pa_owner_driver.Location = new System.Drawing.Point(41, 367);
            this.lab_pa_owner_driver.Name = "lab_pa_owner_driver";
            this.lab_pa_owner_driver.Size = new System.Drawing.Size(131, 15);
            this.lab_pa_owner_driver.TabIndex = 82;
            this.lab_pa_owner_driver.Text = "PA to Owner Driver ";
            // 
            // combo_pa_owner_driver
            // 
            this.combo_pa_owner_driver.FormattingEnabled = true;
            this.combo_pa_owner_driver.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.combo_pa_owner_driver.Location = new System.Drawing.Point(257, 359);
            this.combo_pa_owner_driver.Name = "combo_pa_owner_driver";
            this.combo_pa_owner_driver.Size = new System.Drawing.Size(160, 23);
            this.combo_pa_owner_driver.TabIndex = 83;
            // 
            // lab_pa_to_dr_cl
            // 
            this.lab_pa_to_dr_cl.AutoSize = true;
            this.lab_pa_to_dr_cl.Location = new System.Drawing.Point(41, 426);
            this.lab_pa_to_dr_cl.Name = "lab_pa_to_dr_cl";
            this.lab_pa_to_dr_cl.Size = new System.Drawing.Size(167, 15);
            this.lab_pa_to_dr_cl.TabIndex = 84;
            this.lab_pa_to_dr_cl.Text = "PA to Driver, Cleaner etc ";
            // 
            // combo_pa_dr_cl
            // 
            this.combo_pa_dr_cl.FormattingEnabled = true;
            this.combo_pa_dr_cl.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.combo_pa_dr_cl.Location = new System.Drawing.Point(257, 423);
            this.combo_pa_dr_cl.Name = "combo_pa_dr_cl";
            this.combo_pa_dr_cl.Size = new System.Drawing.Size(160, 23);
            this.combo_pa_dr_cl.TabIndex = 85;
            // 
            // lab_pa_sum_dr_cl
            // 
            this.lab_pa_sum_dr_cl.AutoSize = true;
            this.lab_pa_sum_dr_cl.Location = new System.Drawing.Point(39, 454);
            this.lab_pa_sum_dr_cl.Name = "lab_pa_sum_dr_cl";
            this.lab_pa_sum_dr_cl.Size = new System.Drawing.Size(169, 15);
            this.lab_pa_sum_dr_cl.TabIndex = 86;
            this.lab_pa_sum_dr_cl.Text = "PA Sum Insure to Dr. , Cl.";
            // 
            // lab_lg_lia_dr_cl_no
            // 
            this.lab_lg_lia_dr_cl_no.AutoSize = true;
            this.lab_lg_lia_dr_cl_no.Location = new System.Drawing.Point(41, 397);
            this.lab_lg_lia_dr_cl_no.Name = "lab_lg_lia_dr_cl_no";
            this.lab_lg_lia_dr_cl_no.Size = new System.Drawing.Size(174, 15);
            this.lab_lg_lia_dr_cl_no.TabIndex = 88;
            this.lab_lg_lia_dr_cl_no.Text = "Lg. Lia. to Dr., Cl. Number";
            // 
            // combo_lg_lia_dr_cl
            // 
            this.combo_lg_lia_dr_cl.BackColor = System.Drawing.SystemColors.Window;
            this.combo_lg_lia_dr_cl.FormattingEnabled = true;
            this.combo_lg_lia_dr_cl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combo_lg_lia_dr_cl.Location = new System.Drawing.Point(257, 389);
            this.combo_lg_lia_dr_cl.Name = "combo_lg_lia_dr_cl";
            this.combo_lg_lia_dr_cl.Size = new System.Drawing.Size(160, 23);
            this.combo_lg_lia_dr_cl.TabIndex = 89;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(666, 560);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 90;
            // 
            // num_cubic_capacity
            // 
            this.num_cubic_capacity.Location = new System.Drawing.Point(257, 138);
            this.num_cubic_capacity.Name = "num_cubic_capacity";
            this.num_cubic_capacity.Size = new System.Drawing.Size(160, 21);
            this.num_cubic_capacity.TabIndex = 90;
            // 
            // num_insured_declared_value
            // 
            this.num_insured_declared_value.Location = new System.Drawing.Point(257, 168);
            this.num_insured_declared_value.Name = "num_insured_declared_value";
            this.num_insured_declared_value.Size = new System.Drawing.Size(160, 21);
            this.num_insured_declared_value.TabIndex = 90;
            // 
            // num_discount
            // 
            this.num_discount.Location = new System.Drawing.Point(257, 236);
            this.num_discount.Name = "num_discount";
            this.num_discount.Size = new System.Drawing.Size(160, 21);
            this.num_discount.TabIndex = 90;
            // 
            // num_gvw
            // 
            this.num_gvw.Location = new System.Drawing.Point(257, 299);
            this.num_gvw.Name = "num_gvw";
            this.num_gvw.Size = new System.Drawing.Size(160, 21);
            this.num_gvw.TabIndex = 90;
            // 
            // num_pa_sum_insured
            // 
            this.num_pa_sum_insured.Location = new System.Drawing.Point(257, 451);
            this.num_pa_sum_insured.Name = "num_pa_sum_insured";
            this.num_pa_sum_insured.Size = new System.Drawing.Size(160, 21);
            this.num_pa_sum_insured.TabIndex = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 614);
            this.Controls.Add(this.num_cubic_capacity);
            this.Controls.Add(this.num_pa_sum_insured);
            this.Controls.Add(this.num_discount);
            this.Controls.Add(this.num_gvw);
            this.Controls.Add(this.num_insured_declared_value);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.combo_lg_lia_dr_cl);
            this.Controls.Add(this.lab_lg_lia_dr_cl_no);
            this.Controls.Add(this.lab_pa_sum_dr_cl);
            this.Controls.Add(this.combo_pa_dr_cl);
            this.Controls.Add(this.lab_pa_to_dr_cl);
            this.Controls.Add(this.combo_pa_owner_driver);
            this.Controls.Add(this.lab_pa_owner_driver);
            this.Controls.Add(this.lab_gvw);
            this.Controls.Add(this.combo_nil_dep);
            this.Controls.Add(this.lab_nil_dep_req);
            this.Controls.Add(this.but_calculatr);
            this.Controls.Add(this.text_total_amount);
            this.Controls.Add(this.text_service_tax);
            this.Controls.Add(this.text_total_premium);
            this.Controls.Add(this.text_tp_total);
            this.Controls.Add(this.text_pa_unnamed_pass);
            this.Controls.Add(this.text_pa_dr_cl);
            this.Controls.Add(this.text_non_fare_pass);
            this.Controls.Add(this.text_to_passengers);
            this.Controls.Add(this.text_ll_to_dr_cl);
            this.Controls.Add(this.text_pa_to_owner_dr);
            this.Controls.Add(this.text_tp_trl_basic);
            this.Controls.Add(this.text_tp_basic);
            this.Controls.Add(this.text_od_total);
            this.Controls.Add(this.text_no_claim_bonus);
            this.Controls.Add(this.text_disc);
            this.Controls.Add(this.text_imt_23);
            this.Controls.Add(this.text_nil_dep_premium);
            this.Controls.Add(this.text_addl_tonnage);
            this.Controls.Add(this.text_od_basic);
            this.Controls.Add(this.lab_add_tonnage);
            this.Controls.Add(this.lab_nil_dep);
            this.Controls.Add(this.lab_total_amount);
            this.Controls.Add(this.lab_imt_23);
            this.Controls.Add(this.lab_ser_tax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_tot_prem);
            this.Controls.Add(this.lab_ncb);
            this.Controls.Add(this.lab_tp_total);
            this.Controls.Add(this.lab_od_total);
            this.Controls.Add(this.lab_pa_unnamed_pass);
            this.Controls.Add(this.lab_tp_basic);
            this.Controls.Add(this.lab_pa_dr_cl);
            this.Controls.Add(this.lab_tp_trailor);
            this.Controls.Add(this.lab_non_fare_passenger);
            this.Controls.Add(this.lab_pa_owner_dr);
            this.Controls.Add(this.lab_ll_liab_passenger);
            this.Controls.Add(this.lab_ll_dr_cl);
            this.Controls.Add(this.lab_od_basic);
            this.Controls.Add(this.combo_vehicle_zone);
            this.Controls.Add(this.combo_n0_claim_bonus);
            this.Controls.Add(this.combo_age_of_vehicle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combo_type_of_vehicle);
            this.Controls.Add(this.lab_vehicle_zone);
            this.Controls.Add(this.lab_discount);
            this.Controls.Add(this.lab_no_claim_bonus);
            this.Controls.Add(this.lab_insured_declared_value);
            this.Controls.Add(this.lab_cubic_capacity);
            this.Controls.Add(this.lab_age_of_vehicle);
            this.Controls.Add(this.lab_type_of_vehicle);
            this.Controls.Add(this.lab_date);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Motor Premium Caliculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cubic_capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_insured_declared_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_pa_sum_insured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Label lab_type_of_vehicle;
        private System.Windows.Forms.Label lab_age_of_vehicle;
        private System.Windows.Forms.Label lab_cubic_capacity;
        private System.Windows.Forms.Label lab_insured_declared_value;
        private System.Windows.Forms.Label lab_no_claim_bonus;
        private System.Windows.Forms.Label lab_discount;
        private System.Windows.Forms.Label lab_vehicle_zone;
        private System.Windows.Forms.ComboBox combo_type_of_vehicle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combo_age_of_vehicle;
        private System.Windows.Forms.ComboBox combo_n0_claim_bonus;
        private System.Windows.Forms.ComboBox combo_vehicle_zone;
        private System.Windows.Forms.Label lab_add_tonnage;
        private System.Windows.Forms.Label lab_nil_dep;
        private System.Windows.Forms.Label lab_total_amount;
        private System.Windows.Forms.Label lab_imt_23;
        private System.Windows.Forms.Label lab_ser_tax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_tot_prem;
        private System.Windows.Forms.Label lab_ncb;
        private System.Windows.Forms.Label lab_tp_total;
        private System.Windows.Forms.Label lab_od_total;
        private System.Windows.Forms.Label lab_pa_unnamed_pass;
        private System.Windows.Forms.Label lab_tp_basic;
        private System.Windows.Forms.Label lab_pa_dr_cl;
        private System.Windows.Forms.Label lab_tp_trailor;
        private System.Windows.Forms.Label lab_non_fare_passenger;
        private System.Windows.Forms.Label lab_pa_owner_dr;
        private System.Windows.Forms.Label lab_ll_liab_passenger;
        private System.Windows.Forms.Label lab_ll_dr_cl;
        private System.Windows.Forms.Label lab_od_basic;
        private System.Windows.Forms.TextBox text_od_basic;
        private System.Windows.Forms.TextBox text_addl_tonnage;
        private System.Windows.Forms.TextBox text_nil_dep_premium;
        private System.Windows.Forms.TextBox text_imt_23;
        private System.Windows.Forms.TextBox text_disc;
        private System.Windows.Forms.TextBox text_no_claim_bonus;
        private System.Windows.Forms.TextBox text_od_total;
        private System.Windows.Forms.TextBox text_tp_basic;
        private System.Windows.Forms.TextBox text_tp_trl_basic;
        private System.Windows.Forms.TextBox text_pa_to_owner_dr;
        private System.Windows.Forms.TextBox text_ll_to_dr_cl;
        private System.Windows.Forms.TextBox text_to_passengers;
        private System.Windows.Forms.TextBox text_non_fare_pass;
        private System.Windows.Forms.TextBox text_pa_dr_cl;
        private System.Windows.Forms.TextBox text_pa_unnamed_pass;
        private System.Windows.Forms.TextBox text_tp_total;
        private System.Windows.Forms.TextBox text_total_premium;
        private System.Windows.Forms.TextBox text_service_tax;
        private System.Windows.Forms.TextBox text_total_amount;
        private System.Windows.Forms.Button but_calculatr;
        private System.Windows.Forms.Label lab_nil_dep_req;
        private System.Windows.Forms.ComboBox combo_nil_dep;
        private System.Windows.Forms.Label lab_gvw;
        private System.Windows.Forms.Label lab_pa_owner_driver;
        private System.Windows.Forms.ComboBox combo_pa_owner_driver;
        private System.Windows.Forms.Label lab_pa_to_dr_cl;
        private System.Windows.Forms.ComboBox combo_pa_dr_cl;
        private System.Windows.Forms.Label lab_pa_sum_dr_cl;
        private System.Windows.Forms.Label lab_lg_lia_dr_cl_no;
        private System.Windows.Forms.ComboBox combo_lg_lia_dr_cl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown num_cubic_capacity;
        private System.Windows.Forms.NumericUpDown num_insured_declared_value;
        private System.Windows.Forms.NumericUpDown num_discount;
        private System.Windows.Forms.NumericUpDown num_gvw;
        private System.Windows.Forms.NumericUpDown num_pa_sum_insured;
    }
}

