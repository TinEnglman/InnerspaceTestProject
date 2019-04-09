using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    private float ClosedDoorY = 0;
    [SerializeField]
    private float OpenedDoorY = 0;
    [SerializeField]
    private float DoorSpeed = 0.1f;
    [SerializeField]
    private TriggerController _triggerController = null;

    void FixedUpdate()
    {
        float doorYDiff = 0;
        if (_triggerController.IsTriggered && !Mathf.Approximately(transform.position.y, OpenedDoorY))
        {
            if (transform.position.y > OpenedDoorY)
            {
                doorYDiff = -Time.deltaTime * DoorSpeed;
                if (transform.position.y + doorYDiff < OpenedDoorY)
                {
                    doorYDiff = OpenedDoorY - transform.position.y;
                }
            }
            if (transform.position.y < OpenedDoorY)
            {
                doorYDiff = Time.deltaTime * DoorSpeed;
                if (transform.position.y + doorYDiff > OpenedDoorY)
                {
                    doorYDiff = OpenedDoorY - transform.position.y;
                }
            }
        }

        if (!_triggerController.IsTriggered && !Mathf.Approximately(transform.position.y, ClosedDoorY))
        {
            if (transform.position.y > ClosedDoorY)
            {
                doorYDiff = -Time.deltaTime * DoorSpeed;
            }
            if (transform.position.y < ClosedDoorY)
            {
                doorYDiff = Time.deltaTime * DoorSpeed;
            }
        }

        if (doorYDiff != 0)
        {
            transform.Translate(new Vector3(0, doorYDiff, 0));
        }
    }
}
