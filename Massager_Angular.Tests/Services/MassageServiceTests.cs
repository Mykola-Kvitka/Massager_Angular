using AutoFixture;
using NSubstitute;
using Messager_Angular.BLL.Interfaces;
using Messager_Angular.BLL.Services;
using Messager_Angular.DAL.Interfaces;
using Messager_Angular.DAL.Models;
using Messager_Angular.Tests.Mapping;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Messager_Angular.Tests
{
    public class MassageServiceTests
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMassageService _massageService;
        private readonly Fixture _fixture;

        public MassageServiceTests()
        {
            var mapper = MapperFactory.InitMapper();
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _massageService = new MassageService(_unitOfWork, mapper);
        }

        [Fact]
        public async Task Test1()
        {
            var some = _fixture.Build<MassageEntity>().With(item => item.Massage,"dsad").Create();
            var some1 = _fixture.Create<MassageEntity>();

            _unitOfWork.Massages.CreateAsync(Arg.Any<MassageEntity>()).Returns(some1);
        }
    }
}
