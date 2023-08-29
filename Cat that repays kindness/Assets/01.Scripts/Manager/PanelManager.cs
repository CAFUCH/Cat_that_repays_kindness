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
    
    public void Move(PanelAtbt panel) {

        DOTween.KillAll();

        panel.Obj.GetComponent<RectTransform>().DOAnchorPos(panel.End, duration).SetEase(Ease.OutExpo);
    }
}
