using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }

    public void EasyLevel() {
        SceneManager.LoadScene("Easy");
    }

    public void NormalLevel() {
        SceneManager.LoadScene("Normal");
    }

    public void HardLevel() {
        SceneManager.LoadScene("Hard");
    }

    public void Home() {
        SceneManager.LoadScene("Menu");
    }
}
