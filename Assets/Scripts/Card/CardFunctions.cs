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

    public int MonsterSelectTemp;

   public void SetCard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public int NextCard(int j)
    {
        for (var i = 0; i < MonsterDatabase.Count; i++)
        {
            i = MonsterSelectTemp;
        }
        return MonsterSelectTemp;
        
    }

    public int PreviousCard(int j)
    {
        for (var i = 0; i < MonsterDatabase.Count; i--)
        {
            i = MonsterSelectTemp;
        }
        return MonsterSelectTemp;
        
    }

    public int MonsterSelection()
    {
        return MonsterSelectTemp;
    }
}
