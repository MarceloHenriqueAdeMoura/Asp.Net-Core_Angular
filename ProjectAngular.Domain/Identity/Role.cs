using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProjectAngular.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}