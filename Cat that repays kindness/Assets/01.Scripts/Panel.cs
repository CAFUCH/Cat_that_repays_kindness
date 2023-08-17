using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    public GameObject Obj { get { return obj; }}

    [SerializeField] private Color subObj;
    public Color SubObj { get { return subObj; }}

    // [SerializeField] private float duration;
    // public float Duration { get { return duration; }}

    [SerializeField] private Vector3 end;
    public Vector3 End { get { return end; }}
}
