using UnityEngine;

public class ShootBall : MonoBehaviour
{
    [Header("Ball Settings")]
    [SerializeField] private GameObject prefab;      // Префаб шара
    [SerializeField] private float forceBuild = 25f; // Скорость набора силы
    [SerializeField] private float maximumHoldTime = 3f;

    [Header("Line Settings")]
    [SerializeField] private float lineSpeed = 8f;   // Скорость роста линии

    private float _pressTimer = 0f;
    private float _launchForce = 0f;

    private LineRenderer _line;
    private bool _lineActive = false;

    private void Start()
    {
        _line = GetComponent<LineRenderer>();

        // Скрываем линию в начале
        _line.SetPosition(0, Vector3.zero);
        _line.SetPosition(1, Vector3.zero);
    }

    private void Update()
    {
        HandleShot();
    }

    private void HandleShot()
    {
        // НАЖАЛИ ЛКМ — НАЧАЛИ ЗАРЯД
        if (Input.GetMouseButtonDown(0))
        {
            _pressTimer = 0f;
            _lineActive = true;
        }

        // ОТПУСТИЛИ ЛКМ — ВЫСТРЕЛ
        if (Input.GetMouseButtonUp(0))
        {
            _launchForce = _pressTimer * forceBuild;

            GameObject ball = Instantiate(prefab, transform.parent);
            ball.transform.position = transform.position;
            ball.transform.rotation = transform.rotation;

            Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;

            rb.AddForce(ball.transform.right * _launchForce, ForceMode2D.Impulse);

            _lineActive = false;
            _line.SetPosition(1, Vector3.zero);
        }

        // НАБОР СИЛЫ
        if (_pressTimer < maximumHoldTime && _lineActive)
        {
            _pressTimer += Time.deltaTime;
        }

        // РОСТ ЛИНИИ СИЛЫ
        if (_lineActive)
        {
            _line.SetPosition(1, Vector3.right * _pressTimer * lineSpeed);
        }
    }
}

