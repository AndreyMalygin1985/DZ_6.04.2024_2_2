namespace DZ_6._04._2024_2_2
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
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            calculateButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarFont = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startDatePicker.Cursor = Cursors.AppStarting;
            startDatePicker.Dock = DockStyle.Left;
            startDatePicker.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startDatePicker.Location = new Point(0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(460, 63);
            startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarFont = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endDatePicker.Cursor = Cursors.AppStarting;
            endDatePicker.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endDatePicker.Location = new Point(0, 69);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(460, 63);
            endDatePicker.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.AutoSize = true;
            calculateButton.BackColor = SystemColors.ButtonShadow;
            calculateButton.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            calculateButton.Location = new Point(0, 204);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(574, 52);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Колличество дней между датами";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultLabel.ForeColor = Color.DarkBlue;
            resultLabel.Location = new Point(0, 150);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(114, 27);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 294);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Button calculateButton;
        private Label resultLabel;
    }
}
