using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DragObj : MonoBehaviour
{
    SphereCollider sphereCol;
 
    void Start()
    {
        sphereCol = GetComponent<SphereCollider>();
    }
 
    void OnMouseDrag()
    {
        sphereCol.enabled = false;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = new Vector3 (hit.point.x, 0, hit.point.z);
            Debug.Log(hit.collider.name);
        }
    }
 
    void OnMouseUp()
    {
        sphereCol.enabled = true;
    }
}
