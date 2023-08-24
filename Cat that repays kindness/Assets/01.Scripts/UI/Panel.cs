using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Panel : MonoBehaviour
{
    public List<PanelAtbt> panels;
}

[System.Serializable]
public class PanelAtbt {

    [SerializeField] private GameObject obj;
    public GameObject Obj { get { return obj; }}

    // [SerializeField] private Color subObj;
    // public Color SubObj { get { return subObj; }}

    [SerializeField] private Vector3 end;
    public Vector3 End { get { return end; }}

    // [SerializeField] private bool isPopup;
    // public bool IsPopup { get { return isPopup; }}
}
