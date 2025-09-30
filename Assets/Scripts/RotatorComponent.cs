using UnityEngine;

public class RotatorComponent : MonoBehaviour
{
    [SerializeField]
    float rotationY = 10f;

    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0f);
    }
}
