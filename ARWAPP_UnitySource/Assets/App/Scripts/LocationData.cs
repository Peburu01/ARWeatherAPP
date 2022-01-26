using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationData : MonoBehaviour
{

    //Source File
    public TextAsset JSONFile;
    public string JSONSouruceString;

    [System.Serializable]
    public class LocData{
        public string status;
        public string country;
        public string city;
        public float lat;
        public float lon;
    }

    public LocData locd = new LocData();

    //temp
    private void Start()
    {
        GetLocationData();
    }

    public void GetLocationData()
    {

        JSONSouruceString = JSONFile.ToString();
        locd = JsonUtility.FromJson<LocData>(JSONSouruceString);

    }


}
