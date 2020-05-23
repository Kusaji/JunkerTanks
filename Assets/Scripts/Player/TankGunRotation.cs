using UnityEngine;

public class TankGunRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var lookDirection = transform.position - hit.point;
            lookDirection.y = 90.0f;
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }

    }
}
