namespace swxben.Windows.Forms.TestApplication
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DateTimePromptButton = new System.Windows.Forms.Button();
            this.GenericListSearchButton = new System.Windows.Forms.Button();
            this.StringListSearchButton = new System.Windows.Forms.Button();
            this.TextPromptButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DateTimePromptButton);
            this.flowLayoutPanel1.Controls.Add(this.GenericListSearchButton);
            this.flowLayoutPanel1.Controls.Add(this.StringListSearchButton);
            this.flowLayoutPanel1.Controls.Add(this.TextPromptButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DateTimePromptButton
            // 
            this.DateTimePromptButton.AutoSize = true;
            this.DateTimePromptButton.Location = new System.Drawing.Point(3, 3);
            this.DateTimePromptButton.Name = "DateTimePromptButton";
            this.DateTimePromptButton.Size = new System.Drawing.Size(96, 23);
            this.DateTimePromptButton.TabIndex = 0;
            this.DateTimePromptButton.Text = "DateTimePrompt";
            this.DateTimePromptButton.UseVisualStyleBackColor = true;
            this.DateTimePromptButton.Click += new System.EventHandler(this.DateTimePromptButton_Click);
            // 
            // GenericListSearchButton
            // 
            this.GenericListSearchButton.AutoSize = true;
            this.GenericListSearchButton.Location = new System.Drawing.Point(105, 3);
            this.GenericListSearchButton.Name = "GenericListSearchButton";
            this.GenericListSearchButton.Size = new System.Drawing.Size(104, 23);
            this.GenericListSearchButton.TabIndex = 1;
            this.GenericListSearchButton.Text = "GenericListSearch";
            this.GenericListSearchButton.UseVisualStyleBackColor = true;
            this.GenericListSearchButton.Click += new System.EventHandler(this.GenericListSearchButton_Click);
            // 
            // StringListSearchButton
            // 
            this.StringListSearchButton.AutoSize = true;
            this.StringListSearchButton.Location = new System.Drawing.Point(3, 32);
            this.StringListSearchButton.Name = "StringListSearchButton";
            this.StringListSearchButton.Size = new System.Drawing.Size(94, 23);
            this.StringListSearchButton.TabIndex = 2;
            this.StringListSearchButton.Text = "StringListSearch";
            this.StringListSearchButton.UseVisualStyleBackColor = true;
            this.StringListSearchButton.Click += new System.EventHandler(this.StringListSearchButton_Click);
            // 
            // TextPromptButton
            // 
            this.TextPromptButton.AutoSize = true;
            this.TextPromptButton.Location = new System.Drawing.Point(103, 32);
            this.TextPromptButton.Name = "TextPromptButton";
            this.TextPromptButton.Size = new System.Drawing.Size(75, 23);
            this.TextPromptButton.TabIndex = 3;
            this.TextPromptButton.Text = "TextPrompt";
            this.TextPromptButton.UseVisualStyleBackColor = true;
            this.TextPromptButton.Click += new System.EventHandler(this.TextPromptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DateTimePromptButton;
        private System.Windows.Forms.Button GenericListSearchButton;
        private System.Windows.Forms.Button StringListSearchButton;
        private System.Windows.Forms.Button TextPromptButton;

    }
}