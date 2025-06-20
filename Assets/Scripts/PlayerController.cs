using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI RestartText;
    [SerializeField] private float _speed = 20.0f;
    [SerializeField] private float _turnSpeed = 45.0f;
    private float _horizontalInput;
    private float _verticalInput;

    private void Update()
    {
        if (transform.position.y < -10)
        {
            RestartText.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }
    private void FixedUpdate()
    {
        if (name == "SecondPlayer")
        {
            _horizontalInput = Input.GetAxis("Horizontal2");
            _verticalInput = Input.GetAxis("Vertical2");
        }

        else if (name == "FirstPlayer")
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            _verticalInput = Input.GetAxis("Vertical");
        }
        transform.Translate(_speed * _verticalInput * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
