using System;
using Xunit;

namespace Ynov.TU.Mikado.Tests
{
    public class userUnitTests
    {
        /** Unit test method verifying scenario when adding a user already existing
         * to user's repository
         */
        [Fact]
        public void AlreadyExistsUser_ShouldThrow_EntityException(String email,String password, bool isLibrarian)
        {
            try
            {
                var myService = new UserService(UserRepository);
                bool result = UserService.Create(email, password, isLibrarian);
                Assert.False(result);
            }
            catch (EntityException e)
            {
                throw e;
            }  
        }

        /** Unit test method verifying nominal scenario when adding a user to user's repository
         */
        [Fact]
        public void AddUser_UserAddMethodShouldReturnTrue(String email, String password, bool isLibrarian)
        {
            var myService = new UserService(UserRepository);
            Assert.isNotNull(email);
            Assert.isNotNull(password);
            Assert.isNotNull(isLibrarian);
            bool result = UserService.Create(email, password, isLibrarian);
            Assert.True(result);
        }
    }

    /** Unit test method verifying scenario login with invalid informations
         */
    [Fact]
    public void LoginInvalid_ShouldThrow_AuthenticationException(String email, String password)
    {
        try
        {
            var myService = new UserService(UserRepository);
            bool result = UserService.Login(email, password);
            Assert.False(result);
        }
        catch (AuthenticationException e)
        {
            throw e;
        }
    }

    /** Unit test method verifying nominal scenario for user login in app
     */
    [Fact]
    public void AddUser_UserAddMethodShouldReturnTrue(String email, String password)
    {
        var myService = new UserService(UserRepository);
        bool result = UserService.Login(email, password);
        Assert.True(result);
    }

}
