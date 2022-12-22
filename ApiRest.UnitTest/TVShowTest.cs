using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Takever.Domain.Entities;
using Takever.Infra.Data.Interfaces.Repositories;
using Takever.Service;
using Takever.Service.Interfaces;

namespace Takever.UnitTest
{
    [TestClass]
    public class TVShowTest
    {
        [TestMethod]
        public void GetTest_ReturnOK()
        {
            //ARRANGE
            TVShow tv1 = new TVShow()
            {
                Genre = TVShow.GenreTVShow.Romance,
                Name = "Movie 1",
                ReleaseDates = System.DateTime.Today.Date,
                Id = 1
            };

            IEnumerable<TVShow> results = new List<TVShow>() { tv1 };

            var RepositoryMock = new Mock<ITVShowRepository>();
            RepositoryMock.Setup(m => m.GetAll()).ReturnsAsync(results).Verifiable();

            ITVShowService _tvService = new TVShowService(RepositoryMock.Object);

            //ACT
            var actual = _tvService.GetAll().Result;

            //Assert
            RepositoryMock.Verify();
            Assert.IsNotNull(actual);//assert that a result was returned
            Assert.AreEqual(results.ToList()[0].Genre, actual.ToList()[0].Genre);
            Assert.AreEqual(results.ToList()[0].ReleaseDates, actual.ToList()[0].ReleaseDates);
            Assert.AreEqual(results.ToList()[0].Name, actual.ToList()[0].Name);
            Assert.AreEqual(results.ToList()[0].Id, actual.ToList()[0].Id);
        }

        [TestMethod]
        public void GetTest_ReturnNotFound()
        {
            //ARRANGE
            TVShow tv1 = null;

            IEnumerable<TVShow> results = new List<TVShow>() { tv1 };

            var RepositoryMock = new Mock<ITVShowRepository>();
            RepositoryMock.Setup(m => m.GetAll()).ReturnsAsync(results).Verifiable();

            ITVShowService _tvService = new TVShowService(RepositoryMock.Object);

            //ACT
            var actual = _tvService.GetAll().Result;

            //Assert
            RepositoryMock.Verify();
            Assert.IsNull(actual);//assert that a result was returned
        }
    }
}
