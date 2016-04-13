using Microsoft.Lync.Model;

namespace Lync.WinForms.Controls
{
    public static class LyncInstanceDetector
    {
        public static bool IsAvailable
        {
            get
            {
                try
                {
                    LyncClient.GetClient();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
        }
    }
}
