namespace Billing.App.Routes
{
    public class WebRoutes
    {
        public const string SignIn = "api/Sign/In";
        public const string SignUp = "api/Sign/Up";
        public const string Account = "api/Sign/Account";
        public const string ChangeRoles = "api/Sign/ChangeRoles/{id}";
        public const string ChangePassword = "api/Sign/ChangePassword";
        public const string ChangeUserInfo = "api/Sign/ChangeUserInfo/{id}";
        public const string Roles = "api/Sign/Roles";
        public const string UserRoles = "api/Sign/UserRoles/{userId}";
        public const string Download = "/Download/{folderName}/{fileName}";
        public const string ChangePreference = "api/Preferences/{prefName}";
    }
}