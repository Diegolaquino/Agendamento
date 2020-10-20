using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agendamento.Models;
using Agendamento.Tests.Factory;

namespace Agendamento.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        
        [TestMethod]
        public void ShouldReturnErrorWhenScheduleHasNoClient()
        {
            var _schedule = ScheduleFactory.CreateSchedule();

            Assert.True();
        }
    }
}
