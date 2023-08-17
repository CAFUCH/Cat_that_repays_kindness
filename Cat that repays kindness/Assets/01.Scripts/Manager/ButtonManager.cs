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
                PanelManager.instance.Move(panel);
            }
            break;

            case "Item" : {

                
            }
            break;
        }
    }
}
