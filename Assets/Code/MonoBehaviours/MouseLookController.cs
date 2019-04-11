using UnityEngine;

public class MouseLookController : MonoBehaviour
{
    private const string InputMouseX = "Mouse X";
    private const string InputMouseY = "Mouse Y";

    [SerializeField]
    private readonly float Sensitivity = 3.0f;
    [SerializeField]
    private readonly float Smoothness = 2.0f;
    [SerializeField]
    private Vector2 initialLook = Vector2.zero;

    private Vector2 mouseLook;
    private Vector2 smoothV;

    private GameObject character;

    void Start()
    {
        character = this.transform.parent.gameObject; // fragile construct; refactor
    }

    void Update()
    {
        Vector2 mouseDiffVector = new Vector2(Input.GetAxisRaw(InputMouseX), Input.GetAxisRaw(InputMouseY));

        mouseDiffVector = Vector2.Scale(mouseDiffVector, new Vector2(Sensitivity * Smoothness, Sensitivity * Smoothness));
        smoothV.x = Mathf.Lerp(smoothV.x, mouseDiffVector.x, 1f / Smoothness);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseDiffVector.y, 1f / Smoothness);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-(mouseLook + initialLook).y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis((mouseLook + initialLook).x, character.transform.up);
    }
}
