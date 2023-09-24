using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        transform.Rotate(0, _rotateSpeed, 0);
    }
}
