using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private const string InputVertical = "Vertical";
    private const string InputHorizontal = "Horizontal";
    private const string InputKeystateEscape = "escape";

    [SerializeField]
    private readonly float MoveSpeed = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float forwardQuant = Input.GetAxis(InputVertical) * MoveSpeed;
        float strafeQuant = Input.GetAxis(InputHorizontal) * MoveSpeed;

        forwardQuant *= Time.deltaTime;
        strafeQuant *= Time.deltaTime;

        transform.Translate(strafeQuant, 0, forwardQuant); 

        if (Input.GetKeyDown(InputKeystateEscape)) // move to separate module
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
