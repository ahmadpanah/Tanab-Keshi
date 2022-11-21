using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour , IPointerDownHandler
{
    [SerializeField] public int pullValue = 10;
    public void OnPointerDown (PointerEventData eventData) {
        Debug.Log("Click");
        Debug.Log("Rope Value " + Rope.instance.ropeValue);
        Pull();
    }

    public void Pull() {
        Rope.instance.ropeValue += pullValue;
    }
}
