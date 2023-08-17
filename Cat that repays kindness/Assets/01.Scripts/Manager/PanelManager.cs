using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Video;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;

    [SerializeField] float duration;

    private void Awake() {
        
        if (instance)
            Destroy(instance);
        else
            instance = this;
    }
    
    public void Move(Panel panel) {

        Debug.Log("불러짐");

        panel.Obj.transform.DOMove(panel.End, duration).SetEase(Ease.OutExpo);

        // if (panel.SubObj != null)
        //     panel.SubObj.DOFade(0f, duration).SetEase(Ease.OutExpo);
        // material이 안 먹힌다...
    }
}
