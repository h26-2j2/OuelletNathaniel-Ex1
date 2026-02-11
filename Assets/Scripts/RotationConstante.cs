using UnityEngine;

public class RotationConstante : MonoBehaviour
{
    public float vitesse;

    void Update()
    {
        transform.Rotate(0f, 0f, vitesse * Time.deltaTime);
    }
}
