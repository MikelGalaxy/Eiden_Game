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
                PlaceSize = PlaceSize.Medium,
                BgImage = Resources.Load<Sprite>("SceensBgGraphics/village1"),
            },
            new Place
            {
                PlaceName = "Rogrok",
                PlaceType = PlaceType.Village,
                PlaceSize = PlaceSize.Small,
                BgImage = Resources.Load<Sprite>("SceensBgGraphics/village2"),
            },
            new Place
            {
                PlaceName = "Slamy",
                PlaceType = PlaceType.Village,
                PlaceSize = PlaceSize.Medium,
                BgImage = Resources.Load<Sprite>("SceensBgGraphics/village3"),
            },
        };
    }

    public List<Place> GetPlacesList()
    {
        return placeList;
    }
}
