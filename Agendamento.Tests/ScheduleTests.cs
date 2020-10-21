using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agendamento.Models;
using Agendamento.Tests.Factory;

namespace Agendamento.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        
        [TestMethod]
        public void Dado_um_agendamento_sem_cliente_ele_deve_ser_invalido()
        {
            var _schedule = ScheduleFactory.CreateSchedule(null);
            _schedule.Validate();

            Assert.AreEqual(true, _schedule.Invalid);
        }
    }
}
