using UnityEngine;

public class TargetCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit! Object: " + collision.gameObject.name);
    }
}
