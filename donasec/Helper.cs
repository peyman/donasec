using System.Security.Principal;

namespace donasec
{
    static class Helper
    {
        public static bool IsCurrentUserElevated()
        {
            WindowsIdentity userIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal user = new WindowsPrincipal(userIdentity);
            bool isUserAdmin = user.IsInRole(WindowsBuiltInRole.Administrator);
            return isUserAdmin;
        }


    }
}
