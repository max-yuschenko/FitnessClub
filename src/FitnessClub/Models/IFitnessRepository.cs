﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public interface IFitnessRepository
    {
        SeasonTicket GetSeasonTicket(ApplicationUser user);
    }
}
