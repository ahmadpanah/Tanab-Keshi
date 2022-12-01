using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rope : MonoBehaviour
{
    public static Rope instance;
    [SerializeField] public int ropeValue;

    [SerializeField] public Vector2 minMaxValue;
    [SerializeField] public Vector2 minMaxVerticalPos;


    public void Awake() {
        instance = this;
    }

    public void Update() {
        var pos = transform.position;
        var normalize = Mathf.InverseLerp(minMaxValue.x , minMaxValue.y, ropeValue);
        var newPos = Mathf.Lerp(minMaxVerticalPos.x, minMaxVerticalPos.y, normalize);
        var currentVerticalPos = Mathf.Lerp(transform.position.y , newPos , 0.1f);
        pos.y = currentVerticalPos;
        transform.position = pos;

        if (Mathf.Abs((Mathf.Abs(transform.position.y)) - Mathf.Abs(minMaxVerticalPos.y)) < 0.1f) {
            Debug.Log("Game Finished!");
            Time.timeScale = 0;
            SceneManager.LoadScene("Menu");
        }
    }
}
