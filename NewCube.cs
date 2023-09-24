using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCube : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
        transform.Rotate(0, _speed, 0);
        transform.localScale = new Vector3(transform.localScale.x + _speed * Time.deltaTime,
            transform.localScale.y + _speed * Time.deltaTime, transform.localScale.z + _speed * Time.deltaTime);
    }
}
