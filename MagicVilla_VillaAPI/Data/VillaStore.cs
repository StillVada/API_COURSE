﻿using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id=1, Name="Pool View", Sqft=100, Occupancy=2},
                new VillaDTO{Id=2, Name="Beach View", Sqft=200, Occupancy=3}
            };
    }
}
