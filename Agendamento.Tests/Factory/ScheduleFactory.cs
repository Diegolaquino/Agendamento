using Agendamento.Models;

namespace Agendamento.Tests.Factory
{
    public static class ScheduleFactory
    {
        public static Schedule CreateSchedule(){
            return new Schedule();
        }
    }
}