using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllData : MonoBehaviour
{

    public LocationData LocationDATA;
    public WeatherDataScript WeatherDATA;

    private void Start()
    {
        
        //Getting the componets to start the data collection
        LocationDATA = GetComponent<LocationData>();
        WeatherDATA = GetComponent<WeatherDataScript>();
        WeatherDATA.LocationData = LocationDATA;

        //temp
        LocationDATA.GetLocationData();
        WeatherDATA.GetWeatherData();

    }



}
