using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Ynov.TU.Mikado.Models;

namespace Ynov.TU.Mikado.Tests.Medias
{
    public class MediasTests
    {
        private MediaService _mediaService = new MediaService();

        [Fact]
        public void AddWellFormedMediaShouldBeTrue()
        {
            var media = MediaHelper.GetWellformedMediaParameters();
            var result = 
                _mediaService
                .AddMedia(
                    media.name,
                    media.category
                );

            result
                .Should()
                .BeTrue();
        }

        [Fact]
        public void AddNotWellFormedMediaShouldBeTrue()
        {
            var media = MediaHelper.GetNotWellFormedMediaParameters();
            var result = _mediaService.AddMedia(media, null);
            result
                .Should()
                .BeFalse();
        }
    }
}
