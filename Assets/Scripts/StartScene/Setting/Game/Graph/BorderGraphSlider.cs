using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderGraphSlider : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        if (_transform.position.x > -6.6f)
        {
            _transform.position = new Vector3(-6.56f, 9.25f, -3.50f);
        }
        if (_transform.position.x < -12.2f)
        {
            _transform.position = new Vector3(-12f, 9.25f, -3.50f);
        }
        if (_transform.position.y != 9.25f)
        {
            _transform.position = new Vector3(_transform.position.x, 9.25f, -3.50f);
        }


    }
}
