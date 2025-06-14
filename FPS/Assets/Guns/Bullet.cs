using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 4f);
    }

    void Update()
    {
        transform.Translate(0, 0, 1);
    }
}
