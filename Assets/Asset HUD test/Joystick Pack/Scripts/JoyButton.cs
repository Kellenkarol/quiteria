using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector] protected bool Pressed;

    public GameObject background;
    
    void Start()
    {
        background.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        background.SetActive(true);
        //Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        background.SetActive(false);
        //Pressed = false;
    }
}
