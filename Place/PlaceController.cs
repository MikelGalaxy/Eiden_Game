using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceController : MonoBehaviour
{
    public List<Place> placeList;
    public GameObject placeCanvas;
    public SpriteRenderer placeBackground; 

    void Start()
    {
        var populator = new PlacePopulator();
        placeList = populator.GetPlacesList();
        //Debug.Log(placeList.Count);

        if (placeCanvas != null)
        {
            LoadPlace(placeList[2]);
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

        if(placeBackground && place.BgImage)
        {
            placeBackground.sprite = place.BgImage;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
