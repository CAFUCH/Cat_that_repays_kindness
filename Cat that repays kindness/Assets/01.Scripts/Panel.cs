using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    public GameObject Obj { get { return obj; }}

    [SerializeField] private float speed;
    public float Speed { get { return speed; }}

    [SerializeField] private Vector3 dir;
    public Vector3 Dir { get { return dir; }}
}
