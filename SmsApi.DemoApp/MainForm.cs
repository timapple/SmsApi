using System;
using System.Linq;
using System.Windows.Forms;

namespace SmsApi.DemoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApiPortNumericUpDown.Maximum = SmsApiClient.MAX_ALLOWED_PORT;
            SendSmsContentTextBox.MaxLength = SendObject.MAX_CONTENT_LENGTH;
            Text = $"{TITLE} [DISCONNECTED]";
        }

        private const string TITLE = "SMS API (Demo)";

        private SmsApiClient SmsApiClient { get; set; }

        private void ConnectApiButton_Click(object sender, EventArgs e)
        {
            SmsApiClient = new SmsApiClient(ApiHostTextBox.Text, decimal.ToInt32(ApiPortNumericUpDown.Value), ApiUsernameTextBox.Text, ApiPasswordTextBox.Text);
            UnregisterEvents();
            RegisterEvents();
            SmsApiClient.Open();
        }

        private void RegisterEvents()
        {
            if (SmsApiClient != null)
            {
                SmsApiClient.Connected += SmsApiClient_Connected;
                SmsApiClient.Disconnected += SmsApiClient_Disconnected;
                SmsApiClient.MessageReceived += SmsApiClient_MessageReceived;
                SmsApiClient.MessageSent += SmsApiClient_MessageSent;
                SmsApiClient.SentMessageUpdated += SmsApiClient_SentMessageUpdated;
                SmsApiClient.ExceptionCatched += SmsApiClient_ExceptionCatched;
            }
        }

        private void UnregisterEvents()
        {
            if (SmsApiClient != null)
            {
                SmsApiClient.Connected -= SmsApiClient_Connected;
                SmsApiClient.Disconnected -= SmsApiClient_Disconnected;
                SmsApiClient.MessageReceived -= SmsApiClient_MessageReceived;
                SmsApiClient.MessageSent -= SmsApiClient_MessageSent;
                SmsApiClient.SentMessageUpdated -= SmsApiClient_SentMessageUpdated;
                SmsApiClient.ExceptionCatched -= SmsApiClient_ExceptionCatched;
            }
        }

        private void SmsApiClient_Connected(object sender)
        {
            InvokeMainThread(() =>
            {
                SendSmsSimComboBox.Items.Clear();
                var sims = SmsApiClient.GetAvailableSims();

                if (sims != null)
                {
                    ApiCredentialsGroupBox.Enabled = false;
                    SendSmsGroupBox.Enabled = true;
                    SendSmsSimComboBox.Items.AddRange(sims.ToArray());
                    Text = $"{TITLE} [CONNECTED]";
                    MessageBox.Show("Sims loaded", "SMS API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Text = $"{TITLE} [NO SIM]";
                }
            });
        }

        private void SmsApiClient_Disconnected(object sender)
        {
            InvokeMainThread(() =>
            {
                ApiCredentialsGroupBox.Enabled = true;
                SendSmsGroupBox.Enabled = false;
                Text = $"{TITLE} [DISCONNECTED]";
                UnregisterEvents();
            });
        }

        private void SmsApiClient_MessageSent(object sender, SendObject sendObject)
        {
            var row = new DataGridViewRow
            {
                Height = 30
            };

            row.Cells.Add(new DataGridViewTextBoxCell { Value = sendObject.Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = sendObject.Recipient.Value });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = DateTime.Now });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = sendObject.Content });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "Sending" });
            OutboxDataGridView.Rows.Add(row);
        }

        private void SmsApiClient_SentMessageUpdated(object sender, SentObjectUpdate sentObjectUpdate)
        {
            foreach (DataGridViewRow row in OutboxDataGridView.Rows)
            {
                if (Equals(row.Cells[OutboxColumn.Name].Value, sentObjectUpdate.Id))
                {
                    row.Cells[Outbox_StatusColumn.Name].Value = sentObjectUpdate.Status ? "Sent" : "Failed";
                    OutboxDataGridView.Refresh();
                    break;
                }
            }
        }

        private void SmsApiClient_MessageReceived(object sender, ReceiveObject receiveObject)
        {
            var row = new DataGridViewRow
            {
                Height = 30
            };

            row.Cells.Add(new DataGridViewTextBoxCell { Value = receiveObject });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = receiveObject.SimPort });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = receiveObject.Sender.Value });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = receiveObject.ReceivedDate });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = receiveObject.Content });
            InboxDataGridView.Rows.Add(row);
        }

        private void SmsApiClient_ExceptionCatched(object sender, Exception exception)
        {
            MessageBox.Show(exception.Message, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SendSmsButton_Click(object sender, EventArgs e)
        {
            SendSmsContentTextBox.Text = Guid.NewGuid().ToString().ToUpper();

            if (SendSmsSimComboBox.SelectedItem is Sim sim)
            {
                SmsApiClient.Send(new SendObject(SendSmsRecipientTextBox.Text, SendSmsContentTextBox.Text), sim.Port);
            }
            else
            {
                MessageBox.Show("No selected sim", "Send SMS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SmsApiClient?.Close();
            UnregisterEvents();
            base.OnFormClosing(e);
        }

        private void InvokeMainThread(Action action)
        {
            Invoke(action);
        }
    }
}
