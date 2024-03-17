using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;

    public PlayerProgress playerProgress;
    
    public void DealDamage(float damage)
    {
        playerProgress.AddExperience(damage);
        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
