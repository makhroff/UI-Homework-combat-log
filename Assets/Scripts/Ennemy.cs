using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField] private float health = 10;
    [SerializeField] private string EnnemyID;
    private int currentWeapon;

    public killlogManager km;
    public WeaponSelect wp;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        if (wp.assaultrifleSelected)
        {
            currentWeapon = 0;
        }
        else
        {
            currentWeapon = 1;
        }
        km.InstantiateKillLog(EnnemyID, currentWeapon);
        Destroy(this.gameObject);
    }
}
