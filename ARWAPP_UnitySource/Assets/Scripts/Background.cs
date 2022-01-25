using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public Camera MainCam;

    // Start is called before the first frame update
    void Start()
    {
        MainCam = Camera.main;
        MainCam.backgroundColor = new Color(1.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
