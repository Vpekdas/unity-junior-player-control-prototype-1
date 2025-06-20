using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Plane;
    private Vector3 _offset = new(10.0f, 2.0f, 2.0f);

    void LateUpdate()
    {
        transform.position = Plane.transform.position + _offset;
    }
}
