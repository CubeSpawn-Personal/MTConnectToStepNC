namespace MTConnectStepNCConverter
{
    partial class MainWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.input_button = new System.Windows.Forms.Button();
            this.output_button = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.analyze = new System.Windows.Forms.Button();
            this.input_field = new System.Windows.Forms.TextBox();
            this.output_field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(612, 373);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MTConnect XML|*.xml";
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(12, 12);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(130, 23);
            this.input_button.TabIndex = 1;
            this.input_button.Text = "Select MTConnect File";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.browseForMTConnectFile);
            // 
            // output_button
            // 
            this.output_button.Location = new System.Drawing.Point(12, 48);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(130, 23);
            this.output_button.TabIndex = 2;
            this.output_button.Text = "Select Output File";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.browseForSteoNCOutput);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 116);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(130, 23);
            this.generate.TabIndex = 3;
            this.generate.Text = "Generate StepNC Model";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // analyze
            // 
            this.analyze.Location = new System.Drawing.Point(12, 87);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(130, 23);
            this.analyze.TabIndex = 4;
            this.analyze.Text = "Analyze MTConnect Data";
            this.analyze.UseVisualStyleBackColor = true;
            // 
            // input_field
            // 
            this.input_field.Location = new System.Drawing.Point(148, 14);
            this.input_field.Name = "input_field";
            this.input_field.ReadOnly = true;
            this.input_field.Size = new System.Drawing.Size(100, 20);
            this.input_field.TabIndex = 5;
            // 
            // output_field
            // 
            this.output_field.Location = new System.Drawing.Point(148, 51);
            this.output_field.Name = "output_field";
            this.output_field.ReadOnly = true;
            this.output_field.Size = new System.Drawing.Size(100, 20);
            this.output_field.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 438);
            this.Controls.Add(this.output_field);
            this.Controls.Add(this.input_field);
            this.Controls.Add(this.analyze);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.textBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button analyze;
        private System.Windows.Forms.TextBox input_field;
        private System.Windows.Forms.TextBox output_field;
    }
}

