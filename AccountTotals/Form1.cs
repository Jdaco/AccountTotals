﻿using System;
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

        void IAccountView.setAccounts(IEnumerable<KeyValuePair<string, double>> items)
        {
            AccountsBind.Clear();
            foreach (KeyValuePair<string, double> item in items)
            {
                AccountsBind.Add(item);
            }
            dataGridView1.ClearSelection();
        }

        private void Entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _composer.ReadCommand(Entry.Text);
                Entry.Clear();
            }
        }
    }
}
