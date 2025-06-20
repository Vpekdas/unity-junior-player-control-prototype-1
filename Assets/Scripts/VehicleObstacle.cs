using UnityEngine;

public class VehicleObstacle : MonoBehaviour
{

    private readonly float _speed = 20.0f;
    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
