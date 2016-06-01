using System.Windows.Forms;

namespace Lync.WinForms.Controls
{
    public partial class PresenceIndicator : UserControl
    {
        private readonly Microsoft.Lync.Controls.PresenceIndicator presenceIndicator;

        public PresenceIndicator()
        {
            InitializeComponent();

            presenceIndicator = new Microsoft.Lync.Controls.PresenceIndicator();
            elementHost.Child = presenceIndicator;
        }

        public string EmailAddress
        {
            get { return presenceIndicator.Source.ToString(); }
            set { presenceIndicator.Source = value; }
        }
    }
}
