using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Ynov.TU.Mikado.Service;

namespace Ynov.TU.Mikado.Tests.Factories
{
    public class UserTests
    {
        private UserService _userServices = new UserService();

        [Fact]
        public void AddNewUser_ShouldBeTrue()
        {
            var user = FakeUserFactory.GetDummyUser();
            var result = _userServices.AddUser(user.email, user.password, user.isLibrarian);

            result
                .Should()
                .BeTrue();
        }

        [Fact]
        public void AddNewUser_AlreadyExists_ShouldBeFalse()
        {
            var user = FakeUserFactory.GetDummyUser();
            var result = _userServices.AddUser(user.email, user.password, user.isLibrarian);

            result
                .Should()
                .BeFalse();
        }

        [Fact]
        public void LoginUser_GoodCredentials_ShouldBeTrue()
        {
            var user = FakeUserFactory.GetDummyUser();
            var result = _userServices.login(user.email, user.password);

            result.Should().BeTrue();
        }

        [Fact]
        public void LoginUser_BadCredentials_ShouldBeFalse()
        {
            var user = FakeUserFactory.GetBadDummyUser();
            var result = _userServices.login(user.email, user.password);

            result.Should().BeFalse();
        }
    }
}
