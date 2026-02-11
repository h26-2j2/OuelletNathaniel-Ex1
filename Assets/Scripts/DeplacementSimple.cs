using UnityEngine;

public class DeplacementSimple : MonoBehaviour
{
    public Vector2 vitesse;
    public Vector2 amplitudes;
    float amplitude;

    void Start()
    {
        ChangerAmplitude();
    }

    void Update()
    {
        transform.position += new Vector3(vitesse.x, vitesse.y, 0f) * amplitude * Time.deltaTime;
    }

    public void ChangerAmplitude()
    {
        amplitude = Random.Range(amplitudes.x, amplitudes.y);
    }
}
