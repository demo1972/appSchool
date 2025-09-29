using Volo.Abp.Data;
using Volo.Abp.Identity;

namespace App.School.v3.Entities
{
    public static class IdentityUserExtensions
    {
        private const string CustomerIdProperty = "SchoolId";
        public static void SetUserSchoolId(this IdentityUser user, long customerId)
        {
            user.SetProperty(CustomerIdProperty, customerId);
        }
        public static int GetSchoolIdFromUSer(this IdentityUser user)
        {
            return user.GetProperty<int>(CustomerIdProperty);
        }
    }
}
