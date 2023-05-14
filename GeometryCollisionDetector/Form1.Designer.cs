namespace GeometryCollisionDetector
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
            this.SelectGeometry2 = new System.Windows.Forms.ComboBox();
            this.SelectGeometry1 = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.InputPanel2 = new System.Windows.Forms.Panel();
            this.GeometryPanel1 = new System.Windows.Forms.Panel();
            this.InputPanel1 = new System.Windows.Forms.Panel();
            this.ResultBox1 = new System.Windows.Forms.ListBox();
            this.GeometryPanel2 = new System.Windows.Forms.Panel();
            this.label11231 = new System.Windows.Forms.Label();
            this.label2333 = new System.Windows.Forms.Label();
            this.label14433 = new System.Windows.Forms.Label();
            this.label133578 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectGeometry2
            // 
            this.SelectGeometry2.FormattingEnabled = true;
            this.SelectGeometry2.Location = new System.Drawing.Point(585, 151);
            this.SelectGeometry2.Name = "SelectGeometry2";
            this.SelectGeometry2.Size = new System.Drawing.Size(219, 24);
            this.SelectGeometry2.TabIndex = 0;
            this.SelectGeometry2.SelectedIndexChanged += new System.EventHandler(this.SelectGeometry2_SelectedIndexChanged);
            // 
            // SelectGeometry1
            // 
            this.SelectGeometry1.FormattingEnabled = true;
            this.SelectGeometry1.Items.AddRange(new object[] {
            "Point",
            "Rectangle",
            "Circle",
            "Sphere",
            "RectangularPrism",
            "Cylinder",
            "Surface"});
            this.SelectGeometry1.Location = new System.Drawing.Point(585, 108);
            this.SelectGeometry1.Name = "SelectGeometry1";
            this.SelectGeometry1.Size = new System.Drawing.Size(219, 24);
            this.SelectGeometry1.TabIndex = 1;
            this.SelectGeometry1.SelectedIndexChanged += new System.EventHandler(this.SelectGeometry1_SelectedIndexChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(650, 196);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(89, 42);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Calculate";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InputPanel2
            // 
            this.InputPanel2.BackColor = System.Drawing.Color.White;
            this.InputPanel2.Location = new System.Drawing.Point(288, 269);
            this.InputPanel2.Name = "InputPanel2";
            this.InputPanel2.Size = new System.Drawing.Size(260, 214);
            this.InputPanel2.TabIndex = 0;
            // 
            // GeometryPanel1
            // 
            this.GeometryPanel1.BackColor = System.Drawing.Color.White;
            this.GeometryPanel1.Location = new System.Drawing.Point(12, 27);
            this.GeometryPanel1.Name = "GeometryPanel1";
            this.GeometryPanel1.Size = new System.Drawing.Size(260, 211);
            this.GeometryPanel1.TabIndex = 5;
            this.GeometryPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GeometryPanel1_Paint);
            // 
            // InputPanel1
            // 
            this.InputPanel1.BackColor = System.Drawing.Color.White;
            this.InputPanel1.Location = new System.Drawing.Point(12, 269);
            this.InputPanel1.Name = "InputPanel1";
            this.InputPanel1.Size = new System.Drawing.Size(260, 214);
            this.InputPanel1.TabIndex = 0;
            // 
            // ResultBox1
            // 
            this.ResultBox1.FormattingEnabled = true;
            this.ResultBox1.ItemHeight = 16;
            this.ResultBox1.Location = new System.Drawing.Point(603, 288);
            this.ResultBox1.Name = "ResultBox1";
            this.ResultBox1.Size = new System.Drawing.Size(191, 84);
            this.ResultBox1.TabIndex = 6;
            // 
            // GeometryPanel2
            // 
            this.GeometryPanel2.BackColor = System.Drawing.Color.White;
            this.GeometryPanel2.Location = new System.Drawing.Point(288, 27);
            this.GeometryPanel2.Name = "GeometryPanel2";
            this.GeometryPanel2.Size = new System.Drawing.Size(260, 211);
            this.GeometryPanel2.TabIndex = 7;
            this.GeometryPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.GeometryPanel2_Paint);
            // 
            // label11231
            // 
            this.label11231.AutoSize = true;
            this.label11231.Location = new System.Drawing.Point(600, 269);
            this.label11231.Name = "label11231";
            this.label11231.Size = new System.Drawing.Size(45, 16);
            this.label11231.TabIndex = 8;
            this.label11231.Text = "Result";
            // 
            // label2333
            // 
            this.label2333.AutoSize = true;
            this.label2333.Location = new System.Drawing.Point(248, 8);
            this.label2333.Name = "label2333";
            this.label2333.Size = new System.Drawing.Size(66, 16);
            this.label2333.TabIndex = 0;
            this.label2333.Text = "Geometry";
            // 
            // label14433
            // 
            this.label14433.AutoSize = true;
            this.label14433.Location = new System.Drawing.Point(258, 250);
            this.label14433.Name = "label14433";
            this.label14433.Size = new System.Drawing.Size(49, 16);
            this.label14433.TabIndex = 9;
            this.label14433.Text = "Values";
            // 
            // label133578
            // 
            this.label133578.AutoSize = true;
            this.label133578.Location = new System.Drawing.Point(669, 73);
            this.label133578.Name = "label133578";
            this.label133578.Size = new System.Drawing.Size(54, 16);
            this.label133578.TabIndex = 10;
            this.label133578.Text = "Shapes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 517);
            this.Controls.Add(this.label133578);
            this.Controls.Add(this.label14433);
            this.Controls.Add(this.label2333);
            this.Controls.Add(this.label11231);
            this.Controls.Add(this.GeometryPanel2);
            this.Controls.Add(this.GeometryPanel1);
            this.Controls.Add(this.ResultBox1);
            this.Controls.Add(this.InputPanel1);
            this.Controls.Add(this.InputPanel2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.SelectGeometry1);
            this.Controls.Add(this.SelectGeometry2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectGeometry2;
        private System.Windows.Forms.ComboBox SelectGeometry1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Panel InputPanel2;
        private System.Windows.Forms.Panel GeometryPanel1;
        private System.Windows.Forms.Panel InputPanel1;
        private System.Windows.Forms.ListBox ResultBox1;
        private System.Windows.Forms.Panel GeometryPanel2;
        private System.Windows.Forms.Label label11231;
        private System.Windows.Forms.Label label2333;
        private System.Windows.Forms.Label label14433;
        private System.Windows.Forms.Label label133578;
    }
}

