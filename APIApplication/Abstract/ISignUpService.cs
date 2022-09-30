using APIModels.DTOS.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIApplication.Abstract
{
    public interface ISignUpService
    {
        public bool AddUser(RegisterDTO dto);
    }
}
