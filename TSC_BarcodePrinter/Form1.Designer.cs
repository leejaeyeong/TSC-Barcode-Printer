namespace TSC_BarcodePrinter
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_print = new System.Windows.Forms.Button();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.check_type = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_numberPage = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.lb_converted = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_config = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_concentration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_gap = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberPage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_concentration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(6, 132);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(425, 84);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "바코드 출력";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // tb_serial
            // 
            this.tb_serial.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serial.Location = new System.Drawing.Point(114, 45);
            this.tb_serial.MaxLength = 6;
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.Size = new System.Drawing.Size(183, 30);
            this.tb_serial.TabIndex = 1;
            this.tb_serial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_serial_KeyUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 460);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "용지 출력";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.check_type);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nud_numberPage);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 159);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "출력 옵션";
            // 
            // check_type
            // 
            this.check_type.AutoSize = true;
            this.check_type.Location = new System.Drawing.Point(37, 97);
            this.check_type.Name = "check_type";
            this.check_type.Size = new System.Drawing.Size(149, 26);
            this.check_type.TabIndex = 11;
            this.check_type.Text = "with Barcode";
            this.check_type.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "인쇄 수:";
            // 
            // nud_numberPage
            // 
            this.nud_numberPage.Location = new System.Drawing.Point(128, 50);
            this.nud_numberPage.Name = "nud_numberPage";
            this.nud_numberPage.Size = new System.Drawing.Size(148, 30);
            this.nud_numberPage.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_model);
            this.groupBox3.Controls.Add(this.lb_converted);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nud_year);
            this.groupBox3.Controls.Add(this.tb_serial);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "출력";
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(303, 45);
            this.tb_model.MaxLength = 3;
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(112, 30);
            this.tb_model.TabIndex = 5;
            this.tb_model.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_model_KeyUp);
            // 
            // lb_converted
            // 
            this.lb_converted.AutoSize = true;
            this.lb_converted.Location = new System.Drawing.Point(282, 99);
            this.lb_converted.Name = "lb_converted";
            this.lb_converted.Size = new System.Drawing.Size(130, 22);
            this.lb_converted.TabIndex = 4;
            this.lb_converted.Text = "ABCD00000EFG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "출력 문자 :";
            // 
            // nud_year
            // 
            this.nud_year.Location = new System.Drawing.Point(26, 45);
            this.nud_year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_year.Name = "nud_year";
            this.nud_year.Size = new System.Drawing.Size(82, 30);
            this.nud_year.TabIndex = 2;
            this.nud_year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_year.ValueChanged += new System.EventHandler(this.nud_year_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_config);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "용지 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(15, 320);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(439, 76);
            this.btn_config.TabIndex = 6;
            this.btn_config.Text = "설정 적용";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_concentration);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nud_gap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "간격 및 농도(mm)";
            // 
            // nud_concentration
            // 
            this.nud_concentration.Location = new System.Drawing.Point(237, 51);
            this.nud_concentration.Name = "nud_concentration";
            this.nud_concentration.Size = new System.Drawing.Size(85, 30);
            this.nud_concentration.TabIndex = 4;
            this.nud_concentration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_concentration_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "농도:";
            // 
            // nud_gap
            // 
            this.nud_gap.DecimalPlaces = 1;
            this.nud_gap.Location = new System.Drawing.Point(80, 51);
            this.nud_gap.Name = "nud_gap";
            this.nud_gap.Size = new System.Drawing.Size(85, 30);
            this.nud_gap.TabIndex = 0;
            this.nud_gap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_gap_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "간격:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_height);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_width);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "용지 크기(mm)";
            // 
            // nud_height
            // 
            this.nud_height.DecimalPlaces = 1;
            this.nud_height.Location = new System.Drawing.Point(237, 63);
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(85, 30);
            this.nud_height.TabIndex = 4;
            this.nud_height.Tag = "";
            this.nud_height.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_height_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "높이:";
            // 
            // nud_width
            // 
            this.nud_width.DecimalPlaces = 1;
            this.nud_width.Location = new System.Drawing.Point(80, 63);
            this.nud_width.Name = "nud_width";
            this.nud_width.Size = new System.Drawing.Size(85, 30);
            this.nud_width.TabIndex = 0;
            this.nud_width.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_width_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "너비:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 488);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Form1";
            this.Text = "TSC Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numberPage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_concentration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_concentration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_gap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_numberPage;
        private System.Windows.Forms.CheckBox check_type;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label lb_converted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_year;
    }
}

