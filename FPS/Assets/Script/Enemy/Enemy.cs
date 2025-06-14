using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] static public int lifeEnemy = 2;
    public TextMeshProUGUI lifeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = $"Life Enemy: {lifeEnemy}";
        if(lifeEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
