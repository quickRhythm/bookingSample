﻿using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Absract
{
    public interface IGuestServis : IEntityRepository<Guest>
    {
    }
}
