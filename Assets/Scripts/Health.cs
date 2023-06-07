using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField]  public int health = 100;

    private int MAX_HEALTH = 100;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }


    public void Damage(int damage)
    {
        if(damage < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
        }

        this.health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("I died");
        Destroy(gameObject);
    }
}
