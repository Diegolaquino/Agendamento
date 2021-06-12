using Agendamento.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agendamento.Models.ViewModels
{
    public class ClientViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public EGender Gender { get; set; }
    }
}
