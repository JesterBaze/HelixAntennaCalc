namespace Helix_Antenna_Calc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.textBoxTurns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPipeDiameter = new System.Windows.Forms.TextBox();
            this.textBoxPipeLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRplate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTrapL = new System.Windows.Forms.TextBox();
            this.textBoxFeedDist = new System.Windows.Forms.TextBox();
            this.textBoxTrapW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCrossWtrapW = new System.Windows.Forms.TextBox();
            this.textBoxCrossFeedpointDist = new System.Windows.Forms.TextBox();
            this.textBoxCrossWtrapL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCrossRplate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxCrossL = new System.Windows.Forms.TextBox();
            this.textBoxCrossD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCrossCoilSpace = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxPVCCoilSpace = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 178);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(105, 23);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency (Mhz):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of turns:";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(17, 111);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrequency.TabIndex = 3;
            // 
            // textBoxTurns
            // 
            this.textBoxTurns.Location = new System.Drawing.Point(17, 152);
            this.textBoxTurns.Name = "textBoxTurns";
            this.textBoxTurns.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurns.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PVC Tube Measurements:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pipe diameter:";
            // 
            // textBoxPipeDiameter
            // 
            this.textBoxPipeDiameter.Location = new System.Drawing.Point(146, 70);
            this.textBoxPipeDiameter.Name = "textBoxPipeDiameter";
            this.textBoxPipeDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPipeDiameter.TabIndex = 8;
            // 
            // textBoxPipeLength
            // 
            this.textBoxPipeLength.Location = new System.Drawing.Point(146, 111);
            this.textBoxPipeLength.Name = "textBoxPipeLength";
            this.textBoxPipeLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxPipeLength.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pipe Length:";
            // 
            // textBoxRplate
            // 
            this.textBoxRplate.Location = new System.Drawing.Point(146, 194);
            this.textBoxRplate.Name = "textBoxRplate";
            this.textBoxRplate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRplate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reflector Plate Size (Square Plate):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wave trap width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Wave trap length:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Dist. from feed point:";
            // 
            // textBoxTrapL
            // 
            this.textBoxTrapL.Location = new System.Drawing.Point(146, 233);
            this.textBoxTrapL.Name = "textBoxTrapL";
            this.textBoxTrapL.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapL.TabIndex = 19;
            // 
            // textBoxFeedDist
            // 
            this.textBoxFeedDist.Location = new System.Drawing.Point(146, 311);
            this.textBoxFeedDist.Name = "textBoxFeedDist";
            this.textBoxFeedDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeedDist.TabIndex = 21;
            // 
            // textBoxTrapW
            // 
            this.textBoxTrapW.Location = new System.Drawing.Point(146, 272);
            this.textBoxTrapW.Name = "textBoxTrapW";
            this.textBoxTrapW.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapW.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "All measurements are in inches";
            // 
            // textBoxCrossWtrapW
            // 
            this.textBoxCrossWtrapW.Location = new System.Drawing.Point(342, 272);
            this.textBoxCrossWtrapW.Name = "textBoxCrossWtrapW";
            this.textBoxCrossWtrapW.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossWtrapW.TabIndex = 36;
            // 
            // textBoxCrossFeedpointDist
            // 
            this.textBoxCrossFeedpointDist.Location = new System.Drawing.Point(342, 311);
            this.textBoxCrossFeedpointDist.Name = "textBoxCrossFeedpointDist";
            this.textBoxCrossFeedpointDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossFeedpointDist.TabIndex = 35;
            // 
            // textBoxCrossWtrapL
            // 
            this.textBoxCrossWtrapL.Location = new System.Drawing.Point(342, 233);
            this.textBoxCrossWtrapL.Name = "textBoxCrossWtrapL";
            this.textBoxCrossWtrapL.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossWtrapL.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Dist. from feed point:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Wave trap length:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Wave trap width:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Reflector Plate Size (Square Plate):";
            // 
            // textBoxCrossRplate
            // 
            this.textBoxCrossRplate.Location = new System.Drawing.Point(342, 194);
            this.textBoxCrossRplate.Name = "textBoxCrossRplate";
            this.textBoxCrossRplate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossRplate.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Cross Length:";
            // 
            // textBoxCrossL
            // 
            this.textBoxCrossL.Location = new System.Drawing.Point(342, 111);
            this.textBoxCrossL.Name = "textBoxCrossL";
            this.textBoxCrossL.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossL.TabIndex = 27;
            // 
            // textBoxCrossD
            // 
            this.textBoxCrossD.Location = new System.Drawing.Point(342, 70);
            this.textBoxCrossD.Name = "textBoxCrossD";
            this.textBoxCrossD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossD.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Cross diameter:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(339, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Coil Spacing:";
            // 
            // textBoxCrossCoilSpace
            // 
            this.textBoxCrossCoilSpace.Location = new System.Drawing.Point(342, 152);
            this.textBoxCrossCoilSpace.Name = "textBoxCrossCoilSpace";
            this.textBoxCrossCoilSpace.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossCoilSpace.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(143, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Coil Spacing:";
            // 
            // textBoxPVCCoilSpace
            // 
            this.textBoxPVCCoilSpace.Location = new System.Drawing.Point(146, 152);
            this.textBoxPVCCoilSpace.Name = "textBoxPVCCoilSpace";
            this.textBoxPVCCoilSpace.Size = new System.Drawing.Size(100, 20);
            this.textBoxPVCCoilSpace.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(339, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Insulated Cross Measurements:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(530, 350);
            this.shapeContainer1.TabIndex = 42;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(4, 83);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(120, 129);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 326;
            this.lineShape1.X2 = 326;
            this.lineShape1.Y1 = 12;
            this.lineShape1.Y2 = 331;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(339, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "All measurements are in inches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxCrossCoilSpace);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxPVCCoilSpace);
            this.Controls.Add(this.textBoxCrossWtrapW);
            this.Controls.Add(this.textBoxCrossFeedpointDist);
            this.Controls.Add(this.textBoxCrossWtrapL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxCrossRplate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxCrossL);
            this.Controls.Add(this.textBoxCrossD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTrapW);
            this.Controls.Add(this.textBoxFeedDist);
            this.Controls.Add(this.textBoxTrapL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRplate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPipeLength);
            this.Controls.Add(this.textBoxPipeDiameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTurns);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Helix Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.TextBox textBoxTurns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPipeDiameter;
        private System.Windows.Forms.TextBox textBoxPipeLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTrapL;
        private System.Windows.Forms.TextBox textBoxFeedDist;
        private System.Windows.Forms.TextBox textBoxTrapW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCrossWtrapW;
        private System.Windows.Forms.TextBox textBoxCrossFeedpointDist;
        private System.Windows.Forms.TextBox textBoxCrossWtrapL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCrossRplate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxCrossL;
        private System.Windows.Forms.TextBox textBoxCrossD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCrossCoilSpace;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxPVCCoilSpace;
        private System.Windows.Forms.Label label19;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label20;
    }
}

