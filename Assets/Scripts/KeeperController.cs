using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(KeeperMotor))]
public class KeeperController : MonoBehaviour
{

    public LayerMask movementmask;
    Camera cam;
    KeeperMotor motor;

    public TriggerSystem focus;

    private void Start()
    {
        cam = Camera.main;
        motor = GetComponent<KeeperMotor>();
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementmask))
            {
                motor.MoveToPoint(hit.point);
                //Move object to hit
                RemoveFocus();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                TriggerSystem trigger = hit.collider.GetComponent<TriggerSystem>(); 
                if(trigger != null)
                {
                    SetFocus(trigger);
                }
            }
        }
    }

    void SetFocus(TriggerSystem newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
            {
                focus.OnDefocused();
            }
            
            focus = newFocus;
            motor.FollowTarget(newFocus);
        }
        focus = newFocus;
        newFocus.OnFocused(transform);
        motor.FollowTarget(newFocus);
    }

    void RemoveFocus()
    {
        if (focus != null)
        {
            focus.OnDefocused();
        }
        
        focus = null;
        motor.StopFollowTarget();
    }
}
