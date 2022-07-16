using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SettingsButtonScript : MonoBehaviour, IPointerEnterHandler
{
    public GameObject finger;
    public Button M;
    public Button S;
    void Start()
    {
        finger.SetActive(false);
        if (SoundManager.Music)
        {
            M.GetComponentInChildren<Text>().text = "Music: On"; 
        }
        else
        {
            M.GetComponentInChildren<Text>().text = "Music: Off";
        }
        if (SoundManager.Sound)
        {
            S.GetComponentInChildren<Text>().text = "Sound: On";
        }
        else
        {
            S.GetComponentInChildren<Text>().text = "Sound: Off";
        }
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {

        finger.SetActive(true);
        if (finger != null)
            finger.transform.position = new Vector3(transform.position.x - 150f, transform.position.y, transform.position.z);
    }


    public void OnMusicClick()
    {
        if (SoundManager.Music)
        {
            SoundManager.Music = false;
            M.GetComponentInChildren<Text>().text = "Music: Off";
        }
        else
        {
            SoundManager.Music = true;
            M.GetComponentInChildren<Text>().text = "Music: On";
        }
    }
    public void OnSoundClick()
    {
        if (SoundManager.Sound)
        {
            SoundManager.Sound = false;
            S.GetComponentInChildren<Text>().text = "Sound: Off";
        }
        else
        {
            SoundManager.Sound = true;
            S.GetComponentInChildren<Text>().text = "Sound: On";
        }
    }
}