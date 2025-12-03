using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public float shootForce = 500f;   // сила выстрела
    private Rigidbody2D rb;
    private bool hasShot = false;     // чтобы выстрел был один раз

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Стреляем по нажатию пробела
        if (!hasShot && Input.GetKeyDown(KeyCode.Space))
        {
            // Направление силы: вниз (если мяч наверху)
            Vector2 direction = Vector2.down;

            rb.AddForce(direction * shootForce);
            hasShot = true;
        }
    }
}
