using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardFunctions : MonoBehaviour
{
    public List<GameObject> MonsterDatabase;

    public Button NextCardButton;
    public Button PreviousCardButton;
    public Button SelectCardButton;
    public int i = 0;
    public int MonsterSelectTemp;

    public void Start()
    {
        Debug.Log("Do you want to spawn " + MonsterDatabase[i] + "? ");
        MonsterSelectTemp = i;
    }

    public void SetCard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextCard()
    {
        if (MonsterSelectTemp < 2 && MonsterSelectTemp >= 0) //sanity check
        {
            MonsterSelectTemp += 1; //increment
        }
        Debug.Log("Do you want to spawn " + MonsterDatabase[MonsterSelectTemp]);         
    }

    public void PreviousCard()
    {
        if (MonsterSelectTemp > 0) //sanity check
        {
            MonsterSelectTemp -= 1; //decrement
        }
        Debug.Log("Do you want to spawn " + MonsterDatabase[MonsterSelectTemp]);
    }

    public int MonsterSelection() //function to access data from other scripts
    {
        return MonsterSelectTemp;
    }
}
