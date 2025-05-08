using UnityEngine;

public class RotatePropeller : MonoBehaviour
{

    public GameObject propeller;
    public float speed= 10.0f;
    //private Vector3 rotator = new Vector3();

    void Update()
    {
        propeller.transform.Rotate(0, 0, Time.deltaTime * speed);
    }
}
