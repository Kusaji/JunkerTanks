using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float cameraHeight;

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(_player.transform.position.x, cameraHeight, _player.transform.position.z);
    }
}
