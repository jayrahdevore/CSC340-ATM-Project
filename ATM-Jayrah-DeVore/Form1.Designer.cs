namespace ATM_Jayrah_DeVore
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main_menu = new System.Windows.Forms.Panel();
            this.tabcontrol_main = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.main_logout = new System.Windows.Forms.Button();
            this.main_transfer = new System.Windows.Forms.Button();
            this.main_deposit = new System.Windows.Forms.Button();
            this.main_withdraw = new System.Windows.Forms.Button();
            this.main_viewbalance = new System.Windows.Forms.Button();
            this.tab_view_balance = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_viewbalance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.listbox_viewbalance_selectaccount = new System.Windows.Forms.ListBox();
            this.tab_withdraw_money = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_withdraw_previous = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_withdraw_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_withdraw_make = new System.Windows.Forms.Button();
            this.listbox_withdraw_select = new System.Windows.Forms.ListBox();
            this.tab_deposit_money = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button_deposit_main_menu = new System.Windows.Forms.Button();
            this.textbox_deposit_balance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_deposit_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_deposit_make = new System.Windows.Forms.Button();
            this.listbox_deposit_select = new System.Windows.Forms.ListBox();
            this.tab_transfer_money = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.textbox_transfer_rx_prev = new System.Windows.Forms.TextBox();
            this.textbox_transfer_rx_new = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textbox_transfer_amount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listbox_transfer_recieving = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textbox_transfer_sending_prev = new System.Windows.Forms.TextBox();
            this.textbox_transfer_sending_new = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_transfer_make = new System.Windows.Forms.Button();
            this.listbox_transfer_sending = new System.Windows.Forms.ListBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_exit_program = new System.Windows.Forms.Button();
            this.textbox_pin = new System.Windows.Forms.TextBox();
            this.textbox_account_number = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Label();
            this.panel_main_menu.SuspendLayout();
            this.tabcontrol_main.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_view_balance.SuspendLayout();
            this.tab_withdraw_money.SuspendLayout();
            this.tab_deposit_money.SuspendLayout();
            this.tab_transfer_money.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZZZ Bank ATM";
            // 
            // panel_main_menu
            // 
            this.panel_main_menu.Controls.Add(this.tabcontrol_main);
            this.panel_main_menu.Location = new System.Drawing.Point(12, 84);
            this.panel_main_menu.Name = "panel_main_menu";
            this.panel_main_menu.Size = new System.Drawing.Size(1100, 614);
            this.panel_main_menu.TabIndex = 6;
            // 
            // tabcontrol_main
            // 
            this.tabcontrol_main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabcontrol_main.Controls.Add(this.tab_main);
            this.tabcontrol_main.Controls.Add(this.tab_view_balance);
            this.tabcontrol_main.Controls.Add(this.tab_withdraw_money);
            this.tabcontrol_main.Controls.Add(this.tab_deposit_money);
            this.tabcontrol_main.Controls.Add(this.tab_transfer_money);
            this.tabcontrol_main.ItemSize = new System.Drawing.Size(50, 50);
            this.tabcontrol_main.Location = new System.Drawing.Point(13, 29);
            this.tabcontrol_main.Name = "tabcontrol_main";
            this.tabcontrol_main.Padding = new System.Drawing.Point(6, 6);
            this.tabcontrol_main.SelectedIndex = 0;
            this.tabcontrol_main.Size = new System.Drawing.Size(1065, 537);
            this.tabcontrol_main.TabIndex = 7;
            // 
            // tab_main
            // 
            this.tab_main.BackColor = System.Drawing.Color.Transparent;
            this.tab_main.Controls.Add(this.main_logout);
            this.tab_main.Controls.Add(this.main_transfer);
            this.tab_main.Controls.Add(this.main_deposit);
            this.tab_main.Controls.Add(this.main_withdraw);
            this.tab_main.Controls.Add(this.main_viewbalance);
            this.tab_main.Location = new System.Drawing.Point(4, 4);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(1057, 479);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Main Menu";
            // 
            // main_logout
            // 
            this.main_logout.Location = new System.Drawing.Point(562, 275);
            this.main_logout.Name = "main_logout";
            this.main_logout.Size = new System.Drawing.Size(234, 143);
            this.main_logout.TabIndex = 10;
            this.main_logout.Text = "Logout";
            this.main_logout.UseVisualStyleBackColor = true;
            this.main_logout.Click += new System.EventHandler(this.main_logout_Click);
            // 
            // main_transfer
            // 
            this.main_transfer.Location = new System.Drawing.Point(213, 275);
            this.main_transfer.Name = "main_transfer";
            this.main_transfer.Size = new System.Drawing.Size(234, 143);
            this.main_transfer.TabIndex = 9;
            this.main_transfer.Text = "Transfer Funds";
            this.main_transfer.UseVisualStyleBackColor = true;
            this.main_transfer.Click += new System.EventHandler(this.main_transfer_Click);
            // 
            // main_deposit
            // 
            this.main_deposit.Location = new System.Drawing.Point(747, 73);
            this.main_deposit.Name = "main_deposit";
            this.main_deposit.Size = new System.Drawing.Size(234, 143);
            this.main_deposit.TabIndex = 8;
            this.main_deposit.Text = "Deposit";
            this.main_deposit.UseVisualStyleBackColor = true;
            this.main_deposit.Click += new System.EventHandler(this.main_deposit_Click);
            // 
            // main_withdraw
            // 
            this.main_withdraw.Location = new System.Drawing.Point(383, 73);
            this.main_withdraw.Name = "main_withdraw";
            this.main_withdraw.Size = new System.Drawing.Size(234, 143);
            this.main_withdraw.TabIndex = 7;
            this.main_withdraw.Text = "Withdraw";
            this.main_withdraw.UseVisualStyleBackColor = true;
            this.main_withdraw.Click += new System.EventHandler(this.main_withdraw_Click);
            // 
            // main_viewbalance
            // 
            this.main_viewbalance.Location = new System.Drawing.Point(45, 73);
            this.main_viewbalance.Name = "main_viewbalance";
            this.main_viewbalance.Size = new System.Drawing.Size(234, 143);
            this.main_viewbalance.TabIndex = 6;
            this.main_viewbalance.Text = "View Balance";
            this.main_viewbalance.UseVisualStyleBackColor = true;
            this.main_viewbalance.Click += new System.EventHandler(this.main_viewbalance_Click);
            // 
            // tab_view_balance
            // 
            this.tab_view_balance.Controls.Add(this.label2);
            this.tab_view_balance.Controls.Add(this.button1);
            this.tab_view_balance.Controls.Add(this.textbox_viewbalance);
            this.tab_view_balance.Controls.Add(this.label14);
            this.tab_view_balance.Controls.Add(this.listbox_viewbalance_selectaccount);
            this.tab_view_balance.Location = new System.Drawing.Point(4, 4);
            this.tab_view_balance.Name = "tab_view_balance";
            this.tab_view_balance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_view_balance.Size = new System.Drawing.Size(1057, 479);
            this.tab_view_balance.TabIndex = 2;
            this.tab_view_balance.Text = "View Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(239, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Select an Account";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(212, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 111);
            this.button1.TabIndex = 37;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.return_to_main);
            // 
            // textbox_viewbalance
            // 
            this.textbox_viewbalance.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_viewbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_viewbalance.Location = new System.Drawing.Point(733, 122);
            this.textbox_viewbalance.Name = "textbox_viewbalance";
            this.textbox_viewbalance.ReadOnly = true;
            this.textbox_viewbalance.Size = new System.Drawing.Size(150, 32);
            this.textbox_viewbalance.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(606, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 26);
            this.label14.TabIndex = 33;
            this.label14.Text = " Balance: $";
            // 
            // listbox_viewbalance_selectaccount
            // 
            this.listbox_viewbalance_selectaccount.FormattingEnabled = true;
            this.listbox_viewbalance_selectaccount.Location = new System.Drawing.Point(212, 84);
            this.listbox_viewbalance_selectaccount.Name = "listbox_viewbalance_selectaccount";
            this.listbox_viewbalance_selectaccount.Size = new System.Drawing.Size(239, 186);
            this.listbox_viewbalance_selectaccount.TabIndex = 31;
            this.listbox_viewbalance_selectaccount.SelectedIndexChanged += new System.EventHandler(this.listbox_viewbalance_selectaccount_SelectedIndexChanged);
            // 
            // tab_withdraw_money
            // 
            this.tab_withdraw_money.Controls.Add(this.label3);
            this.tab_withdraw_money.Controls.Add(this.button2);
            this.tab_withdraw_money.Controls.Add(this.textbox_withdraw_previous);
            this.tab_withdraw_money.Controls.Add(this.label4);
            this.tab_withdraw_money.Controls.Add(this.textbox_withdraw_amount);
            this.tab_withdraw_money.Controls.Add(this.label12);
            this.tab_withdraw_money.Controls.Add(this.button_withdraw_make);
            this.tab_withdraw_money.Controls.Add(this.listbox_withdraw_select);
            this.tab_withdraw_money.Location = new System.Drawing.Point(4, 4);
            this.tab_withdraw_money.Name = "tab_withdraw_money";
            this.tab_withdraw_money.Padding = new System.Windows.Forms.Padding(3);
            this.tab_withdraw_money.Size = new System.Drawing.Size(1057, 479);
            this.tab_withdraw_money.TabIndex = 3;
            this.tab_withdraw_money.Text = "Withdraw Money";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(269, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select an Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(242, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 111);
            this.button2.TabIndex = 29;
            this.button2.Text = "Return to Main Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.return_to_main);
            // 
            // textbox_withdraw_previous
            // 
            this.textbox_withdraw_previous.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_withdraw_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_withdraw_previous.Location = new System.Drawing.Point(763, 112);
            this.textbox_withdraw_previous.Name = "textbox_withdraw_previous";
            this.textbox_withdraw_previous.ReadOnly = true;
            this.textbox_withdraw_previous.Size = new System.Drawing.Size(150, 32);
            this.textbox_withdraw_previous.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Withdraw Amount: $";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textbox_withdraw_amount
            // 
            this.textbox_withdraw_amount.Enabled = false;
            this.textbox_withdraw_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_withdraw_amount.Location = new System.Drawing.Point(763, 160);
            this.textbox_withdraw_amount.Name = "textbox_withdraw_amount";
            this.textbox_withdraw_amount.Size = new System.Drawing.Size(150, 32);
            this.textbox_withdraw_amount.TabIndex = 26;
            this.textbox_withdraw_amount.TextChanged += new System.EventHandler(this.textbox_withdraw_amount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(551, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 26);
            this.label12.TabIndex = 25;
            this.label12.Text = "Previous Balance: $";
            // 
            // button_withdraw_make
            // 
            this.button_withdraw_make.Enabled = false;
            this.button_withdraw_make.Location = new System.Drawing.Point(556, 276);
            this.button_withdraw_make.Name = "button_withdraw_make";
            this.button_withdraw_make.Size = new System.Drawing.Size(357, 111);
            this.button_withdraw_make.TabIndex = 24;
            this.button_withdraw_make.Text = "Withdraw";
            this.button_withdraw_make.UseVisualStyleBackColor = true;
            this.button_withdraw_make.Click += new System.EventHandler(this.button_withdraw_make_Click);
            // 
            // listbox_withdraw_select
            // 
            this.listbox_withdraw_select.FormattingEnabled = true;
            this.listbox_withdraw_select.Location = new System.Drawing.Point(242, 74);
            this.listbox_withdraw_select.Name = "listbox_withdraw_select";
            this.listbox_withdraw_select.Size = new System.Drawing.Size(239, 186);
            this.listbox_withdraw_select.TabIndex = 23;
            this.listbox_withdraw_select.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tab_deposit_money
            // 
            this.tab_deposit_money.Controls.Add(this.label5);
            this.tab_deposit_money.Controls.Add(this.button_deposit_main_menu);
            this.tab_deposit_money.Controls.Add(this.textbox_deposit_balance);
            this.tab_deposit_money.Controls.Add(this.label11);
            this.tab_deposit_money.Controls.Add(this.textbox_deposit_amount);
            this.tab_deposit_money.Controls.Add(this.label6);
            this.tab_deposit_money.Controls.Add(this.button_deposit_make);
            this.tab_deposit_money.Controls.Add(this.listbox_deposit_select);
            this.tab_deposit_money.Location = new System.Drawing.Point(4, 4);
            this.tab_deposit_money.Name = "tab_deposit_money";
            this.tab_deposit_money.Padding = new System.Windows.Forms.Padding(3);
            this.tab_deposit_money.Size = new System.Drawing.Size(1057, 479);
            this.tab_deposit_money.TabIndex = 4;
            this.tab_deposit_money.Text = "Deposit Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(265, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select an Account";
            // 
            // button_deposit_main_menu
            // 
            this.button_deposit_main_menu.BackColor = System.Drawing.SystemColors.Control;
            this.button_deposit_main_menu.Location = new System.Drawing.Point(238, 270);
            this.button_deposit_main_menu.Name = "button_deposit_main_menu";
            this.button_deposit_main_menu.Size = new System.Drawing.Size(239, 111);
            this.button_deposit_main_menu.TabIndex = 21;
            this.button_deposit_main_menu.Text = "Return to Main Menu";
            this.button_deposit_main_menu.UseVisualStyleBackColor = false;
            this.button_deposit_main_menu.Click += new System.EventHandler(this.return_to_main);
            // 
            // textbox_deposit_balance
            // 
            this.textbox_deposit_balance.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_deposit_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_deposit_balance.Location = new System.Drawing.Point(759, 106);
            this.textbox_deposit_balance.Name = "textbox_deposit_balance";
            this.textbox_deposit_balance.ReadOnly = true;
            this.textbox_deposit_balance.Size = new System.Drawing.Size(150, 32);
            this.textbox_deposit_balance.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(561, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Deposit Amount: $";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textbox_deposit_amount
            // 
            this.textbox_deposit_amount.Enabled = false;
            this.textbox_deposit_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_deposit_amount.Location = new System.Drawing.Point(759, 154);
            this.textbox_deposit_amount.Name = "textbox_deposit_amount";
            this.textbox_deposit_amount.Size = new System.Drawing.Size(150, 32);
            this.textbox_deposit_amount.TabIndex = 18;
            this.textbox_deposit_amount.TextChanged += new System.EventHandler(this.deposit_amount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Previous Balance: $";
            // 
            // button_deposit_make
            // 
            this.button_deposit_make.Enabled = false;
            this.button_deposit_make.Location = new System.Drawing.Point(552, 270);
            this.button_deposit_make.Name = "button_deposit_make";
            this.button_deposit_make.Size = new System.Drawing.Size(357, 111);
            this.button_deposit_make.TabIndex = 15;
            this.button_deposit_make.Text = "Deposit";
            this.button_deposit_make.UseVisualStyleBackColor = true;
            this.button_deposit_make.Click += new System.EventHandler(this.button3_Click);
            // 
            // listbox_deposit_select
            // 
            this.listbox_deposit_select.FormattingEnabled = true;
            this.listbox_deposit_select.Location = new System.Drawing.Point(238, 68);
            this.listbox_deposit_select.Name = "listbox_deposit_select";
            this.listbox_deposit_select.Size = new System.Drawing.Size(239, 186);
            this.listbox_deposit_select.TabIndex = 14;
            this.listbox_deposit_select.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tab_transfer_money
            // 
            this.tab_transfer_money.Controls.Add(this.label13);
            this.tab_transfer_money.Controls.Add(this.textbox_transfer_rx_prev);
            this.tab_transfer_money.Controls.Add(this.textbox_transfer_rx_new);
            this.tab_transfer_money.Controls.Add(this.label15);
            this.tab_transfer_money.Controls.Add(this.label8);
            this.tab_transfer_money.Controls.Add(this.label16);
            this.tab_transfer_money.Controls.Add(this.textbox_transfer_amount);
            this.tab_transfer_money.Controls.Add(this.label10);
            this.tab_transfer_money.Controls.Add(this.listbox_transfer_recieving);
            this.tab_transfer_money.Controls.Add(this.label7);
            this.tab_transfer_money.Controls.Add(this.button3);
            this.tab_transfer_money.Controls.Add(this.textbox_transfer_sending_prev);
            this.tab_transfer_money.Controls.Add(this.textbox_transfer_sending_new);
            this.tab_transfer_money.Controls.Add(this.label9);
            this.tab_transfer_money.Controls.Add(this.button_transfer_make);
            this.tab_transfer_money.Controls.Add(this.listbox_transfer_sending);
            this.tab_transfer_money.Location = new System.Drawing.Point(4, 4);
            this.tab_transfer_money.Name = "tab_transfer_money";
            this.tab_transfer_money.Padding = new System.Windows.Forms.Padding(3);
            this.tab_transfer_money.Size = new System.Drawing.Size(1057, 479);
            this.tab_transfer_money.TabIndex = 5;
            this.tab_transfer_money.Text = "Transfer Funds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(405, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 26);
            this.label13.TabIndex = 45;
            this.label13.Text = "New: $";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textbox_transfer_rx_prev
            // 
            this.textbox_transfer_rx_prev.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_transfer_rx_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_transfer_rx_prev.Location = new System.Drawing.Point(491, 297);
            this.textbox_transfer_rx_prev.Name = "textbox_transfer_rx_prev";
            this.textbox_transfer_rx_prev.ReadOnly = true;
            this.textbox_transfer_rx_prev.Size = new System.Drawing.Size(150, 32);
            this.textbox_transfer_rx_prev.TabIndex = 44;
            // 
            // textbox_transfer_rx_new
            // 
            this.textbox_transfer_rx_new.Enabled = false;
            this.textbox_transfer_rx_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_transfer_rx_new.Location = new System.Drawing.Point(491, 345);
            this.textbox_transfer_rx_new.Name = "textbox_transfer_rx_new";
            this.textbox_transfer_rx_new.ReadOnly = true;
            this.textbox_transfer_rx_new.Size = new System.Drawing.Size(150, 32);
            this.textbox_transfer_rx_new.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(364, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 26);
            this.label15.TabIndex = 42;
            this.label15.Text = "Previous: $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "New: $";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(683, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 26);
            this.label16.TabIndex = 40;
            this.label16.Text = "Transfer Amount: $";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textbox_transfer_amount
            // 
            this.textbox_transfer_amount.Enabled = false;
            this.textbox_transfer_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_transfer_amount.Location = new System.Drawing.Point(881, 75);
            this.textbox_transfer_amount.Name = "textbox_transfer_amount";
            this.textbox_transfer_amount.Size = new System.Drawing.Size(150, 32);
            this.textbox_transfer_amount.TabIndex = 39;
            this.textbox_transfer_amount.TextChanged += new System.EventHandler(this.textbox_transfer_amount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(397, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 26);
            this.label10.TabIndex = 38;
            this.label10.Text = "Recieving Account";
            // 
            // listbox_transfer_recieving
            // 
            this.listbox_transfer_recieving.Enabled = false;
            this.listbox_transfer_recieving.FormattingEnabled = true;
            this.listbox_transfer_recieving.Location = new System.Drawing.Point(402, 75);
            this.listbox_transfer_recieving.Name = "listbox_transfer_recieving";
            this.listbox_transfer_recieving.Size = new System.Drawing.Size(239, 186);
            this.listbox_transfer_recieving.TabIndex = 37;
            this.listbox_transfer_recieving.SelectedIndexChanged += new System.EventHandler(this.ListboxTransferSelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(97, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sending Account";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(797, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 98);
            this.button3.TabIndex = 29;
            this.button3.Text = "Return to Main Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.return_to_main);
            // 
            // textbox_transfer_sending_prev
            // 
            this.textbox_transfer_sending_prev.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_transfer_sending_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_transfer_sending_prev.Location = new System.Drawing.Point(159, 300);
            this.textbox_transfer_sending_prev.Name = "textbox_transfer_sending_prev";
            this.textbox_transfer_sending_prev.ReadOnly = true;
            this.textbox_transfer_sending_prev.Size = new System.Drawing.Size(150, 32);
            this.textbox_transfer_sending_prev.TabIndex = 28;
            // 
            // textbox_transfer_sending_new
            // 
            this.textbox_transfer_sending_new.Enabled = false;
            this.textbox_transfer_sending_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textbox_transfer_sending_new.Location = new System.Drawing.Point(159, 348);
            this.textbox_transfer_sending_new.Name = "textbox_transfer_sending_new";
            this.textbox_transfer_sending_new.ReadOnly = true;
            this.textbox_transfer_sending_new.Size = new System.Drawing.Size(150, 32);
            this.textbox_transfer_sending_new.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "Previous: $";
            // 
            // button_transfer_make
            // 
            this.button_transfer_make.Enabled = false;
            this.button_transfer_make.Location = new System.Drawing.Point(797, 171);
            this.button_transfer_make.Name = "button_transfer_make";
            this.button_transfer_make.Size = new System.Drawing.Size(234, 99);
            this.button_transfer_make.TabIndex = 24;
            this.button_transfer_make.Text = "Make Transfer";
            this.button_transfer_make.UseVisualStyleBackColor = true;
            this.button_transfer_make.Click += new System.EventHandler(this.ButtonTransferMakeClick);
            // 
            // listbox_transfer_sending
            // 
            this.listbox_transfer_sending.FormattingEnabled = true;
            this.listbox_transfer_sending.Location = new System.Drawing.Point(70, 75);
            this.listbox_transfer_sending.Name = "listbox_transfer_sending";
            this.listbox_transfer_sending.Size = new System.Drawing.Size(239, 186);
            this.listbox_transfer_sending.TabIndex = 23;
            this.listbox_transfer_sending.SelectedIndexChanged += new System.EventHandler(this.listbox_transfer_sending_SelectedIndexChanged);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.button_exit_program);
            this.panel_login.Controls.Add(this.textbox_pin);
            this.panel_login.Controls.Add(this.textbox_account_number);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Location = new System.Drawing.Point(12, 84);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(1100, 614);
            this.panel_login.TabIndex = 7;
            // 
            // button_exit_program
            // 
            this.button_exit_program.Location = new System.Drawing.Point(26, 499);
            this.button_exit_program.Name = "button_exit_program";
            this.button_exit_program.Size = new System.Drawing.Size(127, 96);
            this.button_exit_program.TabIndex = 7;
            this.button_exit_program.Text = "Exit";
            this.button_exit_program.UseVisualStyleBackColor = true;
            this.button_exit_program.Click += new System.EventHandler(this.button_exit_program_Click);
            // 
            // textbox_pin
            // 
            this.textbox_pin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_pin.Location = new System.Drawing.Point(170, 283);
            this.textbox_pin.Name = "textbox_pin";
            this.textbox_pin.PasswordChar = '*';
            this.textbox_pin.Size = new System.Drawing.Size(225, 20);
            this.textbox_pin.TabIndex = 3;
            this.textbox_pin.Text = "abcd";
            this.textbox_pin.TextChanged += new System.EventHandler(this.textbox_pin_TextChanged);
            // 
            // textbox_account_number
            // 
            this.textbox_account_number.Location = new System.Drawing.Point(170, 235);
            this.textbox_account_number.Name = "textbox_account_number";
            this.textbox_account_number.Size = new System.Drawing.Size(225, 20);
            this.textbox_account_number.TabIndex = 2;
            this.textbox_account_number.Text = "921203";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(528, 222);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(205, 99);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(111, 132);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(477, 46);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Enter Account ID and PIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 710);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_main_menu);
            this.Controls.Add(this.panel_login);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.panel_main_menu.ResumeLayout(false);
            this.tabcontrol_main.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_view_balance.ResumeLayout(false);
            this.tab_view_balance.PerformLayout();
            this.tab_withdraw_money.ResumeLayout(false);
            this.tab_withdraw_money.PerformLayout();
            this.tab_deposit_money.ResumeLayout(false);
            this.tab_deposit_money.PerformLayout();
            this.tab_transfer_money.ResumeLayout(false);
            this.tab_transfer_money.PerformLayout();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main_menu;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label btn_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textbox_pin;
        private System.Windows.Forms.TextBox textbox_account_number;
        private System.Windows.Forms.TabControl tabcontrol_main;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.Button main_logout;
        private System.Windows.Forms.Button main_transfer;
        private System.Windows.Forms.Button main_deposit;
        private System.Windows.Forms.Button main_withdraw;
        private System.Windows.Forms.Button main_viewbalance;
        private System.Windows.Forms.TabPage tab_view_balance;
        private System.Windows.Forms.TabPage tab_withdraw_money;
        private System.Windows.Forms.TabPage tab_deposit_money;
        private System.Windows.Forms.TabPage tab_transfer_money;
        private System.Windows.Forms.TextBox textbox_deposit_balance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_deposit_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_deposit_make;
        private System.Windows.Forms.ListBox listbox_deposit_select;
        private System.Windows.Forms.Button button_deposit_main_menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textbox_withdraw_previous;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_withdraw_amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_withdraw_make;
        private System.Windows.Forms.ListBox listbox_withdraw_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_viewbalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listbox_viewbalance_selectaccount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textbox_transfer_amount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listbox_transfer_recieving;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textbox_transfer_sending_prev;
        private System.Windows.Forms.TextBox textbox_transfer_sending_new;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_transfer_make;
        private System.Windows.Forms.ListBox listbox_transfer_sending;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textbox_transfer_rx_prev;
        private System.Windows.Forms.TextBox textbox_transfer_rx_new;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_exit_program;
    }
}

