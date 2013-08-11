namespace swxben.Windows.Forms.Dialogs
{
    partial class DateRangePromptDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelPromptButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.InputFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.InputToDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.InputFromDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PromptLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CancelPromptButton);
            this.flowLayoutPanel1.Controls.Add(this.OkButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // CancelPromptButton
            // 
            this.CancelPromptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPromptButton.Location = new System.Drawing.Point(299, 3);
            this.CancelPromptButton.Name = "CancelPromptButton";
            this.CancelPromptButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPromptButton.TabIndex = 0;
            this.CancelPromptButton.Text = "Cancel";
            this.CancelPromptButton.UseVisualStyleBackColor = true;
            this.CancelPromptButton.Click += new System.EventHandler(this.CancelPromptButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(218, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InputFromDateTimePicker
            // 
            this.InputFromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFromDateTimePicker.Location = new System.Drawing.Point(61, 28);
            this.InputFromDateTimePicker.Name = "InputFromDateTimePicker";
            this.InputFromDateTimePicker.Size = new System.Drawing.Size(377, 20);
            this.InputFromDateTimePicker.TabIndex = 2;
            this.InputFromDateTimePicker.ValueChanged += new System.EventHandler(this.InputFromDateTimePicker_ValueChanged);
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.PromptLabel, 2);
            this.PromptLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromptLabel.Location = new System.Drawing.Point(3, 6);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(435, 13);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "{PROMPT}";
            this.PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Between:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "And:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputToDateTimePicker
            // 
            this.InputToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputToDateTimePicker.Location = new System.Drawing.Point(61, 54);
            this.InputToDateTimePicker.Name = "InputToDateTimePicker";
            this.InputToDateTimePicker.Size = new System.Drawing.Size(377, 20);
            this.InputToDateTimePicker.TabIndex = 5;
            this.InputToDateTimePicker.ValueChanged += new System.EventHandler(this.InputToDateTimePicker_ValueChanged);
            // 
            // DateRangePromptDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.CancelPromptButton;
            this.ClientSize = new System.Drawing.Size(441, 105);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DateRangePromptDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DateRangePromptDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CancelPromptButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DateTimePicker InputFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker InputToDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Label label1;
    }
}