
using System.Windows.Forms;

namespace Lync.WinForms.Controls
{
    public partial class PresenceIndicator : UserControl
    {
        public PresenceIndicator()
        {
            InitializeComponent();
        }

        public Microsoft.Lync.Controls.PresenceIndicator PresenceIndicatorInstance
        {
            get
            {
                return wpfPresenceIndicator.PresenceIndicatorInstance;
            }
        }
    }
}
