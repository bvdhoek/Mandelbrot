namespace Mandelbrot
{
    partial class UserInterface
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.presetBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.greenMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.blueMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.centerXTextBox = new System.Windows.Forms.TextBox();
            this.centerYTextBox = new System.Windows.Forms.TextBox();
            this.centerYLabel = new System.Windows.Forms.Label();
            this.centerXLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.mandelbrot_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.presetBox);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.redMultiplierTextBox);
            this.splitContainer.Panel2.Controls.Add(this.greenMultiplierTextBox);
            this.splitContainer.Panel2.Controls.Add(this.blueMultiplierTextBox);
            this.splitContainer.Panel2.Controls.Add(this.scaleTextBox);
            this.splitContainer.Panel2.Controls.Add(this.maxTextBox);
            this.splitContainer.Panel2.Controls.Add(this.centerXTextBox);
            this.splitContainer.Panel2.Controls.Add(this.centerYTextBox);
            this.splitContainer.Panel2.Controls.Add(this.centerYLabel);
            this.splitContainer.Panel2.Controls.Add(this.centerXLabel);
            this.splitContainer.Panel2.Controls.Add(this.maxLabel);
            this.splitContainer.Panel2.Controls.Add(this.scaleLabel);
            this.splitContainer.Panel2.Controls.Add(this.runButton);
            this.splitContainer.Size = new System.Drawing.Size(1331, 753);
            this.splitContainer.SplitterDistance = 1005;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // presetBox
            // 
            this.presetBox.FormattingEnabled = true;
            this.presetBox.ItemHeight = 16;
            this.presetBox.Location = new System.Drawing.Point(24, 321);
            this.presetBox.Name = "presetBox";
            this.presetBox.Size = new System.Drawing.Size(247, 84);
            this.presetBox.TabIndex = 16;
            this.presetBox.SelectedIndexChanged += new System.EventHandler(this.loadPresetValues);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Blue Multiplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Green Multiplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Red Multiplier:";
            // 
            // redMultiplierTextBox
            // 
            this.redMultiplierTextBox.Location = new System.Drawing.Point(139, 174);
            this.redMultiplierTextBox.Name = "redMultiplierTextBox";
            this.redMultiplierTextBox.Size = new System.Drawing.Size(132, 22);
            this.redMultiplierTextBox.TabIndex = 12;
            this.redMultiplierTextBox.Text = "5";
            // 
            // greenMultiplierTextBox
            // 
            this.greenMultiplierTextBox.Location = new System.Drawing.Point(139, 202);
            this.greenMultiplierTextBox.Name = "greenMultiplierTextBox";
            this.greenMultiplierTextBox.Size = new System.Drawing.Size(132, 22);
            this.greenMultiplierTextBox.TabIndex = 11;
            this.greenMultiplierTextBox.Text = "25";
            // 
            // blueMultiplierTextBox
            // 
            this.blueMultiplierTextBox.Location = new System.Drawing.Point(139, 230);
            this.blueMultiplierTextBox.Name = "blueMultiplierTextBox";
            this.blueMultiplierTextBox.Size = new System.Drawing.Size(132, 22);
            this.blueMultiplierTextBox.TabIndex = 10;
            this.blueMultiplierTextBox.Text = "50";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(139, 49);
            this.scaleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(132, 22);
            this.scaleTextBox.TabIndex = 9;
            this.scaleTextBox.Text = "0.01";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(139, 81);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(132, 22);
            this.maxTextBox.TabIndex = 8;
            this.maxTextBox.Text = "100";
            // 
            // centerXTextBox
            // 
            this.centerXTextBox.Location = new System.Drawing.Point(139, 113);
            this.centerXTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.centerXTextBox.Name = "centerXTextBox";
            this.centerXTextBox.Size = new System.Drawing.Size(132, 22);
            this.centerXTextBox.TabIndex = 7;
            this.centerXTextBox.Text = "0";
            // 
            // centerYTextBox
            // 
            this.centerYTextBox.Location = new System.Drawing.Point(139, 145);
            this.centerYTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.centerYTextBox.Name = "centerYTextBox";
            this.centerYTextBox.Size = new System.Drawing.Size(132, 22);
            this.centerYTextBox.TabIndex = 6;
            this.centerYTextBox.Text = "0";
            // 
            // centerYLabel
            // 
            this.centerYLabel.AutoSize = true;
            this.centerYLabel.Location = new System.Drawing.Point(21, 149);
            this.centerYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.centerYLabel.Name = "centerYLabel";
            this.centerYLabel.Size = new System.Drawing.Size(71, 17);
            this.centerYLabel.TabIndex = 5;
            this.centerYLabel.Text = "Midden Y:";
            // 
            // centerXLabel
            // 
            this.centerXLabel.AutoSize = true;
            this.centerXLabel.Location = new System.Drawing.Point(21, 117);
            this.centerXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.centerXLabel.Name = "centerXLabel";
            this.centerXLabel.Size = new System.Drawing.Size(71, 17);
            this.centerXLabel.TabIndex = 4;
            this.centerXLabel.Text = "Midden X:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(21, 85);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(37, 17);
            this.maxLabel.TabIndex = 3;
            this.maxLabel.Text = "Max:";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(21, 53);
            this.scaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(55, 17);
            this.scaleLabel.TabIndex = 2;
            this.scaleLabel.Text = "Schaal:";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(24, 259);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(247, 38);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 753);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.ResizeEnd += new System.EventHandler(this.drawResizedMandelbrot);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox redMultiplierTextBox;
        private System.Windows.Forms.TextBox greenMultiplierTextBox;
        private System.Windows.Forms.TextBox blueMultiplierTextBox;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox centerXTextBox;
        private System.Windows.Forms.TextBox centerYTextBox;
        private System.Windows.Forms.Label centerYLabel;
        private System.Windows.Forms.Label centerXLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ListBox presetBox;
    }
}