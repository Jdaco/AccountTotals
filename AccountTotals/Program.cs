﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountTotals
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AccountTotalsForm());
        }
    }

    public interface IAccountView
    {
        void setAccounts(IEnumerable<KeyValuePair<string, Decimal>> accounts);
        void setTotal(string total);
        void setHistory(IEnumerable<string> history);
        void clearAccounts();
        void clearHistory();
        void RefreshHistory();
    }

    public class AccountComposer
    {
        private IAccountView _view;
        private HistoryList _history;
        private IDictionary<string, Decimal> _accounts;
        private Stack<string> _actions;
        private string _buff = null;

        public AccountComposer(IAccountView view)
        {
            _history = new HistoryList();
            _accounts = new SortedDictionary<string, Decimal>();
            _actions = new Stack<string>();
            _view = view;
        }

        public void ReadCommand(string command)
        {
            if (_buff != null)
            {
                Decimal d;
                try
                {
                    d = Convert.ToDecimal(command);
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("You entered invalid input.");
                    return;
                }
                Command c;
                if (_accounts.ContainsKey(_buff))
                {
                    c = new AddToAccount(ref _accounts, _buff, d);
                }
                else
                {
                    c = new CreateAccount(ref _accounts, _buff, d);
                }

                string action = _buff + " " + command;
                AddAction a = new AddAction(ref _actions, action);
                MacroCommand m = new MacroCommand(c, a);
                m.Execute();
                _history.Add(m);
                RefreshView();
                _buff = null;
            }
            else
            {
                _buff = command;
            }
        }

        public void Undo()
        {
            _history.Undo();
            RefreshView();
        }
        
        public void Redo()
        {
            _history.Redo();
            RefreshView();
        }

        public void Clear()
        {
            _accounts.Clear();
            _buff = null;
            _actions.Clear();
            _history.Clear();
            _view.clearHistory();
            _view.clearAccounts();
        }

        private void RefreshView()
        {
            string total = _accounts.Values.Sum().ToString();
            _view.setAccounts(_accounts);
            _view.setTotal(total);
            List<string> l = _actions.ToList();
            l.Reverse();
            _view.setHistory(l);
            _view.RefreshHistory();
        }
    }

    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Unexecute();
    }

    public class MacroCommand : Command
    {
        private Command[] _children;

        public MacroCommand(params Command[] c)
        {
            _children = c;
        }

        public override void Execute()
        {
            foreach(Command c in _children)
            {
                c.Execute();
            }
        }

        public override void Unexecute()
        {
            foreach(Command c in _children)
            {
                c.Unexecute();
            }
        }
    }

    public class CreateAccount : Command
    {
        private IDictionary<string, Decimal> _accounts;
        private string _key;
        private Decimal _amount;

        public CreateAccount(ref IDictionary<string, Decimal> accounts, string key, Decimal amount)
        {
            _accounts = accounts;
            _key = key;
            _amount = amount;
        }

        public override void Execute()
        {
            _accounts.Add(_key, _amount);
        }

        public override void Unexecute()
        {
            _accounts.Remove(_key);
        }
    }

    public class AddToAccount : Command
    {
        private IDictionary<string, Decimal> _accounts;
        private string _key;
        private Decimal _amount;
        private string _buff;
        private Decimal d;

        public AddToAccount(ref IDictionary<string, Decimal> accounts, string key, Decimal amount)
        {
            _accounts = accounts;
            _key = key;
            _amount = amount;
        }

        public override void Execute()
        {
            _accounts[_key] += _amount;
        }

        public override void Unexecute()
        {
            _accounts[_key] -= _amount;
        }
    }

    public class AddAction : Command
    {
        private Stack<string> _actions;
        private string _actionToAdd;

        public AddAction(ref Stack<string> actions, string actionToAdd)
        {
            _actions = actions;
            _actionToAdd = actionToAdd;
        }

        public override void Execute()
        {
            _actions.Push(_actionToAdd);
        }

        public override void Unexecute()
        {
            _actions.Pop();
        }
    }

    public class HistoryList
    {
        private Stack<Command> _past;
        private Stack<Command> _future;

        public HistoryList()
        {
            _past = new Stack<Command>();
            _future = new Stack<Command>();
        }

        public void Redo()
        {
            if (_future.Count != 0)
            {
                Command c = _future.Pop();
                c.Execute();
                _past.Push(c);
            }
        }

        public void Undo()
        {
            if (_past.Count != 0)
            {
                Command c = _past.Pop();
                c.Unexecute();
                _future.Push(c);
            }
        }

        public void Add(Command c)
        {
            _past.Push(c);
            ClearFuture();
        }

        private void ClearFuture()
        {
            _future.Clear();
        }

        public void Clear()
        {
            _past.Clear();
            _future.Clear();
        }
    }

}
