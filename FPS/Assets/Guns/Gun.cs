using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    [SerializeField] int countingBullets = 12;
    [SerializeField] float time = 4;
    [SerializeField] float delay = 2;
    [SerializeField] GameObject Bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.black);
                Debug.Log($"Objeto atingido: {hit.collider.name}");
                if(hit.collider.CompareTag("Enemy"))
                {
                    Enemy.lifeEnemy--;
                }
           }
        }
    }

    void Shot()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
    }
}
