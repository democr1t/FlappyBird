using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollisionTracker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bird bird))
        {
            Time.timeScale = 0;
        }
    }
}
