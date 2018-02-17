using UnityEngine;

public class CheckPoint : MonoBehaviour
{
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
            myTrigger.gameObject.GetComponent<MarblePlayer>().checkpoint = transform.position;           
        }
    }
}
