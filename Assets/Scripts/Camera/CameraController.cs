using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static Camera m_Camera;
    public GameObject camera;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = new Vector3(player.transform.position.x, player.transform.position.y + 5, player.transform.position.z-15);
        camera.transform.position = cameraPosition;
        
    }
}
