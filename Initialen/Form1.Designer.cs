namespace Initialen
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
            label2 = new Label();
            VoornaamNaamTextBox = new TextBox();
            VoornaamTextBox = new TextBox();
            SamenButton = new Button();
            label3 = new Label();
            ApartButton = new Button();
            InitialenSamenLabel = new Label();
            InitialenApartLabel = new Label();
            NaamTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 30);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "                  Naam                  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Maroon;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 1;
            label2.Text = "              Voornaam              ";
            // 
            // VoornaamNaamTextBox
            // 
            VoornaamNaamTextBox.Location = new Point(12, 92);
            VoornaamNaamTextBox.Name = "VoornaamNaamTextBox";
            VoornaamNaamTextBox.Size = new Size(299, 23);
            VoornaamNaamTextBox.TabIndex = 2;
            // 
            // VoornaamTextBox
            // 
            VoornaamTextBox.Location = new Point(12, 48);
            VoornaamTextBox.Name = "VoornaamTextBox";
            VoornaamTextBox.Size = new Size(145, 23);
            VoornaamTextBox.TabIndex = 3;
            // 
            // SamenButton
            // 
            SamenButton.Location = new Point(317, 74);
            SamenButton.Name = "SamenButton";
            SamenButton.Size = new Size(84, 41);
            SamenButton.TabIndex = 4;
            SamenButton.Text = "Initialen";
            SamenButton.UseVisualStyleBackColor = true;
            SamenButton.Click += SamenButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(299, 15);
            label3.TabIndex = 5;
            label3.Text = "                                Voornaam + Naam                                ";
            // 
            // ApartButton
            // 
            ApartButton.Location = new Point(317, 30);
            ApartButton.Name = "ApartButton";
            ApartButton.Size = new Size(84, 41);
            ApartButton.TabIndex = 6;
            ApartButton.Text = "Initialen";
            ApartButton.UseVisualStyleBackColor = true;
            ApartButton.Click += ApartButton_Click;
            // 
            // InitialenSamenLabel
            // 
            InitialenSamenLabel.AutoSize = true;
            InitialenSamenLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            InitialenSamenLabel.ForeColor = Color.Maroon;
            InitialenSamenLabel.Location = new Point(407, 74);
            InitialenSamenLabel.Name = "InitialenSamenLabel";
            InitialenSamenLabel.Size = new Size(62, 36);
            InitialenSamenLabel.TabIndex = 7;
            InitialenSamenLabel.Text = "_ _ _";
            // 
            // InitialenApartLabel
            // 
            InitialenApartLabel.AutoSize = true;
            InitialenApartLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            InitialenApartLabel.ForeColor = Color.DarkRed;
            InitialenApartLabel.Location = new Point(407, 30);
            InitialenApartLabel.Name = "InitialenApartLabel";
            InitialenApartLabel.Size = new Size(62, 36);
            InitialenApartLabel.TabIndex = 8;
            InitialenApartLabel.Text = "_ _ _";
            // 
            // NaamTextBox
            // 
            NaamTextBox.Location = new Point(164, 48);
            NaamTextBox.Name = "NaamTextBox";
            NaamTextBox.Size = new Size(147, 23);
            NaamTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 135);
            Controls.Add(NaamTextBox);
            Controls.Add(InitialenApartLabel);
            Controls.Add(InitialenSamenLabel);
            Controls.Add(ApartButton);
            Controls.Add(label3);
            Controls.Add(SamenButton);
            Controls.Add(VoornaamTextBox);
            Controls.Add(VoornaamNaamTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox VoornaamNaamTextBox;
        private TextBox VoornaamTextBox;
        private Button SamenButton;
        private Label label3;
        private Button ApartButton;
        private Label InitialenSamenLabel;
        private Label InitialenApartLabel;
        private TextBox NaamTextBox;
    }
}
