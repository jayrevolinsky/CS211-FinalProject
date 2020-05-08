using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Credit to Brackeys for helping build the foundation of this project
//https://www.youtube.com/playlist?list=PLPV2KyIb3jR4KLGCCAciWQ5qHudKtYeP7
//https://www.youtube.com/watch?v=tdSmKaJvCoA
//https://www.youtube.com/watch?v=n2DXF1ifUbU
public class NextFloor : MonoBehaviour
{
    #region FloorInstance
    public static NextFloor instance;

    void Awake()
    {
        instance = this;
    }
    #endregion
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
