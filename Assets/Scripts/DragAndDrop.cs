using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunctions : MonoBehaviour
{
    GameObject Target;
    bool isMouseDrag;
    Vector3 offset;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
            RaycastHit hitConfirmed;
            if (Target != null)
            {
                isMouseDrag = true;
                //offset = Target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition))
            }
      }
      else
      {
            isMouseDrag = false;
      }
      if (isMouseDrag)
      {
            //Function for dealing with camera while mouse is dragging
      }
    }
}
