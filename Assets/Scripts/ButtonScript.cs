using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler
{
    public GameObject finger;
    void Start()
    {
        finger.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        finger.SetActive(true);
        if (finger != null)
            finger.transform.position = new Vector3(transform.position.x - 150f, transform.position.y, transform.position.z);
    }
}