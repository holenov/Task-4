namespace WinFormsApp1
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
            ProfessionBox = new TextBox();
            ResultBox = new TextBox();
            NameBox = new TextBox();
            AgeBox = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            StartButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProfessionBox
            // 
            ProfessionBox.Location = new Point(102, 96);
            ProfessionBox.Name = "ProfessionBox";
            ProfessionBox.Size = new Size(240, 27);
            ProfessionBox.TabIndex = 0;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(375, 12);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(239, 172);
            ResultBox.TabIndex = 1;
            ResultBox.TextChanged += textBox2_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(102, 31);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(240, 27);
            NameBox.TabIndex = 2;
            NameBox.TextChanged += textBox3_TextChanged;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(102, 66);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(240, 27);
            AgeBox.TabIndex = 3;
            AgeBox.TextChanged += textBox4_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(AgeBox);
            groupBox1.Controls.Add(ProfessionBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 135);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Профессия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 7;
            label2.Text = "Возраст";
            label2.Click += label2_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 148);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(357, 36);
            StartButton.TabIndex = 5;
            StartButton.Text = "Добавить";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 192);
            Controls.Add(StartButton);
            Controls.Add(groupBox1);
            Controls.Add(ResultBox);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProfessionBox;
        private TextBox ResultBox;
        private TextBox NameBox;
        private TextBox AgeBox;
        private GroupBox groupBox1;
        private Button StartButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
