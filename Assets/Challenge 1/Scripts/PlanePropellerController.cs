using UnityEngine;

public class PlanePropellerController : MonoBehaviour
{
    private float _angle = 0.0f;
    void Update()
    {
        _angle++;
        if (_angle > 360)
        {
            _angle = 0;
        }
        transform.Rotate(0.0f, 0.0f, _angle);
    }
}
