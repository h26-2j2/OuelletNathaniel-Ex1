using UnityEngine;

public class ScaleFluxuation : MonoBehaviour
{
    public float amplitude = 1f;
    Vector3 tailleOriginale;
    float timeOffset;

    void Start()
    {
        tailleOriginale = transform.localScale;
        timeOffset = Random.Range(0f, 180f);
    }

    void Update()
    {
        transform.localScale = tailleOriginale * (((Mathf.Sin(Time.timeSinceLevelLoad + timeOffset) / 2) * amplitude) + 1.5f);
    }
}
