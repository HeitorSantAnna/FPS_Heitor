using UnityEngine;

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
        if(Input.GetButtonDown("KeyCode.Space"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
    }
}
