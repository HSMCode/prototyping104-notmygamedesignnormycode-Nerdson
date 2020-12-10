using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostLaughScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SoundScript.PlaySound2();
        }
    }
}
