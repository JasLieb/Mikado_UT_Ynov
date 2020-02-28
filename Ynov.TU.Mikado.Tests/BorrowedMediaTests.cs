using FluentAssertions;
using Xunit;
using Ynov.TU.Mikado.Service;
using Ynov.TU.Mikado.Tests.Factories;
using Ynov.TU.Mikado.Tests.Medias;

namespace Ynov.TU.Mikado.Tests
{
    public class BorrowedMediaTests
    {
        private BorrowService _borrowService = new BorrowService();

        [Fact]
        public void CreateBorrowedMedia_AvailableMedia_ShouldBeTrue()
        {
            var userId = FakeUserFactory.GetDummyIdUser();
            var mediaId = FakeMediaFactory.GetTotoIdMedia();
            var result = _borrowService.BorrowMedia(userId, mediaId);

            result
                .Should()
                .BeTrue();
        }

        [Fact]
        public void CreateBorrowedMedia_NotAvailableMedia_ShouldBeFalse()
        {
            var userId = FakeUserFactory.GetDummyIdUser();
            var mediaId = FakeMediaFactory.GetTotoIdMedia();
            var result = _borrowService.BorrowMedia(userId, mediaId);

            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public void CreateBorrowedMedia_UserUnknown_ShouldBeFalse()
        {
            var userId = FakeUserFactory.GetFakeDummyId();
            var mediaId = FakeMediaFactory.GetTotoIdMedia();
            var result = _borrowService.BorrowMedia(userId, mediaId);

            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public void CreateBorrowedMedia_MediaUnknown_ShouldBeFalse()
        {
            var userId = FakeUserFactory.GetDummyIdUser();
            var mediaId = FakeMediaFactory.GetFakeMediaId();
            var result = _borrowService.BorrowMedia(userId, mediaId);

            result
                .Should()
                .BeFalse();
        }
    }
}
