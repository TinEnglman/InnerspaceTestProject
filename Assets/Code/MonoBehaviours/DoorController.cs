using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    private float ClosedDoorY = 1.95f;
    [SerializeField]
    private float OpenedDoorY = 1.95f;
    [SerializeField]
    private float DoorSpeed = 0.1f;

    private bool _isOpen = false;

    void Start()
    {
        _isOpen = true;
    }

    void Update()
    {
        float doorYDiff = 0;
        if (_isOpen && transform.position.y > OpenedDoorY)
        {
            doorYDiff = -Time.deltaTime * DoorSpeed;
        }

        if (!_isOpen && transform.position.y < OpenedDoorY)
        {
            doorYDiff = Time.deltaTime * DoorSpeed;
        }

        if  (doorYDiff != 0)
        {
            transform.Translate (new Vector3(0, doorYDiff, 0));
        }
    }

    public void SetOpen(bool isOpen)
    {
        _isOpen = isOpen;
    }
}
