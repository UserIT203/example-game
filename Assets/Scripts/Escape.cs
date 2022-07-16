using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject DialogPanel;
    // Start is called before the first frame update
    public void RunAway()
    {
        player.transform.position = new Vector3(player.transform.position.x - 1.7f, player.transform.position.y, player.transform.position.z);
        Time.timeScale = 1;
        DialogPanel.SetActive(false);
    }
    
}
