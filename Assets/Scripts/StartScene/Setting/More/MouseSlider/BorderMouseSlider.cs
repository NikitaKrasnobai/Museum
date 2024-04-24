
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderMouseSlider : MonoBehaviour
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
            _transform.position = new Vector3(-6.56f, 9.40f, -3.8f);
        }
        if (_transform.position.x < -12.2f)
        {
            _transform.position = new Vector3(-12f, 9.40f, -3.8f);
        }
        if (_transform.position.y != 9.40f)
        {
            _transform.position = new Vector3(_transform.position.x, 9.40f, -3.8f);
        }
        if (_transform.position.z != -3.8f)
        {
            _transform.position = new Vector3(_transform.position.x, _transform.position.y, -3.8f);
        }
        if (_transform.position.x < -6.7f && _transform.position.x > -12.3f)
        {
            float persent = (((_transform.position.x - (-6.6f)) / -0.056f));
            PlayerPrefs.SetFloat("MouseSensitivity", persent * 0.2f);

            Debug.Log(persent * 0.2f);
        }


    }
}
