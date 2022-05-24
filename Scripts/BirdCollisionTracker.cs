using UnityEngine;

public class BirdCollisionTracker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bird bird))
        {
            bird.Die();
        }
    }
}
