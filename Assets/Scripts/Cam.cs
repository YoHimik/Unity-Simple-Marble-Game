using UnityEngine;

public class Cam : MonoBehaviour
{
    private const float xCam = 0f;
    private const float yCam = 8f;
    private const float zCam = -10f;

    public MarblePlayer marble;
    
    void Start()
    {
        
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position = new Vector3(marble.transform.position.x + xCam, marble.transform.position.y + yCam, marble.transform.position.z + zCam);
    }
}
