using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DragObj : MonoBehaviour
{
    Plane plane;   
    bool isGrabbing;
    Transform cube;
    public Camera subCamera;
    public Camera Camera;
 
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
            if (Camera != null){ 

            
            Debug.Log("ああああいいいいえええ");
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            

 
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                Debug.Log("ははは");
                if (hit.collider.tag == "Player")
                {
                    Debug.Log("iiii");

                 
                    isGrabbing = true;
                    Debug.Log(isGrabbing);
                    cube = hit.transform;
                }
            }
            }
            else
            {
                Debug.Log("ここおおおおおおお");
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
        }
 
 
        // if (subCamera == null){
        //       Debug.Log("っっっっk");
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
                 Debug.Log(isGrabbing);
            }
        }

        // }
        else{
            Debug.Log("いけた");
        }
       
 
    }
 
}