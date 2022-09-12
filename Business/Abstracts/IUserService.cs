using Common.Models.ViewModels.Users;
using Common.Utilities.Abstracts;
using Common.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<AuthResult> LoginAsync(LoginViewModel requestModel);
    }
}
