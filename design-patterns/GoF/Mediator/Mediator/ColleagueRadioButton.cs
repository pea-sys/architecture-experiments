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
    public partial class ColleagueRadioButton : RadioButton, Colleague
    {
        private Mediator mediator;
        public ColleagueRadioButton()
        {
            InitializeComponent();
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }
        protected override void OnCheckedChanged(EventArgs e)
        {
            if (mediator != null)
            {
                mediator.ColleagueChanged();
            }
        }
    }
}
