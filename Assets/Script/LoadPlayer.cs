using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour
{
    public GameObject[] player;
    public int curretPlayerIndex = 0;

    void Start()
    {
        curretPlayerIndex = PlayerPrefs.GetInt("SelectedPlayer", 0);
        foreach (GameObject Player in player)
            Player.SetActive(false);

        player[curretPlayerIndex].SetActive(true);
    }

    
}
