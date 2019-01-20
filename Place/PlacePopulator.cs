using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Common.Enums;

public class PlacePopulator
{
    private List<Place> placeList;
    public PlacePopulator()
    {
        placeList = new List<Place>
        {
            new Place
            {
                PlaceName = "Gorwor",
                PlaceType = PlaceType.Village,
                PlaceSize = PlaceSize.Medium
            },
            new Place
            {
                PlaceName = "Rogrok",
                PlaceType = PlaceType.Village,
                PlaceSize = PlaceSize.Small
            },
        };
    }

    public List<Place> GetPlacesList()
    {
        return placeList;
    }
}
