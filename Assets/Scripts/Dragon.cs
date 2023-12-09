using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
    int HP = 100;
    bool isDead;
    Animator animator;
    public Slider healthBar;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        healthBar.value = HP;
    }
    public void TakeDamage(int damageAmount)
    {
        if (isDead) return;
        HP -= damageAmount;
        if (HP <= 0)
        {
            isDead = true;
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
}
