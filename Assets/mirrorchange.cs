using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorchange : MonoBehaviour
{
    public Material Clear;
    public Material Mirror;

    public void SetClear()
    {
        GetComponent<Renderer>().material = Clear;
    }
    public void SetMirror()
    {
        GetComponent<Renderer>().material = Mirror;
    }
}
