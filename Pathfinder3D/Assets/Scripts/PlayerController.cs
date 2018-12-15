using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private Camera cam;
    private NavMeshAgent agent;

    void Awake()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

	void Update ()
	{
	    if (agent == null) return;

	    if (Input.GetMouseButtonDown(0))
	    {
	        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;

	        if (Physics.Raycast(ray, out hit))
	        {
                //move our agent
	            agent.SetDestination(hit.point);

	        }

	    }
	}
}
