using UnityEngine;

public class DeathBox : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision myTrigger)
    {
        if (myTrigger.gameObject.name == "PlayerMarble")
        {
            myTrigger.gameObject.GetComponent<MarblePlayer>().Death();
        }
    }
}
