using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CustomPointer : MonoBehaviour
{
    public bool Activated;
    public GameObject origin;
    public Vector3 direction;
    public LayerMask UILayer;
    public LineRenderer lineRenderer;
    public Zinnia.Action.BooleanAction menuPress;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (menuPress.Value == true)
        {
            if (Physics.Raycast(origin.transform.TransformPoint(origin.transform.position), origin.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                lineRenderer.SetColors(Color.green, Color.green);
                lineRenderer.SetPosition(0, origin.transform.TransformPoint(origin.transform.position));
                lineRenderer.SetPosition(1, hit.point);
            }
            
        }
    }

    
}
