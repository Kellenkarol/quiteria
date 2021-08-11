using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Start() {
        ItemWithUI.OnUserAction += ItemWithUI_OnUserInput;
        ItemWithUI.OnClose += ItemWithUI_OnClose;
    }

    private void ItemWithUI_OnUserInput(GameObject UIGameObject) {
        Debug.Log(UIGameObject.activeSelf);
        UIGameObject.SetActive(!UIGameObject.activeSelf);
    }

    private void ItemWithUI_OnClose(GameObject UIGameObject) {
        UIGameObject.SetActive(false);
    }

    private void OnDestroy() {
        ItemWithUI.OnUserAction -= ItemWithUI_OnUserInput;
        ItemWithUI.OnClose -= ItemWithUI_OnClose;
    }
}
