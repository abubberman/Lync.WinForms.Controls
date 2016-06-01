using System.Windows.Forms;

namespace Lync.WinForms.Controls.Demo
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();

            presenceIndicator.EmailAddress = @"your@emailaddress.com";
        }
    }
}
