using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherDataScript : MonoBehaviour
{

    //Source File
    public TextAsset JSONFile;
    public string JSONSouruceString;

    //Main Properties
    [System.Serializable]
    public class WeatherList
    {
        public string name;
        public Weather[] weather;
        public Temprature main;
    }

    //Making this public so it can be viewed in the editor.
    public WeatherList WeatherData = new WeatherList();

    //Sub Properties
    /*
     Weather Data
     */
    [System.Serializable]
    public class Weather {
        public int id;
        public string main;
        public string description;
    }
    /*
    Temprature Data
    */
    [System.Serializable]
    public class Temprature {
        public float temp;
        public float feels_like;
        public float temp_min;
        public float temp_max;
		public float pressure;
		public float humidity;
    }

    //temp
    private void Start()
    {
        GetWeatherData();
    }

    public void GetWeatherData() {

        JSONSouruceString = JSONFile.ToString();
        WeatherData = JsonUtility.FromJson<WeatherList>(JSONSouruceString);

    }

}
