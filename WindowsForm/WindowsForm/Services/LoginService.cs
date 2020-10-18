using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class LoginService
    {
        CredentialRepository credRepo;

        public LoginService()
        {
            credRepo = new CredentialRepository();
        }

        public Login LoginValidation(Login log)
        {
            return credRepo.Validation(log);
        }
    }
}
