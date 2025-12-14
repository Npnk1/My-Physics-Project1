using UnityEngine;

public class Peggle : MonoBehaviour
{
    [Header("Peggle Settings")]
    public int hitsToDestroy = 3;
    public int pointsPerHit = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // проверяем, что нас ударил шар
        if (!collision.collider.CompareTag("Ball")) return;

        Debug.Log("Peggle hit!");

        hitsToDestroy--;
        ScoreManager.Instance.AddScore(pointsPerHit);

        if (hitsToDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }
}

