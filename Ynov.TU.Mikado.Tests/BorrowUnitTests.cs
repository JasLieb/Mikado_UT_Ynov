using System;
using Xunit;
using Ynov.TU.Mikado.Service;

namespace Ynov.TU.Mikado.Tests
{
    public class borrowUnitTests
    {
        /** Unit test method verifying nominal scenario for a user borrowing a media
         */
        [Fact]
        public void BorrowAMedia_ShouldReturnTrue(int userId, int idMedia)
        {

                var myService = new BorrowService(BorrowRepository);
                bool result = BorrowService.Create(userId, idMedia);
                Assert.True(result);
        }


        /** Unit test method verifying nominal scenario for a user borrowing a media
         *  he already borrowed 
         */
        [Fact]
        public void BorrowAlreadyBorrowedMedia_ShouldReturnFalse(int userId, int idMedia)
        {
            try
            {
                var myService = new BorrowService(BorrowRepository);
                bool result = BorrowService.Create(userId, idMedia);
                Assert.False(result);
            }
            catch (EntityException e)
            {
                throw e;
            }
        }
    }
}