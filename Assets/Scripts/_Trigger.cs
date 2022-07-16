using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Trigger : MonoBehaviour
{
    public static string thisNpcName;

    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private Text AttacedText;

    void Update()
    {
        if (PlayerInSight())
        {
            Debug.Log("212");
            AttacedText.gameObject.SetActive(true);
        }


    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center,
            new Vector3(boxCollider.bounds.size.x, boxCollider.bounds.size.y, boxCollider.bounds.size.z),
            0, Vector2.left, 0, playerLayer);


        return hit.collider != null;
    }
}
