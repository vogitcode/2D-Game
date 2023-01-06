using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    Collider2D swordCollider;
    Vector2 rightAttackOffset;

    private void Start()
    {
        swordCollider = GetComponent<Collider2D>();
        rightAttackOffset = transform.position;
    }

    public void AttackRight()
    {
        swordCollider.enabled = true;
        transform.position = rightAttackOffset;
    }

    public void AttackLeft()
    {
        swordCollider.enabled = true;
        transform.position = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Enemy")
        {

        }
    }
}
