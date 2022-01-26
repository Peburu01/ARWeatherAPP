using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{

    //Source JSON File
    public TextAsset JSONTXT;
    private string SouruceString;

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


    // Start is called before the first frame update
    void Start()
    {
        SouruceString = JSONTXT.ToString();
        WeatherData = JsonUtility.FromJson<WeatherList>(SouruceString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
