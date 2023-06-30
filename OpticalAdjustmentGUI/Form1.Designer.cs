namespace OpticalAdjustmentGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnApply = new Button();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            btnEnableToggle = new Button();
            btnSave = new Button();
            checkBox2 = new CheckBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Current Value";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(303, 5);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(86, 25);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numericUpDown1.Location = new Point(211, 8);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(395, 8);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Auto Apply";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnEnableToggle
            // 
            btnEnableToggle.Location = new Point(12, 7);
            btnEnableToggle.Name = "btnEnableToggle";
            btnEnableToggle.Size = new Size(109, 47);
            btnEnableToggle.TabIndex = 5;
            btnEnableToggle.Text = "Activate";
            btnEnableToggle.UseVisualStyleBackColor = true;
            btnEnableToggle.Click += btnEnableToggle_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(303, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 25);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(395, 38);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Auto Save";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 465);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 536);
            button1.Name = "button1";
            button1.Size = new Size(462, 36);
            button1.TabIndex = 10;
            button1.Text = "Share results with Varjo...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(486, 581);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox2);
            Controls.Add(btnSave);
            Controls.Add(btnEnableToggle);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnApply);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "OpticalAdjustmentGUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnApply;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private Button btnEnableToggle;
        private Button btnSave;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}