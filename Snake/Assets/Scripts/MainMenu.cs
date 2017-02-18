using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject levelSelect;
    public GameObject OffBTN;
    public GameObject OnBTN;
    public AudioSource audio;
    public GameObject Misc;
    private bool isOpen = false;

    public void Start()
    {
        bool flag = GameObject.FindGameObjectWithTag("Misc") != null;
        if (!flag)
        {
            GameObject.Instantiate(Misc);
            audio = GameObject.FindGameObjectWithTag("Misc").GetComponent<AudioSource>();
        }
        else
        {
            audio = GameObject.FindGameObjectWithTag("Misc").GetComponent<AudioSource>();
        }
    }

    public void PlayGame()
    {
        levelSelect.GetComponent<Animator>().Play("Show");
    }

    public void SettingsBTN()
    {
        if (isOpen)
        {
            CloseSettings();
            isOpen = false;
        }
        else
        {
            OpenSettings();
            isOpen = true;
        }
    }

    public void OpenSettings()
    {
        if (audio.volume == 0f)
        {
            OnBTN.SetActive(true);
            OffBTN.SetActive(false);
        }
        else
        {
            OnBTN.SetActive(false);
            OffBTN.SetActive(true);
        }
        menu.GetComponent<Animator>().Play("MenuOpen");
    }

    public void CloseSettings()
    {
        menu.GetComponent<Animator>().Play("MenuClose");
    }

    public void MusicOff()
    {
        audio.volume = 0f;
        OffBTN.SetActive(false);
        OnBTN.SetActive(true);
    }

    public void MusicOn()
    {
        audio.volume = 1f;
        OffBTN.SetActive(true);
        OnBTN.SetActive(false);
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void BackToMenu()
    {
        levelSelect.GetComponent<Animator>().Play("Hide");
    }
}
