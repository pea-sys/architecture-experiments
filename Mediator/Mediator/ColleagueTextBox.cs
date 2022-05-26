using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class ColleagueTextBox : TextBox, Colleague
    {
        private Mediator mediator;
        public ColleagueTextBox()
        {
            InitializeComponent();
        }

        void Colleague.SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
            this.BackColor = enabled ? Color.White : Color.LightGray;
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (mediator != null)
            {
                this.mediator.ColleagueChanged();
            }
                
        }
    }
}
