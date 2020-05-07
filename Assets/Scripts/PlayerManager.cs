using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    #region PlayerInstance

    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    public void KillPlayer ()
    {
        //scene restart function
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
