using UnityEngine;

public class PlayerTankMovement : MonoBehaviour
{

    public float moveSpeed, rotateSpeed, turretDamping;

    public GameObject tankGun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //Forwards and Backwards

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.up * -moveSpeed * Time.deltaTime;
        }

        //Tank Body Rotation

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(transform.forward, rotateSpeed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(transform.forward, -rotateSpeed * Time.deltaTime, 0.0f);
        }
    }
}
