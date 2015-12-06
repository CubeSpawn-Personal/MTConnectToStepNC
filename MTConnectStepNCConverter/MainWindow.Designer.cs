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
            this.info = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.input_button = new System.Windows.Forms.Button();
            this.output_button = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.analyze = new System.Windows.Forms.Button();
            this.input_field = new System.Windows.Forms.TextBox();
            this.output_field = new System.Windows.Forms.TextBox();
            this.analysisWorker = new System.ComponentModel.BackgroundWorker();
            this.stepncWorker = new System.ComponentModel.BackgroundWorker();
            this.template_button = new System.Windows.Forms.Button();
            this.template_file = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(271, 12);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info.Size = new System.Drawing.Size(612, 373);
            this.info.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MTConnect XML|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "StepNC|*.stpnc";
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
            this.output_button.Location = new System.Drawing.Point(12, 92);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(130, 23);
            this.output_button.TabIndex = 2;
            this.output_button.Text = "Select Output File";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.browseForSteoNCOutput);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 365);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(130, 23);
            this.generate.TabIndex = 3;
            this.generate.Text = "Generate StepNC Model";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // analyze
            // 
            this.analyze.Location = new System.Drawing.Point(12, 336);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(130, 23);
            this.analyze.TabIndex = 4;
            this.analyze.Text = "Analyze MTConnect Data";
            this.analyze.UseVisualStyleBackColor = true;
            this.analyze.Click += new System.EventHandler(this.analyzeMTConnect);
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
            this.output_field.Location = new System.Drawing.Point(148, 92);
            this.output_field.Name = "output_field";
            this.output_field.ReadOnly = true;
            this.output_field.Size = new System.Drawing.Size(100, 20);
            this.output_field.TabIndex = 6;
            // 
            // analysisWorker
            // 
            this.analysisWorker.WorkerReportsProgress = true;
            this.analysisWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.analysisWorker_DoWork);
            this.analysisWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.analysisWorker_ProgressChanged);
            this.analysisWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.analysisWorker_RunWorkerCompleted);
            // 
            // stepncWorker
            // 
            this.stepncWorker.WorkerReportsProgress = true;
            this.stepncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.stepncWorker_DoWork);
            this.stepncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.stepncWorker_ProgressChanged);
            // 
            // template_button
            // 
            this.template_button.Location = new System.Drawing.Point(12, 51);
            this.template_button.Name = "template_button";
            this.template_button.Size = new System.Drawing.Size(130, 23);
            this.template_button.TabIndex = 7;
            this.template_button.Text = "Select Template File";
            this.template_button.UseVisualStyleBackColor = true;
            this.template_button.Click += new System.EventHandler(this.template_button_Click);
            // 
            // template_file
            // 
            this.template_file.Location = new System.Drawing.Point(148, 54);
            this.template_file.Name = "template_file";
            this.template_file.ReadOnly = true;
            this.template_file.Size = new System.Drawing.Size(100, 20);
            this.template_file.TabIndex = 8;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "StepNC Files|*.stpnc";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 438);
            this.Controls.Add(this.template_file);
            this.Controls.Add(this.template_button);
            this.Controls.Add(this.output_field);
            this.Controls.Add(this.input_field);
            this.Controls.Add(this.analyze);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.info);
            this.Name = "MainWindow";
            this.Text = "MTConnect to StepNC Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button analyze;
        private System.Windows.Forms.TextBox input_field;
        private System.Windows.Forms.TextBox output_field;
        private System.ComponentModel.BackgroundWorker analysisWorker;
        private System.ComponentModel.BackgroundWorker stepncWorker;
        private System.Windows.Forms.Button template_button;
        private System.Windows.Forms.TextBox template_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

