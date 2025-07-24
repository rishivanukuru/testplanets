using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DomeCometProjector : MonoBehaviour
{

    [SerializeField]
    GameObject _cometObject;

    // Update is called once per frame
    void FixedUpdate()
    {
        ProjectComet();
    }

    public void ProjectComet()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            _cometObject.transform.position = transform.TransformDirection(Vector3.forward) * hit.distance;
        }
    }
}
