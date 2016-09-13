namespace MDWlite
{
    partial class TabletMonitor
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.dgvEPCs = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.tbcAll = new System.Windows.Forms.TabControl();
            this.tb0 = new System.Windows.Forms.TabPage();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.dgvTablets = new System.Windows.Forms.DataGridView();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numBorrar = new System.Windows.Forms.NumericUpDown();
            this.numNerror = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numNsuccess = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numONerror = new System.Windows.Forms.NumericUpDown();
            this.numOFFerror = new System.Windows.Forms.NumericUpDown();
            this.numOFFsuccess = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numError = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numONsuccess = new System.Windows.Forms.NumericUpDown();
            this.numSuccess = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPCs)).BeginInit();
            this.tbcAll.SuspendLayout();
            this.tb1.SuspendLayout();
            this.tb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablets)).BeginInit();
            this.tb4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNsuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numONerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOFFerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOFFsuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numONsuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSuccess)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(7, 55);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(93, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvEPCs
            // 
            this.dgvEPCs.AllowUserToAddRows = false;
            this.dgvEPCs.AllowUserToDeleteRows = false;
            this.dgvEPCs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEPCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEPCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEPCs.Location = new System.Drawing.Point(3, 3);
            this.dgvEPCs.Name = "dgvEPCs";
            this.dgvEPCs.ReadOnly = true;
            this.dgvEPCs.Size = new System.Drawing.Size(848, 420);
            this.dgvEPCs.TabIndex = 2;
            this.dgvEPCs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEPCs_DataError);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(27, 255);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 18);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Status:";
            // 
            // tbcAll
            // 
            this.tbcAll.Controls.Add(this.tb0);
            this.tbcAll.Controls.Add(this.tb1);
            this.tbcAll.Controls.Add(this.tb2);
            this.tbcAll.Controls.Add(this.tb3);
            this.tbcAll.Controls.Add(this.tb4);
            this.tbcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAll.Location = new System.Drawing.Point(0, 0);
            this.tbcAll.Name = "tbcAll";
            this.tbcAll.SelectedIndex = 0;
            this.tbcAll.Size = new System.Drawing.Size(862, 457);
            this.tbcAll.TabIndex = 5;
            // 
            // tb0
            // 
            this.tb0.Location = new System.Drawing.Point(4, 27);
            this.tb0.Name = "tb0";
            this.tb0.Padding = new System.Windows.Forms.Padding(3);
            this.tb0.Size = new System.Drawing.Size(854, 426);
            this.tb0.TabIndex = 4;
            this.tb0.Text = "Monitoreo";
            this.tb0.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.dgvEPCs);
            this.tb1.Location = new System.Drawing.Point(4, 27);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(854, 426);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Reading Table";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.dgvUsers);
            this.tb2.Location = new System.Drawing.Point(4, 27);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(854, 426);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Usuarios";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(848, 420);
            this.dgvUsers.TabIndex = 0;
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.dgvTablets);
            this.tb3.Location = new System.Drawing.Point(4, 27);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(854, 426);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Tablets";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // dgvTablets
            // 
            this.dgvTablets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablets.Location = new System.Drawing.Point(0, 0);
            this.dgvTablets.Name = "dgvTablets";
            this.dgvTablets.Size = new System.Drawing.Size(854, 426);
            this.dgvTablets.TabIndex = 0;
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.groupBox2);
            this.tb4.Controls.Add(this.groupBox1);
            this.tb4.Location = new System.Drawing.Point(4, 27);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(854, 426);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Configuraciones";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numBorrar);
            this.groupBox2.Controls.Add(this.numNerror);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numNsuccess);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numONerror);
            this.groupBox2.Controls.Add(this.numOFFerror);
            this.groupBox2.Controls.Add(this.numOFFsuccess);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numError);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numONsuccess);
            this.groupBox2.Controls.Add(this.numSuccess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(277, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Listo p/asignación:";
            // 
            // numBorrar
            // 
            this.numBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBorrar.Location = new System.Drawing.Point(422, 36);
            this.numBorrar.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numBorrar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBorrar.Name = "numBorrar";
            this.numBorrar.Size = new System.Drawing.Size(95, 22);
            this.numBorrar.TabIndex = 24;
            this.numBorrar.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numNerror
            // 
            this.numNerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNerror.Location = new System.Drawing.Point(422, 148);
            this.numNerror.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNerror.Name = "numNerror";
            this.numNerror.Size = new System.Drawing.Size(95, 22);
            this.numNerror.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(312, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Repeticiones:";
            // 
            // numNsuccess
            // 
            this.numNsuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNsuccess.Location = new System.Drawing.Point(151, 148);
            this.numNsuccess.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNsuccess.Name = "numNsuccess";
            this.numNsuccess.Size = new System.Drawing.Size(95, 22);
            this.numNsuccess.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Repeticiones:";
            // 
            // numONerror
            // 
            this.numONerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numONerror.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numONerror.Location = new System.Drawing.Point(422, 92);
            this.numONerror.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numONerror.Name = "numONerror";
            this.numONerror.Size = new System.Drawing.Size(95, 22);
            this.numONerror.TabIndex = 18;
            // 
            // numOFFerror
            // 
            this.numOFFerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOFFerror.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOFFerror.Location = new System.Drawing.Point(422, 120);
            this.numOFFerror.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOFFerror.Name = "numOFFerror";
            this.numOFFerror.Size = new System.Drawing.Size(95, 22);
            this.numOFFerror.TabIndex = 17;
            // 
            // numOFFsuccess
            // 
            this.numOFFsuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOFFsuccess.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOFFsuccess.Location = new System.Drawing.Point(151, 120);
            this.numOFFsuccess.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOFFsuccess.Name = "numOFFsuccess";
            this.numOFFsuccess.Size = new System.Drawing.Size(95, 22);
            this.numOFFsuccess.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "TOFF error (ms):";
            // 
            // numError
            // 
            this.numError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numError.Location = new System.Drawing.Point(422, 64);
            this.numError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numError.Name = "numError";
            this.numError.Size = new System.Drawing.Size(95, 22);
            this.numError.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "TON error (ms):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Bit error:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "TOFF éxito (ms):";
            // 
            // numONsuccess
            // 
            this.numONsuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numONsuccess.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numONsuccess.Location = new System.Drawing.Point(151, 92);
            this.numONsuccess.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numONsuccess.Name = "numONsuccess";
            this.numONsuccess.Size = new System.Drawing.Size(95, 22);
            this.numONsuccess.TabIndex = 6;
            // 
            // numSuccess
            // 
            this.numSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSuccess.Location = new System.Drawing.Point(151, 64);
            this.numSuccess.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSuccess.Name = "numSuccess";
            this.numSuccess.Size = new System.Drawing.Size(95, 22);
            this.numSuccess.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "TON éxito (ms):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bit éxito:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.numPower);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Potencia:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(102, 49);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(157, 22);
            this.txtIP.TabIndex = 3;
            // 
            // numPower
            // 
            this.numPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPower.Location = new System.Drawing.Point(102, 21);
            this.numPower.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numPower.Name = "numPower";
            this.numPower.Size = new System.Drawing.Size(157, 22);
            this.numPower.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "EPC Assignment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.lbl2);
            this.splitMain.Panel1.Controls.Add(this.label13);
            this.splitMain.Panel1.Controls.Add(this.btnConnect);
            this.splitMain.Panel1.Controls.Add(this.button4);
            this.splitMain.Panel1.Controls.Add(this.lbl);
            this.splitMain.Panel1.Controls.Add(this.btnPlay);
            this.splitMain.Panel1.Controls.Add(this.button3);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tbcAll);
            this.splitMain.Size = new System.Drawing.Size(974, 457);
            this.splitMain.SplitterDistance = 108;
            this.splitMain.TabIndex = 9;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(27, 225);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(31, 18);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Off";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Status:";
            // 
            // TabletMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 457);
            this.Controls.Add(this.splitMain);
            this.Name = "TabletMonitor";
            this.Text = "Monitoreo de Tablets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPCs)).EndInit();
            this.tbcAll.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablets)).EndInit();
            this.tb4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNsuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numONerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOFFerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOFFsuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numONsuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSuccess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridView dgvEPCs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TabControl tbcAll;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.TabPage tb4;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numONsuccess;
        private System.Windows.Forms.NumericUpDown numSuccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numNerror;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numNsuccess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numONerror;
        private System.Windows.Forms.NumericUpDown numOFFerror;
        private System.Windows.Forms.NumericUpDown numOFFsuccess;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvTablets;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numBorrar;
        private System.Windows.Forms.TabPage tb0;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label13;
    }
}

