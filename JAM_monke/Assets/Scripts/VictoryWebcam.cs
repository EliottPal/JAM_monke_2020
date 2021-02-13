using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryWebcam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture myWebcam = new WebCamTexture();
        Debug.Log(myWebcam.deviceName);

        Renderer camRenderer = GetComponent<Renderer>();
        camRenderer.material.mainTexture = myWebcam;
        myWebcam.Play();
    }
}
