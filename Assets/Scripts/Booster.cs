using UnityEngine;

public class Booster : MonoBehaviour
{
    public float BoostSpeed;
    public Vector3 BoostDirection;
    
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
            myTrigger.gameObject.GetComponent<MarblePlayer>().GetComponent<Rigidbody>().AddForce(BoostDirection * BoostSpeed / Time.deltaTime, ForceMode.Impulse);            
        }
    }
}
