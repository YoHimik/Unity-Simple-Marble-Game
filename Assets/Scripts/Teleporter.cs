using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 newPosition;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "PlayerMarble")
        {
            myTrigger.gameObject.GetComponent<MarblePlayer>().transform.position = newPosition;
            myTrigger.gameObject.GetComponent<MarblePlayer>().GetComponent<Rigidbody>().velocity = new Vector3();
        }
    }
}
