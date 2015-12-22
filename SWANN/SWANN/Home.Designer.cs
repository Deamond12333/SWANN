namespace SWANN
{
    partial class Home
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
            this.function = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SWANNEnabled = new System.Windows.Forms.CheckBox();
            this.interval = new System.Windows.Forms.GroupBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ex = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.interval.SuspendLayout();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(15, 25);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(262, 20);
            this.function.TabIndex = 0;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(15, 100);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(487, 23);
            this.go.TabIndex = 1;
            this.go.Text = "Считать";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите функцию:";
            // 
            // SWANNEnabled
            // 
            this.SWANNEnabled.AutoSize = true;
            this.SWANNEnabled.Location = new System.Drawing.Point(83, 51);
            this.SWANNEnabled.Name = "SWANNEnabled";
            this.SWANNEnabled.Size = new System.Drawing.Size(194, 43);
            this.SWANNEnabled.TabIndex = 4;
            this.SWANNEnabled.Text = "Использовать алгоритм SWANN\r\nдля нахождения\r\nинтервала неопределенности";
            this.SWANNEnabled.UseVisualStyleBackColor = true;
            this.SWANNEnabled.CheckedChanged += new System.EventHandler(this.SWANNEnabled_CheckedChanged);
            // 
            // interval
            // 
            this.interval.Controls.Add(this.b);
            this.interval.Controls.Add(this.label3);
            this.interval.Controls.Add(this.a);
            this.interval.Controls.Add(this.label1);
            this.interval.Location = new System.Drawing.Point(283, 9);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(219, 72);
            this.interval.TabIndex = 5;
            this.interval.TabStop = false;
            this.interval.Text = "Введите интервал неопределенности:";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(28, 42);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(28, 16);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Введите E:";
            // 
            // ex
            // 
            this.ex.Location = new System.Drawing.Point(15, 67);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(59, 20);
            this.ex.TabIndex = 11;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(15, 129);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(487, 120);
            this.result.TabIndex = 13;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.SWANNEnabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.go);
            this.Controls.Add(this.function);
            this.Name = "Home";
            this.Text = "Метод SWANN и дихотомия функции";
            this.interval.ResumeLayout(false);
            this.interval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SWANNEnabled;
        private System.Windows.Forms.GroupBox interval;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ex;
        private System.Windows.Forms.TextBox result;
    }
}