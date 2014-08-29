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
            this.Entry = new System.Windows.Forms.TextBox();
            this.HistoryView = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountsBind = new System.Windows.Forms.BindingSource(this.components);
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBind)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.HistoryView);
            this.splitContainer1.Panel2.Controls.Add(this.Entry);
            this.splitContainer1.Size = new System.Drawing.Size(809, 643);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // Entry
            // 
            this.Entry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Entry.Location = new System.Drawing.Point(0, 623);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(536, 20);
            this.Entry.TabIndex = 0;
            this.Entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entry_KeyPress);
            // 
            // HistoryView
            // 
            this.HistoryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item});
            this.HistoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.HistoryView.Location = new System.Drawing.Point(0, 0);
            this.HistoryView.MultiSelect = false;
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.Size = new System.Drawing.Size(536, 623);
            this.HistoryView.TabIndex = 1;
            this.HistoryView.UseCompatibleStateImageBehavior = false;
            this.HistoryView.View = System.Windows.Forms.View.Details;
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
            this.dataGridView1.Size = new System.Drawing.Size(269, 643);
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
            // AccountTotalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 643);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccountTotalsForm";
            this.Text = "Account Totals";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsBind)).EndInit();
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
    }
}

