using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceController : MonoBehaviour
{
    public List<Place> placeList;
    public GameObject placeCanvas;
    void Start()
    {
        var populator = new PlacePopulator();
        placeList = populator.GetPlacesList();
        //Debug.Log(placeList.Count);

        if (placeCanvas != null)
        {
            LoadPlace(placeList[1]);
        }
    }

    public void LoadPlace(Place place)
    {
        if (place == null)
        {
            //throw error
            return;
        }
        var placeUi = placeCanvas.GetComponent<PlaceUiController>();
        placeUi.UpdateVillageName(place.PlaceName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
