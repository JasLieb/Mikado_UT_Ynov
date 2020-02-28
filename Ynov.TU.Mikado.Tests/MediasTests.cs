using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Ynov.TU.Mikado.Models;
using Ynov.TU.Mikado.Service;

namespace Ynov.TU.Mikado.Tests.Medias
{
    public class MediasTests
    {
        private MediaService _mediaService = new MediaService();

        [Fact]
        public void AddNewMedia_ShouldBeTrue()
        {
            var media = FakeMediaFactory.GetTotoBookMedia();
            var (result, errorOption) = 
                _mediaService
                .AddMedia(
                    media.name,
                    media.category
                );

            result
                .Should()
                .BeTrue();

            errorOption
                .HasValue
                .Should()
                .BeFalse();
        }

        [Fact]
        public void AddExistingMedia_ShouldBeFalse()
        {
            var media = FakeMediaFactory.GetTotoBookMedia();
            var (result, errorOption) =
                _mediaService
                .AddMedia(
                    media.name,
                    media.category
                );

            result
                .Should()
                .BeFalse();

            errorOption
                .HasValue
                .Should()
                .BeTrue();

            errorOption.MatchSome(
                error => error.Should().Equals("This media already exist in DB")
            );
        }

        [Fact]
        public void DeleteExistingMedia_ShouldBeTrue()
        {
            var id = FakeMediaFactory.GetTotoIdMedia();
            var (result, errorOption) = _mediaService.DeleteMedia(id);

            result
                .Should()
                .BeTrue();

            errorOption
                .HasValue
                .Should()
                .BeFalse();
        }

        [Fact]
        public void DeleteUnknownMedia_ShouldBeFalse()
        {
            var id = FakeMediaFactory.GetFakeMediaId();
            var (result, errorOption) = _mediaService.DeleteMedia(id);

            result
                .Should()
                .BeFalse();

            errorOption
                .HasValue
                .Should()
                .BeTrue();

            errorOption.MatchSome(
                error => error.Should().Equals("This id is unknow in DB")
            );
        }
    }
}