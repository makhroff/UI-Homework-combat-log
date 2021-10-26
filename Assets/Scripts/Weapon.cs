using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    [Header("Weapon Settings")]

    [SerializeField] private Camera cam;
    [SerializeField] private float damage;
    [SerializeField] private float range;
    [SerializeField] private float fireRate = 0.1f; // 1f = 1second

    private float _nextTimeToFire = 0f;

    private void Update()
    {
        if (Input.GetButton("Fire1"))
            Shoot();
    }
    public void Shoot()
    {
        if (Time.time >= _nextTimeToFire)
        {
            _nextTimeToFire = Time.time + fireRate;

            RaycastHit hit;
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Ennemy ennemy = hit.transform.GetComponent<Ennemy>();
                if(ennemy != null)
                {
                    ennemy.TakeDamage(damage);
                }
            }
        }
    }
}
