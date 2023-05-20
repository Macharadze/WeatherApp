namespace WheatherApp
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
            TBCity = new TextBox();
            btnSearch = new Button();
            labCordition = new Label();
            labDetails = new Label();
            label3 = new Label();
            labSunrise = new Label();
            label4 = new Label();
            labSunSet = new Label();
            labPressire = new Label();
            label5 = new Label();
            labSpeed = new Label();
            label7 = new Label();
            picBox = new PictureBox();
            time = new Label();
            sec = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 76);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 0;
            label1.Text = "City:";
            // 
            // TBCity
            // 
            TBCity.Location = new Point(249, 78);
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(230, 25);
            TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.RosyBrown;
            btnSearch.Location = new Point(506, 73);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // labCordition
            // 
            labCordition.AutoSize = true;
            labCordition.BackColor = Color.Transparent;
            labCordition.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labCordition.ForeColor = Color.Gainsboro;
            labCordition.Location = new Point(185, 242);
            labCordition.Name = "labCordition";
            labCordition.Size = new Size(85, 23);
            labCordition.TabIndex = 3;
            labCordition.Text = "Condition";
            // 
            // labDetails
            // 
            labDetails.AutoSize = true;
            labDetails.BackColor = Color.Transparent;
            labDetails.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labDetails.ForeColor = Color.Gainsboro;
            labDetails.Location = new Point(190, 287);
            labDetails.Name = "labDetails";
            labDetails.Size = new Size(62, 23);
            labDetails.TabIndex = 4;
            labDetails.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(139, 354);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 5;
            label3.Text = "Temperature:";
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunrise.ForeColor = Color.Gainsboro;
            labSunrise.Location = new Point(282, 354);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(39, 23);
            labSunrise.TabIndex = 6;
            labSunrise.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(176, 398);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 7;
            label4.Text = "Feels like:";
            // 
            // labSunSet
            // 
            labSunSet.AutoSize = true;
            labSunSet.BackColor = Color.Transparent;
            labSunSet.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSet.ForeColor = Color.Gainsboro;
            labSunSet.Location = new Point(282, 398);
            labSunSet.Name = "labSunSet";
            labSunSet.Size = new Size(39, 23);
            labSunSet.TabIndex = 8;
            labSunSet.Text = "N/A";
            // 
            // labPressire
            // 
            labPressire.AutoSize = true;
            labPressire.BackColor = Color.Transparent;
            labPressire.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labPressire.ForeColor = Color.Gainsboro;
            labPressire.Location = new Point(603, 294);
            labPressire.Name = "labPressire";
            labPressire.Size = new Size(39, 23);
            labPressire.TabIndex = 12;
            labPressire.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(482, 294);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 11;
            label5.Text = "Pressure:";
            // 
            // labSpeed
            // 
            labSpeed.AutoSize = true;
            labSpeed.BackColor = Color.Transparent;
            labSpeed.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSpeed.ForeColor = Color.Gainsboro;
            labSpeed.Location = new Point(603, 242);
            labSpeed.Name = "labSpeed";
            labSpeed.Size = new Size(39, 23);
            labSpeed.TabIndex = 10;
            labSpeed.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(451, 242);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 9;
            label7.Text = "Wind Speed:";
            // 
            // picBox
            // 
            picBox.BackColor = Color.Transparent;
            picBox.Location = new Point(206, 147);
            picBox.Name = "picBox";
            picBox.Size = new Size(92, 60);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.TabIndex = 13;
            picBox.TabStop = false;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            time.ForeColor = Color.White;
            time.Location = new Point(743, 22);
            time.Name = "time";
            time.Size = new Size(85, 37);
            time.TabIndex = 14;
            time.Text = "22:22";
            time.Click += time_Click;
            // 
            // sec
            // 
            sec.AutoSize = true;
            sec.BackColor = Color.Transparent;
            sec.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sec.ForeColor = Color.White;
            sec.Location = new Point(845, 34);
            sec.Name = "sec";
            sec.Size = new Size(30, 23);
            sec.TabIndex = 15;
            sec.Text = "05";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 609);
            Controls.Add(sec);
            Controls.Add(time);
            Controls.Add(picBox);
            Controls.Add(labPressire);
            Controls.Add(label5);
            Controls.Add(labSpeed);
            Controls.Add(label7);
            Controls.Add(labSunSet);
            Controls.Add(label4);
            Controls.Add(labSunrise);
            Controls.Add(label3);
            Controls.Add(labDetails);
            Controls.Add(labCordition);
            Controls.Add(btnSearch);
            Controls.Add(TBCity);
            Controls.Add(label1);
            Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBCity;
        private Button btnSearch;
        private Label labCordition;
        private Label labDetails;
        private Label label3;
        private Label labSunrise;
        private Label label4;
        private Label labSunSet;
        private Label labPressire;
        private Label label5;
        private Label labSpeed;
        private Label label7;
        private PictureBox picBox;
        private Label time;
        private Label sec;
    }
}