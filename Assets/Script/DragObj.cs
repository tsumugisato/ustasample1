using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DragObj : MonoBehaviour
{
    Plane plane;   
    bool isGrabbing;
    Transform cube;
 
    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(Vector3.up, Vector3.up);
    }
 
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("ああああいいいいえええ");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
 
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Player")
                {
                 
                    isGrabbing = true;
                    Debug.Log(isGrabbing);
                    cube = hit.transform;
                }
            }
        }
 
 
        if (isGrabbing)
        {
            Debug.Log("ううううううおおおお");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            plane.Raycast(ray, out rayDistance);
 
            cube.position = ray.GetPoint(rayDistance);
 
            if (Input.GetMouseButtonUp(0))
            {
                isGrabbing = false;
            }
        }
 
    }
 
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
 
// public class DragObj : MonoBehaviour
// {
//     SphereCollider sphereCol;
 
//     void Start()
//     {
//         sphereCol = GetComponent<SphereCollider>();
//     }
 
//     void OnMouseDrag()
//     {
//         sphereCol.enabled = false;
//         RaycastHit hit;
//         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//         if (Physics.Raycast(ray, out hit))
//         {
//             transform.position = new Vector3 (hit.point.x, 0, hit.point.z);
//             Debug.Log(hit.collider.name);
//         }
//     }
 
//     void OnMouseUp()
//     {
//         sphereCol.enabled = true;
//     }
// }