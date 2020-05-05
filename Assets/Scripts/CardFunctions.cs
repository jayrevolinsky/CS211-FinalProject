using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardFunctions : MonoBehaviour
{
    public Button NextCardButton;
    public Button PreviousCardButton;
    public Button SelectCardButton;

   public void SetCard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
