using System.Net.NetworkInformation;
using System.Security.Principal;

namespace SysInventory.Helper
{
    public class OSHelper
    {

        public static string GetSID()
        {
            string sid = WindowsIdentity.GetCurrent().User.ToString();
            return sid.Replace("-", "");
        }
    }
}
