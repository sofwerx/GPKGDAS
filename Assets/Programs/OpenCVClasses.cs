using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[StructLayout(LayoutKind.Sequential, Size = 12)]
public struct CvCircle
{
    public int X, Y, Radius;
}
// Define the functions which can be called from the .dll.
internal static class OpenCVInterop
{
    [DllImport("OpenCVSample")]
    internal static extern int Init(ref int outCameraWidth, ref int outCameraHeight);

    [DllImport("OpenCVSample")]
    internal static extern int Close();

    [DllImport("OpenCVSample")]
    internal static extern int SetScale(int downscale);

    [DllImport("OpenCVSample")]
    internal unsafe static extern void Detect(CvCircle* outFaces, int maxOutFacesCount, ref int outDetectedFacesCount);

    [DllImport("OpenCVSample")]
    internal unsafe static extern void DrawImage(int height, int width, byte[] data);
}
public class OpenCVClasses : MonoBehaviour {

    private bool _ready;

    void Start()
    {
        _ready = true;
    }

    void OnApplicationQuit()
    {
        if (_ready)
        {
            OpenCVInterop.Close();
        }
    }

    void Update()
    {
        
    }
}
