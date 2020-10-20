using Agendamento.Models;

namespace Agendamento.Tests.Factory
{
    public static class ScheduleFactory
    {
        public static Schedule CreateSchedule(Client client){
            return new Schedule(client);
        }
    }
}