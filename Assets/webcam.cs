using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webcam : MonoBehaviour
{
    static WebCamTexture backcam;

    // Start is called before the first frame update
    void Start()
    {
        if (backcam == null)
            backcam = new WebCamTexture();

        GetComponent<RawImage>().texture = backcam;

        if (!backcam.isPlaying)
            backcam.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}