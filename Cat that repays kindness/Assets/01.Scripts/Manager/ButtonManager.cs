using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    public void ButtonClick() {

        GameObject curBtn = EventSystem.current.currentSelectedGameObject;

        switch(curBtn.tag) {

            case "Button" : {

                Panel panel = curBtn.GetComponent<Panel>();

                foreach (PanelAtbt p in panel.panels)
                    PanelManager.instance.Move(p);
            }
            break;

            case "Item" : {

                
            }
            break;
        }
    }
}
