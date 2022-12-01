using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour , IPointerDownHandler
{
    [SerializeField] public int pullValue = 10;
    [SerializeField] bool isAi;

    public void Start() {
        if (isAi) {
            StartCoroutine(AutoClick ());
        }
    }
    public void OnPointerDown (PointerEventData eventData) {

        if (isAi)
            return;
        Debug.Log("Click");
        Debug.Log("Rope Value " + Rope.instance.ropeValue);
        Pull();
    }

    public void Pull() {
        Rope.instance.ropeValue += pullValue;
    }

    IEnumerator AutoClick() {
        while(true) {
            Time.timeScale=1;
            var second = Random.Range(0.1f , 0.3f);
            yield return new WaitForSeconds(second);
            Pull();
        }
    }
}
