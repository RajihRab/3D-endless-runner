using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] Player;
    public int selectedCharacter = 0;


    public void NextCharacter()
    {
        Player[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % Player.Length;
        Player[selectedCharacter].SetActive(true);

    }

    public void PreviousCharacter()
    {
        Player[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += Player.Length;
        }
        Player[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void OK()
    {
        PlayerPrefs.SetInt("seletedCharacter", selectedCharacter);
    }
}
