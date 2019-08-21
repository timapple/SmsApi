namespace SmsApi.DemoApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ApiCredentialsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectApiButton = new System.Windows.Forms.Button();
            this.ApiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ApiPasswordLabel = new System.Windows.Forms.Label();
            this.ApiUsernameTextBox = new System.Windows.Forms.TextBox();
            this.ApiUsernameLabel = new System.Windows.Forms.Label();
            this.ApiPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ApiPortLabel = new System.Windows.Forms.Label();
            this.ApiHostTextBox = new System.Windows.Forms.TextBox();
            this.ApiHostLabel = new System.Windows.Forms.Label();
            this.SendSmsGroupBox = new System.Windows.Forms.GroupBox();
            this.SendSmsSimComboBox = new System.Windows.Forms.ComboBox();
            this.SendSmsSimPortLabel = new System.Windows.Forms.Label();
            this.SendSmsButton = new System.Windows.Forms.Button();
            this.SendSmsContentTextBox = new System.Windows.Forms.TextBox();
            this.SendSmsContentLabel = new System.Windows.Forms.Label();
            this.SendSmsRecipientTextBox = new System.Windows.Forms.TextBox();
            this.SendSmsRecipientLabel = new System.Windows.Forms.Label();
            this.MessagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.InboxLabel = new System.Windows.Forms.Label();
            this.InboxDataGridView = new System.Windows.Forms.DataGridView();
            this.OutboxDataGridView = new System.Windows.Forms.DataGridView();
            this.OutboxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbox_RecipientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbox_SentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbox_ContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbox_StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbox_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutboxLabel = new System.Windows.Forms.Label();
            this.InboxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox_SimPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox_SenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox_ReceivedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox_ContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inbox_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApiCredentialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApiPortNumericUpDown)).BeginInit();
            this.SendSmsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesSplitContainer)).BeginInit();
            this.MessagesSplitContainer.Panel1.SuspendLayout();
            this.MessagesSplitContainer.Panel2.SuspendLayout();
            this.MessagesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InboxDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutboxDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApiCredentialsGroupBox
            // 
            this.ApiCredentialsGroupBox.Controls.Add(this.ConnectApiButton);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiPasswordTextBox);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiPasswordLabel);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiUsernameTextBox);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiUsernameLabel);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiPortNumericUpDown);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiPortLabel);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiHostTextBox);
            this.ApiCredentialsGroupBox.Controls.Add(this.ApiHostLabel);
            this.ApiCredentialsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ApiCredentialsGroupBox.Name = "ApiCredentialsGroupBox";
            this.ApiCredentialsGroupBox.Size = new System.Drawing.Size(404, 264);
            this.ApiCredentialsGroupBox.TabIndex = 0;
            this.ApiCredentialsGroupBox.TabStop = false;
            this.ApiCredentialsGroupBox.Text = "API Credentials";
            // 
            // ConnectApiButton
            // 
            this.ConnectApiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectApiButton.Location = new System.Drawing.Point(291, 217);
            this.ConnectApiButton.Name = "ConnectApiButton";
            this.ConnectApiButton.Size = new System.Drawing.Size(107, 41);
            this.ConnectApiButton.TabIndex = 8;
            this.ConnectApiButton.Text = "Connect";
            this.ConnectApiButton.UseVisualStyleBackColor = true;
            this.ConnectApiButton.Click += new System.EventHandler(this.ConnectApiButton_Click);
            // 
            // ApiPasswordTextBox
            // 
            this.ApiPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiPasswordTextBox.Location = new System.Drawing.Point(9, 186);
            this.ApiPasswordTextBox.Name = "ApiPasswordTextBox";
            this.ApiPasswordTextBox.Size = new System.Drawing.Size(389, 25);
            this.ApiPasswordTextBox.TabIndex = 7;
            this.ApiPasswordTextBox.Text = "apipass";
            this.ApiPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ApiPasswordLabel
            // 
            this.ApiPasswordLabel.AutoSize = true;
            this.ApiPasswordLabel.Location = new System.Drawing.Point(6, 166);
            this.ApiPasswordLabel.Name = "ApiPasswordLabel";
            this.ApiPasswordLabel.Size = new System.Drawing.Size(64, 17);
            this.ApiPasswordLabel.TabIndex = 6;
            this.ApiPasswordLabel.Text = "Password";
            // 
            // ApiUsernameTextBox
            // 
            this.ApiUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiUsernameTextBox.Location = new System.Drawing.Point(9, 138);
            this.ApiUsernameTextBox.Name = "ApiUsernameTextBox";
            this.ApiUsernameTextBox.Size = new System.Drawing.Size(389, 25);
            this.ApiUsernameTextBox.TabIndex = 5;
            this.ApiUsernameTextBox.Text = "apiuser";
            // 
            // ApiUsernameLabel
            // 
            this.ApiUsernameLabel.AutoSize = true;
            this.ApiUsernameLabel.Location = new System.Drawing.Point(6, 118);
            this.ApiUsernameLabel.Name = "ApiUsernameLabel";
            this.ApiUsernameLabel.Size = new System.Drawing.Size(67, 17);
            this.ApiUsernameLabel.TabIndex = 4;
            this.ApiUsernameLabel.Text = "Username";
            // 
            // ApiPortNumericUpDown
            // 
            this.ApiPortNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiPortNumericUpDown.Location = new System.Drawing.Point(9, 90);
            this.ApiPortNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ApiPortNumericUpDown.Name = "ApiPortNumericUpDown";
            this.ApiPortNumericUpDown.Size = new System.Drawing.Size(389, 25);
            this.ApiPortNumericUpDown.TabIndex = 3;
            this.ApiPortNumericUpDown.Value = new decimal(new int[] {
            5038,
            0,
            0,
            0});
            // 
            // ApiPortLabel
            // 
            this.ApiPortLabel.AutoSize = true;
            this.ApiPortLabel.Location = new System.Drawing.Point(6, 69);
            this.ApiPortLabel.Name = "ApiPortLabel";
            this.ApiPortLabel.Size = new System.Drawing.Size(32, 17);
            this.ApiPortLabel.TabIndex = 2;
            this.ApiPortLabel.Text = "Port";
            // 
            // ApiHostTextBox
            // 
            this.ApiHostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApiHostTextBox.Location = new System.Drawing.Point(9, 41);
            this.ApiHostTextBox.Name = "ApiHostTextBox";
            this.ApiHostTextBox.Size = new System.Drawing.Size(389, 25);
            this.ApiHostTextBox.TabIndex = 1;
            this.ApiHostTextBox.Text = "192.168.5.150";
            // 
            // ApiHostLabel
            // 
            this.ApiHostLabel.AutoSize = true;
            this.ApiHostLabel.Location = new System.Drawing.Point(6, 21);
            this.ApiHostLabel.Name = "ApiHostLabel";
            this.ApiHostLabel.Size = new System.Drawing.Size(35, 17);
            this.ApiHostLabel.TabIndex = 0;
            this.ApiHostLabel.Text = "Host";
            // 
            // SendSmsGroupBox
            // 
            this.SendSmsGroupBox.Controls.Add(this.SendSmsSimComboBox);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsSimPortLabel);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsButton);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsContentTextBox);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsContentLabel);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsRecipientTextBox);
            this.SendSmsGroupBox.Controls.Add(this.SendSmsRecipientLabel);
            this.SendSmsGroupBox.Enabled = false;
            this.SendSmsGroupBox.Location = new System.Drawing.Point(12, 282);
            this.SendSmsGroupBox.Name = "SendSmsGroupBox";
            this.SendSmsGroupBox.Size = new System.Drawing.Size(404, 310);
            this.SendSmsGroupBox.TabIndex = 1;
            this.SendSmsGroupBox.TabStop = false;
            this.SendSmsGroupBox.Text = "Send SMS";
            // 
            // SendSmsSimComboBox
            // 
            this.SendSmsSimComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendSmsSimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendSmsSimComboBox.FormattingEnabled = true;
            this.SendSmsSimComboBox.Location = new System.Drawing.Point(9, 232);
            this.SendSmsSimComboBox.Name = "SendSmsSimComboBox";
            this.SendSmsSimComboBox.Size = new System.Drawing.Size(389, 25);
            this.SendSmsSimComboBox.TabIndex = 2;
            // 
            // SendSmsSimPortLabel
            // 
            this.SendSmsSimPortLabel.AutoSize = true;
            this.SendSmsSimPortLabel.Location = new System.Drawing.Point(6, 212);
            this.SendSmsSimPortLabel.Name = "SendSmsSimPortLabel";
            this.SendSmsSimPortLabel.Size = new System.Drawing.Size(57, 17);
            this.SendSmsSimPortLabel.TabIndex = 10;
            this.SendSmsSimPortLabel.Text = "Sim Port";
            // 
            // SendSmsButton
            // 
            this.SendSmsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendSmsButton.Location = new System.Drawing.Point(291, 263);
            this.SendSmsButton.Name = "SendSmsButton";
            this.SendSmsButton.Size = new System.Drawing.Size(107, 41);
            this.SendSmsButton.TabIndex = 3;
            this.SendSmsButton.Text = "Send";
            this.SendSmsButton.UseVisualStyleBackColor = true;
            this.SendSmsButton.Click += new System.EventHandler(this.SendSmsButton_Click);
            // 
            // SendSmsContentTextBox
            // 
            this.SendSmsContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendSmsContentTextBox.Location = new System.Drawing.Point(9, 90);
            this.SendSmsContentTextBox.Multiline = true;
            this.SendSmsContentTextBox.Name = "SendSmsContentTextBox";
            this.SendSmsContentTextBox.Size = new System.Drawing.Size(389, 119);
            this.SendSmsContentTextBox.TabIndex = 1;
            // 
            // SendSmsContentLabel
            // 
            this.SendSmsContentLabel.AutoSize = true;
            this.SendSmsContentLabel.Location = new System.Drawing.Point(6, 69);
            this.SendSmsContentLabel.Name = "SendSmsContentLabel";
            this.SendSmsContentLabel.Size = new System.Drawing.Size(53, 17);
            this.SendSmsContentLabel.TabIndex = 3;
            this.SendSmsContentLabel.Text = "Content";
            // 
            // SendSmsRecipientTextBox
            // 
            this.SendSmsRecipientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendSmsRecipientTextBox.Location = new System.Drawing.Point(9, 41);
            this.SendSmsRecipientTextBox.Name = "SendSmsRecipientTextBox";
            this.SendSmsRecipientTextBox.Size = new System.Drawing.Size(389, 25);
            this.SendSmsRecipientTextBox.TabIndex = 0;
            // 
            // SendSmsRecipientLabel
            // 
            this.SendSmsRecipientLabel.AutoSize = true;
            this.SendSmsRecipientLabel.Location = new System.Drawing.Point(6, 21);
            this.SendSmsRecipientLabel.Name = "SendSmsRecipientLabel";
            this.SendSmsRecipientLabel.Size = new System.Drawing.Size(61, 17);
            this.SendSmsRecipientLabel.TabIndex = 1;
            this.SendSmsRecipientLabel.Text = "Recipient";
            // 
            // MessagesSplitContainer
            // 
            this.MessagesSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesSplitContainer.Location = new System.Drawing.Point(422, 12);
            this.MessagesSplitContainer.Name = "MessagesSplitContainer";
            this.MessagesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MessagesSplitContainer.Panel1
            // 
            this.MessagesSplitContainer.Panel1.Controls.Add(this.InboxLabel);
            this.MessagesSplitContainer.Panel1.Controls.Add(this.InboxDataGridView);
            // 
            // MessagesSplitContainer.Panel2
            // 
            this.MessagesSplitContainer.Panel2.Controls.Add(this.OutboxDataGridView);
            this.MessagesSplitContainer.Panel2.Controls.Add(this.OutboxLabel);
            this.MessagesSplitContainer.Size = new System.Drawing.Size(695, 653);
            this.MessagesSplitContainer.SplitterDistance = 324;
            this.MessagesSplitContainer.TabIndex = 2;
            // 
            // InboxLabel
            // 
            this.InboxLabel.AutoSize = true;
            this.InboxLabel.Location = new System.Drawing.Point(-3, -3);
            this.InboxLabel.Name = "InboxLabel";
            this.InboxLabel.Size = new System.Drawing.Size(40, 17);
            this.InboxLabel.TabIndex = 1;
            this.InboxLabel.Text = "Inbox";
            // 
            // InboxDataGridView
            // 
            this.InboxDataGridView.AllowUserToAddRows = false;
            this.InboxDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InboxDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InboxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InboxDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.InboxDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InboxDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.InboxDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InboxDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InboxDataGridView.ColumnHeadersHeight = 40;
            this.InboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InboxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InboxColumn,
            this.Inbox_SimPortColumn,
            this.Inbox_SenderColumn,
            this.Inbox_ReceivedDateColumn,
            this.Inbox_ContentColumn,
            this.Inbox_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InboxDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.InboxDataGridView.EnableHeadersVisualStyles = false;
            this.InboxDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.InboxDataGridView.Location = new System.Drawing.Point(0, 17);
            this.InboxDataGridView.MultiSelect = false;
            this.InboxDataGridView.Name = "InboxDataGridView";
            this.InboxDataGridView.ReadOnly = true;
            this.InboxDataGridView.RowHeadersVisible = false;
            this.InboxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InboxDataGridView.Size = new System.Drawing.Size(695, 306);
            this.InboxDataGridView.TabIndex = 0;
            // 
            // OutboxDataGridView
            // 
            this.OutboxDataGridView.AllowUserToAddRows = false;
            this.OutboxDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OutboxDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.OutboxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutboxDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.OutboxDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutboxDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.OutboxDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutboxDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.OutboxDataGridView.ColumnHeadersHeight = 40;
            this.OutboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OutboxDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutboxColumn,
            this.Outbox_RecipientColumn,
            this.Outbox_SentDateColumn,
            this.Outbox_ContentColumn,
            this.Outbox_StatusColumn,
            this.Outbox_ExtraColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OutboxDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.OutboxDataGridView.EnableHeadersVisualStyles = false;
            this.OutboxDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OutboxDataGridView.Location = new System.Drawing.Point(0, 20);
            this.OutboxDataGridView.MultiSelect = false;
            this.OutboxDataGridView.Name = "OutboxDataGridView";
            this.OutboxDataGridView.ReadOnly = true;
            this.OutboxDataGridView.RowHeadersVisible = false;
            this.OutboxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutboxDataGridView.Size = new System.Drawing.Size(695, 305);
            this.OutboxDataGridView.TabIndex = 2;
            // 
            // OutboxColumn
            // 
            this.OutboxColumn.HeaderText = "";
            this.OutboxColumn.Name = "OutboxColumn";
            this.OutboxColumn.ReadOnly = true;
            this.OutboxColumn.Visible = false;
            // 
            // Outbox_RecipientColumn
            // 
            this.Outbox_RecipientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Outbox_RecipientColumn.HeaderText = "Recipient";
            this.Outbox_RecipientColumn.Name = "Outbox_RecipientColumn";
            this.Outbox_RecipientColumn.ReadOnly = true;
            this.Outbox_RecipientColumn.Width = 84;
            // 
            // Outbox_SentDateColumn
            // 
            this.Outbox_SentDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "MMMM d, yyyy HH:mm:ss";
            this.Outbox_SentDateColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.Outbox_SentDateColumn.HeaderText = "Sent Date";
            this.Outbox_SentDateColumn.Name = "Outbox_SentDateColumn";
            this.Outbox_SentDateColumn.ReadOnly = true;
            this.Outbox_SentDateColumn.Width = 80;
            // 
            // Outbox_ContentColumn
            // 
            this.Outbox_ContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Outbox_ContentColumn.HeaderText = "Content";
            this.Outbox_ContentColumn.Name = "Outbox_ContentColumn";
            this.Outbox_ContentColumn.ReadOnly = true;
            this.Outbox_ContentColumn.Width = 76;
            // 
            // Outbox_StatusColumn
            // 
            this.Outbox_StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Outbox_StatusColumn.HeaderText = "Status";
            this.Outbox_StatusColumn.Name = "Outbox_StatusColumn";
            this.Outbox_StatusColumn.ReadOnly = true;
            this.Outbox_StatusColumn.Width = 66;
            // 
            // Outbox_ExtraColumn
            // 
            this.Outbox_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Outbox_ExtraColumn.HeaderText = "";
            this.Outbox_ExtraColumn.Name = "Outbox_ExtraColumn";
            this.Outbox_ExtraColumn.ReadOnly = true;
            // 
            // OutboxLabel
            // 
            this.OutboxLabel.AutoSize = true;
            this.OutboxLabel.Location = new System.Drawing.Point(-3, 0);
            this.OutboxLabel.Name = "OutboxLabel";
            this.OutboxLabel.Size = new System.Drawing.Size(51, 17);
            this.OutboxLabel.TabIndex = 2;
            this.OutboxLabel.Text = "Outbox";
            // 
            // InboxColumn
            // 
            this.InboxColumn.HeaderText = "";
            this.InboxColumn.Name = "InboxColumn";
            this.InboxColumn.ReadOnly = true;
            this.InboxColumn.Visible = false;
            // 
            // Inbox_SimPortColumn
            // 
            this.Inbox_SimPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inbox_SimPortColumn.HeaderText = "Sim Port";
            this.Inbox_SimPortColumn.Name = "Inbox_SimPortColumn";
            this.Inbox_SimPortColumn.ReadOnly = true;
            this.Inbox_SimPortColumn.Width = 74;
            // 
            // Inbox_SenderColumn
            // 
            this.Inbox_SenderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inbox_SenderColumn.HeaderText = "Sender";
            this.Inbox_SenderColumn.Name = "Inbox_SenderColumn";
            this.Inbox_SenderColumn.ReadOnly = true;
            this.Inbox_SenderColumn.Width = 72;
            // 
            // Inbox_ReceivedDateColumn
            // 
            this.Inbox_ReceivedDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "MMMM d, yyyy HH:mm:ss";
            this.Inbox_ReceivedDateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Inbox_ReceivedDateColumn.HeaderText = "Received Date";
            this.Inbox_ReceivedDateColumn.Name = "Inbox_ReceivedDateColumn";
            this.Inbox_ReceivedDateColumn.ReadOnly = true;
            this.Inbox_ReceivedDateColumn.Width = 104;
            // 
            // Inbox_ContentColumn
            // 
            this.Inbox_ContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inbox_ContentColumn.HeaderText = "Content";
            this.Inbox_ContentColumn.Name = "Inbox_ContentColumn";
            this.Inbox_ContentColumn.ReadOnly = true;
            this.Inbox_ContentColumn.Width = 76;
            // 
            // Inbox_ExtraColumn
            // 
            this.Inbox_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inbox_ExtraColumn.HeaderText = "";
            this.Inbox_ExtraColumn.Name = "Inbox_ExtraColumn";
            this.Inbox_ExtraColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 677);
            this.Controls.Add(this.MessagesSplitContainer);
            this.Controls.Add(this.SendSmsGroupBox);
            this.Controls.Add(this.ApiCredentialsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS API (Demo)";
            this.ApiCredentialsGroupBox.ResumeLayout(false);
            this.ApiCredentialsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApiPortNumericUpDown)).EndInit();
            this.SendSmsGroupBox.ResumeLayout(false);
            this.SendSmsGroupBox.PerformLayout();
            this.MessagesSplitContainer.Panel1.ResumeLayout(false);
            this.MessagesSplitContainer.Panel1.PerformLayout();
            this.MessagesSplitContainer.Panel2.ResumeLayout(false);
            this.MessagesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesSplitContainer)).EndInit();
            this.MessagesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InboxDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutboxDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ApiCredentialsGroupBox;
        private System.Windows.Forms.Label ApiHostLabel;
        private System.Windows.Forms.TextBox ApiHostTextBox;
        private System.Windows.Forms.NumericUpDown ApiPortNumericUpDown;
        private System.Windows.Forms.Label ApiPortLabel;
        private System.Windows.Forms.TextBox ApiPasswordTextBox;
        private System.Windows.Forms.Label ApiPasswordLabel;
        private System.Windows.Forms.TextBox ApiUsernameTextBox;
        private System.Windows.Forms.Label ApiUsernameLabel;
        private System.Windows.Forms.Button ConnectApiButton;
        private System.Windows.Forms.GroupBox SendSmsGroupBox;
        private System.Windows.Forms.TextBox SendSmsRecipientTextBox;
        private System.Windows.Forms.Label SendSmsRecipientLabel;
        private System.Windows.Forms.TextBox SendSmsContentTextBox;
        private System.Windows.Forms.Label SendSmsContentLabel;
        private System.Windows.Forms.Button SendSmsButton;
        private System.Windows.Forms.SplitContainer MessagesSplitContainer;
        private System.Windows.Forms.Label InboxLabel;
        private System.Windows.Forms.DataGridView InboxDataGridView;
        private System.Windows.Forms.DataGridView OutboxDataGridView;
        private System.Windows.Forms.Label OutboxLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutboxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outbox_RecipientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outbox_SentDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outbox_ContentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outbox_StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outbox_ExtraColumn;
        private System.Windows.Forms.Label SendSmsSimPortLabel;
        private System.Windows.Forms.ComboBox SendSmsSimComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn InboxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox_SimPortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox_SenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox_ReceivedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox_ContentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox_ExtraColumn;
    }
}

