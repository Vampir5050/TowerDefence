using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        ProccesHit();
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void ProccesHit()
    {
        hitPoints--;
    }


}
