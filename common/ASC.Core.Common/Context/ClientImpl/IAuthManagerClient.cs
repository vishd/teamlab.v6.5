using System;
using ASC.Common.Security.Authentication;

namespace ASC.Core
{
    public interface IAuthManagerClient
    {
        IUserAccount[] GetUserAccounts();

        IAccount GetAccountByID(Guid id);

        string GetUserPasswordHash(Guid userID);

        void SetUserPassword(Guid userID, string password);
    }
}