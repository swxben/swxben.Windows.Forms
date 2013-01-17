namespace swxben.Windows.Forms.Dialogs
{
    partial class GenericListSearchDialog<T>
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelSelectionButton = new System.Windows.Forms.Button();
            this.SelectItemButton = new System.Windows.Forms.Button();
            this.GenericListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SearchTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GenericListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(327, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CancelSelectionButton);
            this.flowLayoutPanel1.Controls.Add(this.SelectItemButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 195);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // CancelSelectionButton
            // 
            this.CancelSelectionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSelectionButton.Location = new System.Drawing.Point(249, 3);
            this.CancelSelectionButton.Name = "CancelSelectionButton";
            this.CancelSelectionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSelectionButton.TabIndex = 0;
            this.CancelSelectionButton.Text = "Cancel";
            this.CancelSelectionButton.UseVisualStyleBackColor = true;
            this.CancelSelectionButton.Click += new System.EventHandler(this.CancelSelectionButton_Click);
            // 
            // SelectItemButton
            // 
            this.SelectItemButton.Location = new System.Drawing.Point(168, 3);
            this.SelectItemButton.Name = "SelectItemButton";
            this.SelectItemButton.Size = new System.Drawing.Size(75, 23);
            this.SelectItemButton.TabIndex = 1;
            this.SelectItemButton.Text = "Select";
            this.SelectItemButton.UseVisualStyleBackColor = true;
            this.SelectItemButton.Click += new System.EventHandler(this.SelectItemButton_Click);
            // 
            // GenericListView
            // 
            this.GenericListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.GenericListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenericListView.FullRowSelect = true;
            this.GenericListView.HideSelection = false;
            this.GenericListView.Location = new System.Drawing.Point(3, 29);
            this.GenericListView.MultiSelect = false;
            this.GenericListView.Name = "GenericListView";
            this.GenericListView.Size = new System.Drawing.Size(327, 160);
            this.GenericListView.TabIndex = 3;
            this.GenericListView.UseCompatibleStateImageBehavior = false;
            this.GenericListView.View = System.Windows.Forms.View.Details;
            this.GenericListView.ItemActivate += new System.EventHandler(this.StringListView_ItemActivate);
            this.GenericListView.SelectedIndexChanged += new System.EventHandler(this.StringListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            // 
            // GenericListSearchForm
            // 
            this.AcceptButton = this.SelectItemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelSelectionButton;
            this.ClientSize = new System.Drawing.Size(333, 227);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GenericListSearchDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GenericListSearchDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CancelSelectionButton;
        private System.Windows.Forms.Button SelectItemButton;
        private System.Windows.Forms.ListView GenericListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}