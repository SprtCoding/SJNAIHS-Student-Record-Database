using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.Loaders
{
    public partial class FRM_Wait : Form
    {
        public Action myAction { get; set; }

        public FRM_Wait(Action action)
        {
            InitializeComponent();
            if (action == null)
            {
                throw new ArgumentNullException();
            }
            myAction = action;

            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(myAction).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
