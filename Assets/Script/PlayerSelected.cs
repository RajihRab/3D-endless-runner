using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelected : MonoBehaviour
{
    public GameObject[] playerModels;
    public int curretPlayerIndex = 0;

    void Start()
    {
        curretPlayerIndex = PlayerPrefs.GetInt("SelectedPlayer", 0);
        foreach (GameObject Player in playerModels)
            Player.SetActive(false);

        playerModels[curretPlayerIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        playerModels[curretPlayerIndex].SetActive(false);

        curretPlayerIndex++;
        if (curretPlayerIndex == playerModels.Length)
            curretPlayerIndex = 0;

        playerModels[curretPlayerIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedPlayer", curretPlayerIndex);
    }

    public void back()
    {
        playerModels[curretPlayerIndex].SetActive(false);

        curretPlayerIndex--;
        if (curretPlayerIndex == -1)
            curretPlayerIndex = playerModels.Length -1;

        playerModels[curretPlayerIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedPlayer", curretPlayerIndex);
    }
    public void OK()
    {
        PlayerPrefs.SetInt("SelectedPlayer", curretPlayerIndex);
    }
}
