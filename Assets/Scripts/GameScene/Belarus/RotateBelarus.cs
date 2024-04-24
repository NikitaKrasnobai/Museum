using UnityEngine;

public class RotateBelarus : MonoBehaviour
{
    public double Finish = 0;
    public Transform Rotate;
    public Rigidbody Rigidbody;
    void Start()
    {
        Rotate = GetComponent<Transform>();
        Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Rotate.position.y > 85)
        {
            Finish = 2;
        }
        if (Rotate.position.y < 80)
        {
            Finish = 0;
        }
        if (Finish == 0)
        {
            Vector3 movement = new Vector3(0.0f, 1.5f, 0.0f);
            Rigidbody.velocity = Vector3.ClampMagnitude(movement, 1);
        }
        if (Finish == 2)
        {
            Vector3 movement = new Vector3(0.0f, 1.5f, 0.0f);
            Rigidbody.velocity = Vector3.ClampMagnitude(movement, -1);
        }



    }
}
