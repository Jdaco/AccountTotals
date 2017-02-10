using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountTotals
{
    public partial class AccountTotalsForm : Form, IAccountView
    {
        private AccountComposer _composer;

        public AccountTotalsForm()
        {
            InitializeComponent();
            _composer = new AccountComposer(this);
            dataGridView1.Font = HistoryView.Font;
            this.ActiveControl = Entry;
        }

        public void RefreshHistory()
        {
            if (HistoryView.Items.Count > 0)
            {
                HistoryView.Items[HistoryView.Items.Count - 1].EnsureVisible();
            }
        }

        void IAccountView.setHistory(IEnumerable<string> items)
        {
            HistoryView.Items.Clear();
            foreach (string item in items)
            {
                HistoryView.Items.Add(item);
            }
            HistoryView.Columns[0].Width = -1;
        }

        void IAccountView.setAccounts(IEnumerable<KeyValuePair<string, Decimal>> items)
        {
            AccountsBind.Clear();
            foreach (KeyValuePair<string, Decimal> item in items)
            {
                AccountsBind.Add(item);
            }
            dataGridView1.ClearSelection();
        }

        void IAccountView.clearAccounts()
        {
            AccountsBind.Clear();
        }

        void IAccountView.clearHistory()
        {
            HistoryView.Items.Clear();
        }

        private void Entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _composer.ReadCommand(Entry.Text);
                Entry.Clear();
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            _composer.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            _composer.Redo();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _composer.Clear();
        }

        private void Entry_Leave(object sender, EventArgs e)
        {
            Entry.Focus();
        }
    }
}
