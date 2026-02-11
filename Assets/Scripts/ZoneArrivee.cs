using UnityEngine;

public class ZoneArrivee : MonoBehaviour
{
    public Vector2 positionsPossibles;

    void Start()
    {
        Deplacer();
    }

    public void Deplacer()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(positionsPossibles.x, positionsPossibles.y));
    }
}
