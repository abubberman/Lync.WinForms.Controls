
using System.Windows.Forms;

namespace Lync.WinForms.Controls
{
    public partial class PresenceIndicator : UserControl
    {
        public PresenceIndicator()
        {
            InitializeComponent();

            elementHost.Child = new Microsoft.Lync.Controls.PresenceIndicator();
        }

        public Microsoft.Lync.Controls.PresenceIndicator PresenceIndicatorInstance
        {
            get
            {
                return (Microsoft.Lync.Controls.PresenceIndicator)elementHost.Child;
            }
        }
    }
}
