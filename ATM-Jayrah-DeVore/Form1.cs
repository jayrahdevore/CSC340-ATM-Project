using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ATM_Jayrah_DeVore
{
   

    public partial class Form1 : Form
    {
        List<Account> accounts;

        public Form1()
        {
            InitializeComponent();
            panel_login.Visible = true;
            panel_main_menu.Visible = false;

            accounts = new List<Account>();
            
        }


        private void main_logout_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_main_menu.Visible = false;
            
        }

        private void main_viewbalance_Click(object sender, EventArgs e)
        {
            tabcontrol_main.SelectedTab = tab_view_balance;
            //list_all_accounts(listbox_viewbalance_selectaccount);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (Account.IsValidAccount(textbox_account_number.Text, textbox_pin.Text))
            {
                panel_main_menu.Visible = true;
                panel_login.Visible = false;
                this.accounts = Account.getAccounts(textbox_account_number.Text);
                UpdateBalances();
                list_all_accounts(listbox_transfer_sending);
                list_all_accounts(listbox_viewbalance_selectaccount);
                list_all_accounts(listbox_withdraw_select);
                list_all_accounts(listbox_deposit_select);
            } else
            {
                System.Windows.Forms.MessageBox.Show("Invalid credentials");
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //decimal new_balance = decimal.Parse(textbox_deposit_amount.Text)
            //    + decimal.Parse(textbox_deposit_balance.Text);

            Account thisAccount = GetSelectedAccountFromListbox(listbox_deposit_select);
            decimal deposit_amount = decimal.Parse(textbox_deposit_amount.Text);
            if (thisAccount.ExceedsDailyTransactionAmount(deposit_amount))
            {
                System.Windows.Forms.MessageBox.Show("Exceeded Daily Transaction Limit");
            }
            else
            {
                thisAccount.Update(deposit_amount);
                System.Windows.Forms.MessageBox.Show("Deposit Successful.  Current balance is $" + thisAccount.getBalance().ToString());
                button_deposit_make.Enabled = false;
                this.return_to_main(sender, e);
                // update amount
                textbox_deposit_amount.Enabled = true;
                textbox_deposit_amount.Text = "";
                UpdateBalances();

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox_deposit_amount.Enabled = true;
            ShowBalanceFromListbox(listbox_deposit_select, textbox_deposit_balance);

        }

        private void deposit_amount_TextChanged(object sender, EventArgs e)
        {
            // add in some sort of logic to only allow proper input?
            if (IsValidFormat(textbox_deposit_amount))
            {
                button_deposit_make.Enabled = true;
            }
            else
            {
                button_deposit_make.Enabled = false;
            }
        }

        private void return_to_main(object sender, EventArgs e)
        {
            tabcontrol_main.SelectedTab = tab_main;
        }

        private void textbox_transfer_amount_TextChanged(object sender, EventArgs e)
        {
            if (IsValidFormat(textbox_transfer_amount))
            {
                decimal amount = Math.Round(decimal.Parse(textbox_transfer_amount.Text), 2);
                decimal new_sending = decimal.Parse(textbox_transfer_sending_prev.Text) - amount;
                decimal new_rx = decimal.Parse(textbox_transfer_rx_prev.Text) + amount;
                textbox_transfer_sending_new.Text = new_sending.ToString();
                textbox_transfer_rx_new.Text = new_rx.ToString();
                button_transfer_make.Enabled = true;
            } else {
                textbox_transfer_sending_new.Text = "";
                textbox_transfer_rx_new.Text = "";
                button_transfer_make.Enabled = false;
            }
            
        }

        private void button_withdraw_make_Click(object sender, EventArgs e)
        {

            Account thisAccount = GetSelectedAccountFromListbox(listbox_withdraw_select);
            decimal withdraw_amount = decimal.Parse(textbox_withdraw_amount.Text);
            if (thisAccount.ExceedsDailyTransactionAmount(withdraw_amount))
            {
                System.Windows.Forms.MessageBox.Show("Exceeded Daily Transaction Limit");
            }
            else if (thisAccount.getBalance() < withdraw_amount ) {
                System.Windows.Forms.MessageBox.Show("Insufficient Funds");
            } else
            {
                thisAccount.Update(-withdraw_amount);
                System.Windows.Forms.MessageBox.Show("Withdraw Successful. Cash is dispensed below");
                textbox_withdraw_amount.Enabled = false;
                button_withdraw_make.Enabled = false;
                this.return_to_main(sender, e);
                // update amount
                textbox_withdraw_amount.Enabled = true;
                textbox_withdraw_amount.Text = "";
                UpdateBalances();

            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox_withdraw_amount.Enabled = true;
            ShowBalanceFromListbox(listbox_withdraw_select, textbox_withdraw_previous);
        }
        /*
        private void cleanTextboxForCurrency(TextBox tb)
        {
            // rounds value to 2 decimal places, removes characters
            String text = tb.Text;
            String new_text = "";
            foreach (char c in text.ToCharArray())
            {
                if ((c >= '0' && c <= '9') || c == '.')
                {
                    new_text += c;
                }
            }
            decimal parsed;
            if (decimal.TryParse(new_text, out parsed))
            {
                tb.Text = String.Format("{0:.2f}", Math.Rparsed);
            }
            else
            {
                tb.Text = new_text;
            }
                
        }*/

        
        private void textbox_withdraw_amount_TextChanged(object sender, EventArgs e)
        {
            if (IsValidFormat(textbox_withdraw_amount))
            {
                button_withdraw_make.Enabled = true;
            }
            else
            {
                button_withdraw_make.Enabled = false;
            }
            
        }

        private void listbox_transfer_sending_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get balance
            //list_all_accounts(listbox_transfer_recieving);
            ShowBalanceFromListbox(listbox_transfer_sending, textbox_transfer_sending_prev);

            List<Account> remaining = new List<Account>();
            this.accounts.ForEach(delegate (Account a)
            {
                remaining.Add(a);
            });

            remaining.Remove((Account) listbox_transfer_sending.SelectedItem);
            listbox_transfer_recieving.DataSource = remaining;
            listbox_transfer_recieving.Enabled = true;
            
        }

        private bool IsValidFormat(TextBox tb)
        {
            // returns true if textbox contains valid currency format
            decimal value;
            if (decimal.TryParse(tb.Text, out value) && value == Math.Round(value, 2))
            {
                return true;
            }
            return false;
        }

        private void list_all_accounts(ListBox list)
        {
            /*
            list.Enabled = true;

            list.Items.Clear();
            list.BeginUpdate();

            
            list.EndUpdate();
            */
            list.DataSource = this.accounts;
            //list.ClearSelected();
        }

        private void main_withdraw_Click(object sender, EventArgs e)
        {
            tabcontrol_main.SelectedTab = tab_withdraw_money;
        }

        private void main_deposit_Click(object sender, EventArgs e)
        {
            tabcontrol_main.SelectedTab = tab_deposit_money;
            
        }

        private void main_transfer_Click(object sender, EventArgs e)
        {
            tabcontrol_main.SelectedTab = tab_transfer_money;
        }

        private void textbox_pin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listbox_viewbalance_selectaccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBalanceFromListbox(listbox_viewbalance_selectaccount, textbox_viewbalance);
            
            
        }

        private void UpdateBalances()
        {
            ShowBalanceFromListbox(listbox_deposit_select, textbox_deposit_balance);
            ShowBalanceFromListbox(listbox_withdraw_select, textbox_withdraw_previous);
            ShowBalanceFromListbox(listbox_transfer_sending, textbox_transfer_sending_prev);
            ShowBalanceFromListbox(listbox_viewbalance_selectaccount, textbox_viewbalance);
        }

        private void ShowBalanceFromListbox(ListBox lb, TextBox tb)
        {
            if (lb.SelectedIndex >= 0)
            {
                
                Account selection = (Account)lb.SelectedItem;
                tb.Text = String.Format("{0:.00}", selection.getBalance());
            }
            else
            {
                tb.Text = "";
            }
        }

        private Account GetSelectedAccountFromListbox(ListBox lb)
        {
            Account selected = null;
            if (lb.SelectedIndex >= 0)
            {
                selected = (Account)lb.SelectedItem;
            }
            return selected;
        }

        private void ListboxTransferSelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBalanceFromListbox(listbox_transfer_recieving, textbox_transfer_rx_prev);
            textbox_transfer_amount.Enabled = true;
        }

        private void ButtonTransferMakeClick(object sender, EventArgs e)
        {
            
            decimal amount = decimal.Parse(textbox_transfer_amount.Text);
            //decimal new_sending = decimal.Parse(textbox_transfer_sending_prev.Text) - amount;

            Account fromAccount = GetSelectedAccountFromListbox(listbox_transfer_sending);
            Account toAccount = GetSelectedAccountFromListbox(listbox_transfer_recieving);

            if (fromAccount.ExceedsDailyTransactionAmount(amount) || toAccount.ExceedsDailyTransactionAmount(amount))
            {
                System.Windows.Forms.MessageBox.Show("Exceeded Daily Transaction Amount");
            }
            else if (fromAccount.getBalance() < amount)
            {
                System.Windows.Forms.MessageBox.Show("Insufficient Funds");
            } else
            {
                fromAccount.Update(-amount);
                toAccount.Update(amount);
                System.Windows.Forms.MessageBox.Show("Transfer Successful");
                textbox_transfer_amount.Text = "";
                button_transfer_make.Enabled = false;
                return_to_main(sender, e);
                UpdateBalances();
            }
            
        }
    }
}
