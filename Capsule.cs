using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _sizeChangeSpeed;

    private void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x + _sizeChangeSpeed * Time.deltaTime,
            transform.localScale.y + _sizeChangeSpeed * Time.deltaTime, transform.localScale.z + _sizeChangeSpeed * Time.deltaTime);
    }
}