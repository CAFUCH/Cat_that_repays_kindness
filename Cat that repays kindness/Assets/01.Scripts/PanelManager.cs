using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;

    [SerializeField] float during;

    private void Awake() {
        
        if (instance)
            Destroy(instance);
        else
            instance = this;
    }
    
    public void Move(GameObject panel, GameObject bPanel) {

        Debug.Log("불러짐");

        panel.transform.DOMove(new Vector3(-1080, 0 , 0), during); // ?왜 지랄 정신차료~
        // bPanel.transform.DOMoveX(-1080, during * 2).SetEase(Ease.InExpo);
    }
}
