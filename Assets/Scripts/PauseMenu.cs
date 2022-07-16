using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button M;
    [SerializeField] private Button S;
    public Sprite MusicOn;
    public Sprite MusicOff;
    public Sprite SoundOn;
    public Sprite SoundOff;

    void Start()
    {
        if (SoundManager.Music)
        {
            M.GetComponentInChildren<Image>().sprite = MusicOn;
        }
        else
        {
            M.GetComponentInChildren<Image>().sprite = MusicOff;
        }
        if (SoundManager.Sound)
        {
            S.GetComponentInChildren<Image>().sprite = SoundOn;
        }
        else
        {
            S.GetComponentInChildren<Image>().sprite = SoundOff;
        }
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public void OnMusicClick()
    {
        if (SoundManager.Music)
        {
            SoundManager.Music = false;
            M.GetComponentInChildren<Image>().sprite = MusicOff;
        }
        else
        {
            SoundManager.Music = true;
            M.GetComponentInChildren<Image>().sprite = MusicOn;
        }
    }
    public void OnSoundClick()
    {
        if (SoundManager.Sound)
        {
            SoundManager.Sound = false;
            S.GetComponentInChildren<Image>().sprite = SoundOff;
        }
        else
        {
            SoundManager.Sound = true;
            S.GetComponentInChildren<Image>().sprite = SoundOn;
        }
    }
}
