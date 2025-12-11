using UnityEngine;

public class Aim : MonoBehaviour
{
    void Update()
    {
        // positie van het gameobject (kanon) op het scherm
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);

        // richting tussen kanon en muis
        Vector3 dir = Input.mousePosition - pos;

        // hoek in graden
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        // roteer om de Z-as
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}


