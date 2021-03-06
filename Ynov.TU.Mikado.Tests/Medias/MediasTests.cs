﻿using FluentAssertions;
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
        public void AddNewBookShouldBeTrue()
        {
            var media = FakeMediaFactory.GetTotoBook();
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
        public void AddExistingBookShouldBeFalse()
        {
            var media = FakeMediaFactory.GetTotoBook();
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
        public void DeleteExistingBookShouldBeTrue()
        {
            var (id, name, category) = FakeMediaFactory.GetTotoBookWithId();
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
        public void DeleteUnknownBookShouldBeFalse()
        {
            var id = FakeMediaFactory.GetFakeId();
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
