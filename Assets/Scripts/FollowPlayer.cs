using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Camera FirstPersonCamera;
    public Camera OverheadCamera;
    [SerializeField] private Vector3 _offset = new(0, 7, -12);

    public void ShowOverheadView()
    {
        FirstPersonCamera.enabled = false;
        OverheadCamera.enabled = true;
        _offset = new Vector3(0, 7, -12);
    }

    public void ShowFirstPersonView()
    {
        FirstPersonCamera.enabled = true;
        OverheadCamera.enabled = false;
        _offset = new Vector3(0, 4, 0);
    }

    void Start()
    {
        if (name == "Main Camera")
        {
            ShowOverheadView();
        }
    }

    void Update()
    {
        if (name != "Main Camera")
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!FirstPersonCamera.enabled)
            {
                ShowFirstPersonView();
            }
            else
            {
                ShowOverheadView();
            }
        }

    }

    void LateUpdate()
    {

        transform.position = Player.transform.position + _offset;
        if (name != "Main Camera")
        {
            return;
        }
        if (FirstPersonCamera.enabled)
        {
            transform.rotation = Player.transform.rotation;
        }
    }
}
