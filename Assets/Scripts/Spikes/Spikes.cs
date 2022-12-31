using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    public HealthBar healthBar;

    public void DealDamage(int damage)
    {
        healthBar.Damaged(damage);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            DealDamage(this.damage);
        }
    }
}