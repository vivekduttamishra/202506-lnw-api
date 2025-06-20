namespace CalculatorDesktop
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
            label1 = new Label();
            number1TextBox = new TextBox();
            label2 = new Label();
            number2TextBox = new TextBox();
            label3 = new Label();
            computeButton = new Button();
            label4 = new Label();
            resultLabel = new Label();
            operationList = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 77);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 0;
            label1.Text = "Number &1";
            label1.Click += label1_Click;
            // 
            // number1TextBox
            // 
            number1TextBox.Location = new Point(321, 74);
            number1TextBox.Name = "number1TextBox";
            number1TextBox.Size = new Size(250, 47);
            number1TextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 184);
            label2.Name = "label2";
            label2.Size = new Size(152, 41);
            label2.TabIndex = 2;
            label2.Text = "&Operation";
            // 
            // number2TextBox
            // 
            number2TextBox.Location = new Point(321, 284);
            number2TextBox.Name = "number2TextBox";
            number2TextBox.Size = new Size(250, 47);
            number2TextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 287);
            label3.Name = "label3";
            label3.Size = new Size(151, 41);
            label3.TabIndex = 4;
            label3.Text = "Number &2";
            // 
            // computeButton
            // 
            computeButton.Location = new Point(127, 392);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(444, 58);
            computeButton.TabIndex = 6;
            computeButton.Text = "Compute";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 539);
            label4.Name = "label4";
            label4.Size = new Size(98, 41);
            label4.TabIndex = 7;
            label4.Text = "Result";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            resultLabel.Location = new Point(321, 511);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(77, 89);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "0";
            // 
            // operationList
            // 
            operationList.FormattingEnabled = true;
            operationList.Location = new Point(322, 184);
            operationList.Name = "operationList";
            operationList.Size = new Size(302, 49);
            operationList.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 651);
            Controls.Add(operationList);
            Controls.Add(resultLabel);
            Controls.Add(label4);
            Controls.Add(computeButton);
            Controls.Add(number2TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(number1TextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox number1TextBox;
        private Label label2;
        private TextBox number2TextBox;
        private Label label3;
        private Button computeButton;
        private Label label4;
        private Label resultLabel;
        private ComboBox operationList;
    }
}
