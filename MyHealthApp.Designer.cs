namespace MyHealth
{
    partial class MyHealthApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHealthApp));
            InputValuesGroupBox = new GroupBox();
            UpPressureValueInput = new NumericUpDown();
            UpPressureLabel = new Label();
            HeartRateValueInput = new NumericUpDown();
            HeartRateLabel = new Label();
            LowPressureValueInput = new NumericUpDown();
            LowPressureLabel = new Label();
            HealthStateGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ViewHealthBookButton = new Button();
            ChangeUserButton = new Button();
            WriteValuesButton = new Button();
            StatusBar = new StatusStrip();
            StatusBarLabel = new ToolStripStatusLabel();
            InputValuesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpPressureValueInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeartRateValueInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LowPressureValueInput).BeginInit();
            HealthStateGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            StatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // InputValuesGroupBox
            // 
            InputValuesGroupBox.Controls.Add(UpPressureValueInput);
            InputValuesGroupBox.Controls.Add(UpPressureLabel);
            InputValuesGroupBox.Controls.Add(HeartRateValueInput);
            InputValuesGroupBox.Controls.Add(HeartRateLabel);
            InputValuesGroupBox.Controls.Add(LowPressureValueInput);
            InputValuesGroupBox.Controls.Add(LowPressureLabel);
            InputValuesGroupBox.Location = new Point(12, 12);
            InputValuesGroupBox.Name = "InputValuesGroupBox";
            InputValuesGroupBox.Size = new Size(141, 158);
            InputValuesGroupBox.TabIndex = 0;
            InputValuesGroupBox.TabStop = false;
            InputValuesGroupBox.Text = "Значения тонометра";
            // 
            // UpPressureValueInput
            // 
            UpPressureValueInput.Location = new Point(6, 37);
            UpPressureValueInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            UpPressureValueInput.Name = "UpPressureValueInput";
            UpPressureValueInput.Size = new Size(129, 23);
            UpPressureValueInput.TabIndex = 1;
            // 
            // UpPressureLabel
            // 
            UpPressureLabel.AutoSize = true;
            UpPressureLabel.Location = new Point(6, 19);
            UpPressureLabel.Name = "UpPressureLabel";
            UpPressureLabel.Size = new Size(116, 15);
            UpPressureLabel.TabIndex = 0;
            UpPressureLabel.Text = "Верхнее давление";
            // 
            // HeartRateValueInput
            // 
            HeartRateValueInput.Location = new Point(6, 125);
            HeartRateValueInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            HeartRateValueInput.Name = "HeartRateValueInput";
            HeartRateValueInput.Size = new Size(129, 23);
            HeartRateValueInput.TabIndex = 3;
            // 
            // HeartRateLabel
            // 
            HeartRateLabel.AutoSize = true;
            HeartRateLabel.Location = new Point(6, 107);
            HeartRateLabel.Name = "HeartRateLabel";
            HeartRateLabel.Size = new Size(41, 15);
            HeartRateLabel.TabIndex = 4;
            HeartRateLabel.Text = "Пульс";
            // 
            // LowPressureValueInput
            // 
            LowPressureValueInput.Location = new Point(6, 81);
            LowPressureValueInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            LowPressureValueInput.Name = "LowPressureValueInput";
            LowPressureValueInput.Size = new Size(129, 23);
            LowPressureValueInput.TabIndex = 2;
            // 
            // LowPressureLabel
            // 
            LowPressureLabel.AutoSize = true;
            LowPressureLabel.Location = new Point(6, 63);
            LowPressureLabel.Name = "LowPressureLabel";
            LowPressureLabel.Size = new Size(114, 15);
            LowPressureLabel.TabIndex = 2;
            LowPressureLabel.Text = "Нижнее давление";
            // 
            // HealthStateGroupBox
            // 
            HealthStateGroupBox.Controls.Add(tableLayoutPanel1);
            HealthStateGroupBox.Location = new Point(159, 12);
            HealthStateGroupBox.Name = "HealthStateGroupBox";
            HealthStateGroupBox.Size = new Size(148, 158);
            HealthStateGroupBox.TabIndex = 1;
            HealthStateGroupBox.TabStop = false;
            HealthStateGroupBox.Text = "Общее состояние";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(checkBox5, 0, 4);
            tableLayoutPanel1.Controls.Add(checkBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(136, 129);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox5.Location = new Point(3, 103);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(60, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Муть";
            checkBox5.TextAlign = ContentAlignment.TopCenter;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox4.Location = new Point(3, 78);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(97, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Болит шея";
            checkBox4.TextAlign = ContentAlignment.TopCenter;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(3, 53);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(109, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Болят виски";
            checkBox3.TextAlign = ContentAlignment.TopCenter;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(3, 28);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Болит затылок";
            checkBox2.TextAlign = ContentAlignment.TopCenter;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Болит лоб";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(ViewHealthBookButton, 2, 0);
            tableLayoutPanel2.Controls.Add(ChangeUserButton, 1, 0);
            tableLayoutPanel2.Controls.Add(WriteValuesButton, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 176);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(295, 63);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ViewHealthBookButton
            // 
            ViewHealthBookButton.Image = Properties.Resources.read;
            ViewHealthBookButton.Location = new Point(199, 3);
            ViewHealthBookButton.Name = "ViewHealthBookButton";
            ViewHealthBookButton.Size = new Size(92, 56);
            ViewHealthBookButton.TabIndex = 2;
            ViewHealthBookButton.UseVisualStyleBackColor = true;
            // 
            // ChangeUserButton
            // 
            ChangeUserButton.Image = Properties.Resources.user;
            ChangeUserButton.Location = new Point(101, 3);
            ChangeUserButton.Name = "ChangeUserButton";
            ChangeUserButton.Size = new Size(92, 56);
            ChangeUserButton.TabIndex = 1;
            ChangeUserButton.UseVisualStyleBackColor = true;
            ChangeUserButton.Click += this.ChangeUserButton_Click;
            // 
            // WriteValuesButton
            // 
            WriteValuesButton.Image = Properties.Resources.write;
            WriteValuesButton.Location = new Point(3, 3);
            WriteValuesButton.Name = "WriteValuesButton";
            WriteValuesButton.Size = new Size(92, 56);
            WriteValuesButton.TabIndex = 0;
            WriteValuesButton.UseVisualStyleBackColor = true;
            // 
            // StatusBar
            // 
            StatusBar.Items.AddRange(new ToolStripItem[] { StatusBarLabel });
            StatusBar.Location = new Point(0, 240);
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(318, 22);
            StatusBar.TabIndex = 3;
            StatusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            StatusBarLabel.Name = "StatusBarLabel";
            StatusBarLabel.Size = new Size(0, 17);
            // 
            // MyHealthApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 262);
            Controls.Add(StatusBar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(HealthStateGroupBox);
            Controls.Add(InputValuesGroupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MyHealthApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Журнал здоровья";
            InputValuesGroupBox.ResumeLayout(false);
            InputValuesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpPressureValueInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeartRateValueInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)LowPressureValueInput).EndInit();
            HealthStateGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            StatusBar.ResumeLayout(false);
            StatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox InputValuesGroupBox;
        private Label LowPressureLabel;
        private NumericUpDown UpPressureValueInput;
        private Label UpPressureLabel;
        private NumericUpDown HeartRateValueInput;
        private Label HeartRateLabel;
        private NumericUpDown LowPressureValueInput;
        private GroupBox HealthStateGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ViewHealthBookButton;
        private Button ChangeUserButton;
        private Button WriteValuesButton;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel StatusBarLabel;
    }
}
