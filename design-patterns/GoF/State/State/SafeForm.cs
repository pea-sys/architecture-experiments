namespace State
{
    public partial class SafeForm : Form, Context
    {
        private State state = DayState.GetInstance();
        public SafeForm()
        {
            InitializeComponent();
        }

        public void CallSecurityCenter(string msg)
        {
            logTextBox.AppendText($"call!{msg}{Environment.NewLine}");
        }

        public void ChangeState(State state)
        {
            if (this.state == state)
            {
                return;
            }
            logTextBox.AppendText($"{this.state}Ç©ÇÁ{state}Ç÷èÛë‘Ç™ïœâªÇµÇ‹ÇµÇΩ{Environment.NewLine}");
            this.state = state;
        }

        public void ReccordLog(string msg)
        {
            logTextBox.AppendText($"record ... {msg}{Environment.NewLine}");
        }

        private void ActionPerformed(object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());
            if(sender.Equals(useButton))
            {
                state.DoUse(this);
            }
            else if(sender.Equals(alarmButton))
            {
                state.DoAlarm(this);
            }
            else if (sender.Equals(phoneButton))
            {
                state.DoPhone(this);
            }
            else if (sender.Equals(exitButton))
            {
                Application.Exit();
            }
            else
            {
                logTextBox.AppendText("?");
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            clockLabel.Text = $"åªç›éûçèÇÕ{t.ToShortTimeString()}";
            state.DoClock(this,t.Hour);
        }
    }
}