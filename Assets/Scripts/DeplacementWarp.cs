using UnityEngine;

public class DeplacementWarp : MonoBehaviour
{
    public Vector2 limites;
    public float positionDebut;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y <= limites.x || transform.position.y >= limites.y)
        {
            transform.position = new Vector3(transform.position.x, positionDebut, 0);
            GetComponent<DeplacementSimple>().ChangerAmplitude();
        }
    }
}
