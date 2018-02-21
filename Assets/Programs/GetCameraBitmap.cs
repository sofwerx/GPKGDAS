using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCameraBitmap : MonoBehaviour {

    public RenderTexture overviewTexture;
    GameObject OVcamera;
    public string path = "";

    // Use this for initialization
    void Start () {
        OVcamera = GameObject.FindGameObjectWithTag("OverviewCamera");
    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(TakeScreenShot());
    }
    public IEnumerator TakeScreenShot()
    {
        yield return new WaitForEndOfFrame();
        Camera camOV = OVcamera.GetComponent<Camera>();

        //Debug.LogWarning(camOV);
        RenderTexture currentRT = RenderTexture.active;

        RenderTexture.active = camOV.targetTexture;
        //Debug.Log(camOV.targetTexture.width);
        //camOV.Render();
        Texture2D imageOverview = new Texture2D(camOV.targetTexture.width, camOV.targetTexture.height, TextureFormat.RGB24, false);
        imageOverview.ReadPixels(new Rect(0, 0, camOV.targetTexture.width, camOV.targetTexture.height), 0, 0);
        imageOverview.Apply();

        RenderTexture.active = currentRT;
        //Debug.Log(imageOverview.GetRawTextureData().Length);
        //(byte *) imageOverview.GetRawTextureData()
        OpenCVInterop.DrawImage(camOV.targetTexture.height, camOV.targetTexture.width, imageOverview.GetRawTextureData());
    }
}
