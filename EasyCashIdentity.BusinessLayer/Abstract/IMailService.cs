namespace EasyCashIdentity.BusinessLayer.Abstract
{
    public interface IMailService
    {
        void SendConfirmCodeToUser(string email, int confirmCode);
    }
}