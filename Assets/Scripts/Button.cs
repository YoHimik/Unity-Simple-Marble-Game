using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject ObjectToActive;

    private bool Checked;

    private const float CheckedDown = 0.4f;

    void Start()
    {
        Checked = false;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "PlayerMarble" && !Checked)
        {
            ObjectToActive.SetActive(true);
            transform.position = new Vector3(transform.position.x, transform.position.y - CheckedDown, transform.position.z);
            Checked = true;
        }
    }
}
