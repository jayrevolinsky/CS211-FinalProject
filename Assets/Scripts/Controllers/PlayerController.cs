using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public TriggerSystem focus;
    public LayerMask movementmask; //doesnt seem to be the bug
    Camera cam;
    PlayerMotor motor;


    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementmask)) //tried movementmask
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
            motor.FollowTarget(newFocus); //not the problem function call
        }
        //focus = newFocus; --- not bad but not redundant
        newFocus.OnFocused(transform);
        //motor.FollowTarget(newFocus); ---also redundant
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
