namespace AccountTotals
{
    partial class AccountTotalsForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountsBind = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Entry = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.HistoryView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBind)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.HistoryView);
            this.splitContainer1.Size = new System.Drawing.Size(640, 462);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account,
            this.Total});
            this.dataGridView1.DataSource = this.AccountsBind;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(211, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Key";
            this.Account.HeaderText = "Column1";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 5;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Value";
            this.Total.HeaderText = "Column1";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Entry);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.UndoButton);
            this.panel1.Controls.Add(this.RedoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 56);
            this.panel1.TabIndex = 5;
            // 
            // Entry
            // 
            this.Entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entry.Location = new System.Drawing.Point(0, 0);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(425, 20);
            this.Entry.TabIndex = 0;
            this.Entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entry_KeyPress);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(277, 26);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(74, 26);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 4;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(182, 26);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(75, 23);
            this.RedoButton.TabIndex = 2;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // HistoryView
            // 
            this.HistoryView.BackColor = System.Drawing.SystemColors.Menu;
            this.HistoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item});
            this.HistoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.HistoryView.Location = new System.Drawing.Point(0, 0);
            this.HistoryView.MultiSelect = false;
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.Size = new System.Drawing.Size(425, 462);
            this.HistoryView.TabIndex = 1;
            this.HistoryView.UseCompatibleStateImageBehavior = false;
            this.HistoryView.View = System.Windows.Forms.View.Details;
            // 
            // AccountTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 462);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(656, 500);
            this.Name = "AccountTotalsForm";
            this.Text = "Account Totals";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBind)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView HistoryView;
        private System.Windows.Forms.BindingSource AccountsBind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

