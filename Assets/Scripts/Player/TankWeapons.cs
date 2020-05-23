using System.Collections;
using UnityEngine;

public class TankWeapons : MonoBehaviour
{
    public Animator myAnimator;
    public float fireRate;
    public bool readyToFire;
    public GameObject turretProjectile, projectileSpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        readyToFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && readyToFire)
        {
            myAnimator.SetTrigger("MainTurretShoot");
            StartCoroutine(ShootTimer(fireRate));
        }
    }

    IEnumerator ShootTimer(float time)
    {
        readyToFire = false;
        Instantiate(turretProjectile, projectileSpawnPosition.transform.position, projectileSpawnPosition.transform.rotation);
        yield return new WaitForSeconds(time);
        readyToFire = true;
    }
}
