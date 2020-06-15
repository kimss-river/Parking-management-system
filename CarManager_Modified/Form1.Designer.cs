namespace CarManager_Modified
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.logPrint = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pRemoveBtn = new System.Windows.Forms.Button();
            this.pAddBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot_lookUp = new System.Windows.Forms.TextBox();
            this.selLookUpBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_DisplayNowtime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip_Now.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox2.Location = new System.Drawing.Point(13, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AutoGenerateColumns = false;
            this.dataGridView_parkingManager.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_parkingManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView_parkingManager.DataSource = this.parkingCarBindingSource;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.RowHeadersWidth = 51;
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(672, 262);
            this.dataGridView_parkingManager.TabIndex = 2;
            this.dataGridView_parkingManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_parkingManager_CurrentCellChanged);
            // 
            // logPrint
            // 
            this.logPrint.FormattingEnabled = true;
            this.logPrint.HorizontalScrollbar = true;
            this.logPrint.ItemHeight = 14;
            this.logPrint.Location = new System.Drawing.Point(17, 551);
            this.logPrint.Name = "logPrint";
            this.logPrint.Size = new System.Drawing.Size(674, 74);
            this.logPrint.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_parkingSpot);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_phoneNumber);
            this.groupBox4.Controls.Add(this.textBox_driverName);
            this.groupBox4.Controls.Add(this.textBox_carNumber);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.pRemoveBtn);
            this.groupBox4.Controls.Add(this.pAddBtn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(13, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 154);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "주차/출차";
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(73, 19);
            this.textBox_parkingSpot.MaxLength = 13;
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "공간번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "전화번호";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(73, 119);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_phoneNumber.TabIndex = 7;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(73, 87);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 21);
            this.textBox_driverName.TabIndex = 6;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(73, 56);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_carNumber.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "차주이름";
            // 
            // pRemoveBtn
            // 
            this.pRemoveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pRemoveBtn.Location = new System.Drawing.Point(205, 57);
            this.pRemoveBtn.Name = "pRemoveBtn";
            this.pRemoveBtn.Size = new System.Drawing.Size(75, 27);
            this.pRemoveBtn.TabIndex = 2;
            this.pRemoveBtn.Text = "출차";
            this.pRemoveBtn.UseVisualStyleBackColor = false;
            this.pRemoveBtn.Click += new System.EventHandler(this.button_parkingRemove_Click);
            // 
            // pAddBtn
            // 
            this.pAddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAddBtn.Location = new System.Drawing.Point(205, 23);
            this.pAddBtn.Name = "pAddBtn";
            this.pAddBtn.Size = new System.Drawing.Size(75, 27);
            this.pAddBtn.TabIndex = 1;
            this.pAddBtn.Text = "주차";
            this.pAddBtn.UseVisualStyleBackColor = false;
            this.pAddBtn.Click += new System.EventHandler(this.button_parkingAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "차량번호";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_parkingSpot_lookUp);
            this.groupBox1.Controls.Add(this.selLookUpBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(351, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 75);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차 공간 현황 관리";
            // 
            // textBox_parkingSpot_lookUp
            // 
            this.textBox_parkingSpot_lookUp.Location = new System.Drawing.Point(73, 21);
            this.textBox_parkingSpot_lookUp.Name = "textBox_parkingSpot_lookUp";
            this.textBox_parkingSpot_lookUp.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot_lookUp.TabIndex = 5;
            // 
            // selLookUpBtn
            // 
            this.selLookUpBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selLookUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selLookUpBtn.Location = new System.Drawing.Point(205, 19);
            this.selLookUpBtn.Name = "selLookUpBtn";
            this.selLookUpBtn.Size = new System.Drawing.Size(75, 27);
            this.selLookUpBtn.TabIndex = 1;
            this.selLookUpBtn.Text = "조회";
            this.selLookUpBtn.UseVisualStyleBackColor = false;
            this.selLookUpBtn.Click += new System.EventHandler(this.button_SelectedLookUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "공간번호";
            // 
            // timer_DisplayNowtime
            // 
            this.timer_DisplayNowtime.Enabled = true;
            this.timer_DisplayNowtime.Interval = 1000;
            this.timer_DisplayNowtime.Tick += new System.EventHandler(this.timer_DisplayNowtime_Tick);
            // 
            // statusStrip_Now
            // 
            this.statusStrip_Now.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip_Now.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Now});
            this.statusStrip_Now.Location = new System.Drawing.Point(0, 639);
            this.statusStrip_Now.Name = "statusStrip_Now";
            this.statusStrip_Now.Size = new System.Drawing.Size(710, 22);
            this.statusStrip_Now.TabIndex = 16;
            this.statusStrip_Now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Now
            // 
            this.toolStripStatusLabel_Now.Name = "toolStripStatusLabel_Now";
            this.toolStripStatusLabel_Now.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_Now.Text = "-";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(671, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 25);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 46);
            this.panel1.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 536);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 97);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 관리 기록";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ParkingSpot";
            this.dataGridViewTextBoxColumn1.HeaderText = "ParkingSpot";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarNumber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DriverName";
            this.dataGridViewTextBoxColumn3.HeaderText = "DriverName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ParkingTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "ParkingTime";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(CarManager_Modified.ParkingCar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(710, 661);
            this.Controls.Add(this.logPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip_Now);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip_Now.ResumeLayout(false);
            this.statusStrip_Now.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox logPrint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button pRemoveBtn;
        private System.Windows.Forms.Button pAddBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_parkingSpot_lookUp;
        private System.Windows.Forms.Button selLookUpBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip_Now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Now;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer_DisplayNowtime;
    }
}

