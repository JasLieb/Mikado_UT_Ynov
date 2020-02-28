using System;
using Xunit;

namespace Ynov.TU.Mikado.Tests
{
    public class favouriteUnitTests
    {
        /** Unit test method verifying nominal scenario for a user adding a media to his favourites
         */
        [Fact]
        public void AddToFavourite_ShouldReturnTrue(int userId, int idMedia)
        {

            var myService = new FavouriteService(FavouriteRepository);
            bool result = FavouriteService.Create(userId, idMedia);
            Assert.True(result);
        }


        /** Unit test method verifying scenario for a user adding a media
         *  to favourite but the media is already present
         */
        [Fact]
        public void AddToFavourite_AlreadyExistingFavourite_ShouldReturnFalse(int userId, int idMedia)
        {
            try
            {
                var myService = new FavouriteService(FavouriteRepository);
                bool result = FavouriteService.Create(userId, idMedia);
                Assert.False(result);
            }
            catch (EntityException e)
            {
                throw e;
            }
        }
    }
}