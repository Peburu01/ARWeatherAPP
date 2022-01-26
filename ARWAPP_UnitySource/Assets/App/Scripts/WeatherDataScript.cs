using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using UnityEngine;

public class WeatherDataScript : MonoBehaviour
{

    //Source File
    public string JSONSouruceString;
    public LocationData LocationData;

    //Main Weather Details
    [System.Serializable]
    public class WeatherList
    {
        public string name;
        public Weather[] weather;
        public Temprature main;
    }
    //Weather Data
    [System.Serializable]
    public class Weather
    {
        public int id;
        public string main;
        public string description;
    }
    //Temprature Data
    [System.Serializable]
    public class Temprature
    {
        public float temp;
        public float feels_like;
        public float temp_min;
        public float temp_max;
        public float pressure;
        public float humidity;
    }

    //Making this public so it can be viewed in the editor.
    public WeatherList WeatherData = new WeatherList();

    public void GetWeatherData() {

        DownloadWeatherData();
        WeatherData = JsonUtility.FromJson<WeatherList>(JSONSouruceString);

    }

    public void DownloadWeatherData() {

        string requestUrl = "http://api.openweathermap.org/data/2.5/weather?lat=" + LocationData.locd.lat + "&lon=" + LocationData.locd.lon + "&units=metric&appid=605fef9b9c1f491dfd9b6e9b2a207f5d";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
        HttpWebResponse respone = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(respone.GetResponseStream());
        JSONSouruceString = reader.ReadToEnd();

    }

}
