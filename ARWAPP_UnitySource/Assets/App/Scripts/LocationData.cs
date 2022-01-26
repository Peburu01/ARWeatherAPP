using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using UnityEngine;

public class LocationData : MonoBehaviour
{

    //Source File
    public string JSONSouruceString;
    public string IPString;

    //Location Details
    [System.Serializable]
    public class LocData{
        public string status;
        public string country;
        public string city;
        public float lat;
        public float lon;
    }

    //IP Details
    [System.Serializable]
    public class IPDetails{
        public string ip;
    }

    //Making this public so it can be viewed in the editor.
    public LocData locd = new LocData();
    public IPDetails ipstats = new IPDetails();

    public void GetLocationData()
    {

        DownloadLocationData();
        locd = JsonUtility.FromJson<LocData>(JSONSouruceString);

    }

    public void DownloadLocationData()
    {

        GetIPAddress();
        string requestUrl = "http://ip-api.com/json/" + ipstats.ip;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
        HttpWebResponse respone = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(respone.GetResponseStream());
        JSONSouruceString = reader.ReadToEnd();

    }

    public void GetIPAddress() {

        string requestUrl = "https://api.ipify.org?format=json";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
        HttpWebResponse respone = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(respone.GetResponseStream());
        IPString = reader.ReadToEnd();
        ipstats = JsonUtility.FromJson<IPDetails>(IPString);

    }

}
