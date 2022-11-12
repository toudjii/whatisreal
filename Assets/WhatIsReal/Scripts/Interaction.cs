using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Camera cam;
    public LayerMask layerMask;
    public float RayLenghtInter;
    public GameObject clickme; 
    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, RayLenghtInter, layerMask))
        {
            clickme.SetActive(true);
            Transform objectHit = hit.transform;
            Debug.Log(objectHit.name);
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("kliknales");
                objectHit.GetComponent<Interactable>().onInteract.Invoke();
            }
        }
        else clickme.SetActive(false);
    }
}