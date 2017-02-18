using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SettingsInGameScene : MonoBehaviour
{

    public AudioSource audio;
    public GameObject SettingsMenu;
    public GameObject OffBTN;
    public GameObject OnBTN;
    public GameObject Pause;
    public GameObject Continue;

    // Use this for initialization
    void Start ()
	{
	    audio = GameObject.FindGameObjectWithTag("Misc").GetComponent<AudioSource>();
	}

    public void PauseGame()
    {
        Pause.SetActive(false);
        Continue.SetActive(true);
        SettingsMenu.SetActive(true);
        Time.timeScale = 0.0f;
        if (audio.volume == 0)
        {
            OnBTN.SetActive(true);
            OffBTN.SetActive(false);
        }
        else
        {
            OnBTN.SetActive(false);
            OffBTN.SetActive(true);
        }
    }

    public void ContinueGame()
    {
        Pause.SetActive(true);
        Continue.SetActive(false);
        SettingsMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void MusicOn()
    {
        OnBTN.SetActive(false);
        OffBTN.SetActive(true);
        audio.volume = 1f;
    }

    public void MusicOff()
    {
        OnBTN.SetActive(true);
        OffBTN.SetActive(false);
        audio.volume = 0f;
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
