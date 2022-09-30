using APIModels.DTOS.SignUp;

namespace APIApplication.Abstract
{
    public interface ISignUpService
    {
        public bool AddUser(RegisterDTO dto);
    }
}
