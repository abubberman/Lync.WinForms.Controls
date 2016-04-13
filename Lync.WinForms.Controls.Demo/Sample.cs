using System.Windows.Forms;

namespace Lync.WinForms.Controls.Demo
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();

            presenceIndicator.PresenceIndicatorInstance.Source = @"your@emailaddress.com";
        }
    }
}
