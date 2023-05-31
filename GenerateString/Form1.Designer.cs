
namespace GenerateString
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Prefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NumberCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox_PathFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_PathFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_Prefix = new System.Windows.Forms.CheckBox();
            this.checkBox_NotContain_I1 = new System.Windows.Forms.CheckBox();
            this.checkBox_NotContain_O0 = new System.Windows.Forms.CheckBox();
            this.checkBox_Char = new System.Windows.Forms.CheckBox();
            this.checkBox_Number = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.checkBox_Excel = new System.Windows.Forms.CheckBox();
            this.checkBox_Txt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_QRCode = new System.Windows.Forms.TextBox();
            this.checkBox_QRCode = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton_NotContinue = new System.Windows.Forms.RadioButton();
            this.radioButton_Continue = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Serial = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(321, 566);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 0;
            this.button_Generate.Text = "Tạo mã";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền tố của mã cào (1)";
            // 
            // textBox_Prefix
            // 
            this.textBox_Prefix.Location = new System.Drawing.Point(30, 53);
            this.textBox_Prefix.Name = "textBox_Prefix";
            this.textBox_Prefix.PlaceholderText = "Ký tự trước mã cào, cách nhau bằng dấu phẩy (,)";
            this.textBox_Prefix.Size = new System.Drawing.Size(279, 23);
            this.textBox_Prefix.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số ký tự của chuỗi (2). Không bao gồm tiền tố (nếu có)";
            // 
            // textBox_NumberCode
            // 
            this.textBox_NumberCode.Location = new System.Drawing.Point(423, 113);
            this.textBox_NumberCode.Name = "textBox_NumberCode";
            this.textBox_NumberCode.Size = new System.Drawing.Size(147, 23);
            this.textBox_NumberCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng mã cào (4)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(423, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(147, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBox_PathFolder
            // 
            this.textBox_PathFolder.Location = new System.Drawing.Point(30, 113);
            this.textBox_PathFolder.Name = "textBox_PathFolder";
            this.textBox_PathFolder.PlaceholderText = "Thư mục chứa mã cào cũ, dùng để check trùng";
            this.textBox_PathFolder.Size = new System.Drawing.Size(279, 23);
            this.textBox_PathFolder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thư mục chứa mã cũ (3)";
            // 
            // button_PathFolder
            // 
            this.button_PathFolder.Location = new System.Drawing.Point(321, 113);
            this.button_PathFolder.Name = "button_PathFolder";
            this.button_PathFolder.Size = new System.Drawing.Size(31, 23);
            this.button_PathFolder.TabIndex = 11;
            this.button_PathFolder.Text = "...";
            this.button_PathFolder.UseVisualStyleBackColor = true;
            this.button_PathFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBox_Prefix);
            this.groupBox1.Controls.Add(this.checkBox_NotContain_I1);
            this.groupBox1.Controls.Add(this.checkBox_NotContain_O0);
            this.groupBox1.Controls.Add(this.checkBox_Char);
            this.groupBox1.Controls.Add(this.checkBox_Number);
            this.groupBox1.Location = new System.Drawing.Point(30, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 249);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy tắc tạo mã (5)";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(179, 224);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(87, 19);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ngẫu nhiên";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(104, 224);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 19);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Cuối";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 224);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 19);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Đầu";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sắp xếp chữ cái trong mã cào";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(18, 161);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số lượng chữ cái trong mã cào";
            // 
            // checkBox_Prefix
            // 
            this.checkBox_Prefix.AutoSize = true;
            this.checkBox_Prefix.Location = new System.Drawing.Point(18, 102);
            this.checkBox_Prefix.Name = "checkBox_Prefix";
            this.checkBox_Prefix.Size = new System.Drawing.Size(205, 19);
            this.checkBox_Prefix.TabIndex = 20;
            this.checkBox_Prefix.Text = "Mã cào có gồm tiền tố (1) không?";
            this.checkBox_Prefix.UseVisualStyleBackColor = true;
            // 
            // checkBox_NotContain_I1
            // 
            this.checkBox_NotContain_I1.AutoSize = true;
            this.checkBox_NotContain_I1.Checked = true;
            this.checkBox_NotContain_I1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NotContain_I1.Location = new System.Drawing.Point(116, 60);
            this.checkBox_NotContain_I1.Name = "checkBox_NotContain_I1";
            this.checkBox_NotContain_I1.Size = new System.Drawing.Size(133, 19);
            this.checkBox_NotContain_I1.TabIndex = 3;
            this.checkBox_NotContain_I1.Text = "Không bao gồm  I, 1";
            this.checkBox_NotContain_I1.UseVisualStyleBackColor = true;
            // 
            // checkBox_NotContain_O0
            // 
            this.checkBox_NotContain_O0.AutoSize = true;
            this.checkBox_NotContain_O0.Checked = true;
            this.checkBox_NotContain_O0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NotContain_O0.Location = new System.Drawing.Point(117, 23);
            this.checkBox_NotContain_O0.Name = "checkBox_NotContain_O0";
            this.checkBox_NotContain_O0.Size = new System.Drawing.Size(154, 19);
            this.checkBox_NotContain_O0.TabIndex = 2;
            this.checkBox_NotContain_O0.Text = "Không bao gồm O0QUV";
            this.checkBox_NotContain_O0.UseVisualStyleBackColor = true;
            // 
            // checkBox_Char
            // 
            this.checkBox_Char.AutoSize = true;
            this.checkBox_Char.Checked = true;
            this.checkBox_Char.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Char.Location = new System.Drawing.Point(18, 60);
            this.checkBox_Char.Name = "checkBox_Char";
            this.checkBox_Char.Size = new System.Drawing.Size(66, 19);
            this.checkBox_Char.TabIndex = 1;
            this.checkBox_Char.Text = "Chữ cái";
            this.checkBox_Char.UseVisualStyleBackColor = true;
            // 
            // checkBox_Number
            // 
            this.checkBox_Number.AutoSize = true;
            this.checkBox_Number.Checked = true;
            this.checkBox_Number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Number.Location = new System.Drawing.Point(18, 23);
            this.checkBox_Number.Name = "checkBox_Number";
            this.checkBox_Number.Size = new System.Drawing.Size(69, 19);
            this.checkBox_Number.TabIndex = 0;
            this.checkBox_Number.Text = "Chứa số";
            this.checkBox_Number.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_FileName);
            this.groupBox2.Controls.Add(this.checkBox_Excel);
            this.groupBox2.Controls.Add(this.checkBox_Txt);
            this.groupBox2.Location = new System.Drawing.Point(409, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 116);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy tắc tạo file (8)";
            this.groupBox2.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tên file";
            this.label8.UseWaitCursor = true;
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(117, 71);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(222, 23);
            this.textBox_FileName.TabIndex = 20;
            this.textBox_FileName.UseWaitCursor = true;
            // 
            // checkBox_Excel
            // 
            this.checkBox_Excel.AutoSize = true;
            this.checkBox_Excel.Checked = true;
            this.checkBox_Excel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Excel.Location = new System.Drawing.Point(18, 75);
            this.checkBox_Excel.Name = "checkBox_Excel";
            this.checkBox_Excel.Size = new System.Drawing.Size(74, 19);
            this.checkBox_Excel.TabIndex = 1;
            this.checkBox_Excel.Text = "File excel";
            this.checkBox_Excel.UseVisualStyleBackColor = true;
            this.checkBox_Excel.UseWaitCursor = true;
            // 
            // checkBox_Txt
            // 
            this.checkBox_Txt.AutoSize = true;
            this.checkBox_Txt.Checked = true;
            this.checkBox_Txt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Txt.Location = new System.Drawing.Point(18, 31);
            this.checkBox_Txt.Name = "checkBox_Txt";
            this.checkBox_Txt.Size = new System.Drawing.Size(64, 19);
            this.checkBox_Txt.TabIndex = 0;
            this.checkBox_Txt.Text = "File .txt";
            this.checkBox_Txt.UseVisualStyleBackColor = true;
            this.checkBox_Txt.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Link QR";
            this.label5.UseWaitCursor = true;
            // 
            // textBox_QRCode
            // 
            this.textBox_QRCode.Location = new System.Drawing.Point(6, 88);
            this.textBox_QRCode.Name = "textBox_QRCode";
            this.textBox_QRCode.PlaceholderText = "Link QR dùng để kích hoạt, đăng ký";
            this.textBox_QRCode.Size = new System.Drawing.Size(247, 23);
            this.textBox_QRCode.TabIndex = 19;
            this.textBox_QRCode.UseWaitCursor = true;
            // 
            // checkBox_QRCode
            // 
            this.checkBox_QRCode.AutoSize = true;
            this.checkBox_QRCode.Location = new System.Drawing.Point(6, 30);
            this.checkBox_QRCode.Name = "checkBox_QRCode";
            this.checkBox_QRCode.Size = new System.Drawing.Size(89, 19);
            this.checkBox_QRCode.TabIndex = 3;
            this.checkBox_QRCode.Text = "Tạo Link QR";
            this.checkBox_QRCode.UseVisualStyleBackColor = true;
            this.checkBox_QRCode.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.radioButton_NotContinue);
            this.groupBox3.Controls.Add(this.radioButton_Continue);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_Serial);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Location = new System.Drawing.Point(409, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 243);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quy tắc tạo Serial (6)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Serial giữa các cụm mã có liên tiếp không?";
            // 
            // radioButton_NotContinue
            // 
            this.radioButton_NotContinue.AutoSize = true;
            this.radioButton_NotContinue.Checked = true;
            this.radioButton_NotContinue.Location = new System.Drawing.Point(14, 218);
            this.radioButton_NotContinue.Name = "radioButton_NotContinue";
            this.radioButton_NotContinue.Size = new System.Drawing.Size(105, 19);
            this.radioButton_NotContinue.TabIndex = 25;
            this.radioButton_NotContinue.TabStop = true;
            this.radioButton_NotContinue.Text = "Không liên tiếp";
            this.radioButton_NotContinue.UseVisualStyleBackColor = true;
            // 
            // radioButton_Continue
            // 
            this.radioButton_Continue.AutoSize = true;
            this.radioButton_Continue.Location = new System.Drawing.Point(219, 218);
            this.radioButton_Continue.Name = "radioButton_Continue";
            this.radioButton_Continue.Size = new System.Drawing.Size(73, 19);
            this.radioButton_Continue.TabIndex = 24;
            this.radioButton_Continue.Text = "Liên tiếp ";
            this.radioButton_Continue.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Số serial bắt đầu từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số ký tự của Serial";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(219, 27);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tiền tố của Serial:";
            // 
            // textBox_Serial
            // 
            this.textBox_Serial.Location = new System.Drawing.Point(14, 74);
            this.textBox_Serial.Name = "textBox_Serial";
            this.textBox_Serial.PlaceholderText = "Ký tự trước Serial";
            this.textBox_Serial.Size = new System.Drawing.Size(147, 23);
            this.textBox_Serial.TabIndex = 20;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(14, 22);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Tạo Serial";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_QRCode);
            this.groupBox4.Controls.Add(this.textBox_QRCode);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(30, 444);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 116);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quy tắc tạo QR (7)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_PathFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PathFolder);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NumberCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Prefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Generate);
            this.Name = "Form1";
            this.Text = "Chương trình tạo mã cào";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Prefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NumberCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_PathFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_PathFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_NotContain_O0;
        private System.Windows.Forms.CheckBox checkBox_Char;
        private System.Windows.Forms.CheckBox checkBox_Number;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_Excel;
        private System.Windows.Forms.CheckBox checkBox_Txt;
        private System.Windows.Forms.CheckBox checkBox_NotContain_I1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_QRCode;
        private System.Windows.Forms.CheckBox checkBox_QRCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Serial;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.CheckBox checkBox_Prefix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.RadioButton radioButton_Continue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton_NotContinue;
    }
}

