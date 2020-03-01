using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class MvtPlayer : MonoBehaviour
{
    Animator anim;
    double moveSpeed = 0.2f;
    public NavMeshAgent agent;
    Vector3 targetpos;
    private void Start()
    {
        anim = GetComponent<Animator>();
        targetpos = transform.position;
    }
    void Update()
    {
        //anim.SetFloat("speed", 0);

        // direction du joueur vers le point
   
        if (Input.GetMouseButtonDown(0))
        {
           
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
           
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                     {
                         //anim.SetFloat("speed", 2);
                         //transform.position = hit.point;
                         Debug.Log(hit.point);
                if (hit.transform.tag=="street")
                {
                    targetpos = hit.point;
                }
               

                     }
        }
        agent.SetDestination(targetpos);
        
        anim.SetFloat("speed", Vector3.Distance(transform.position, targetpos) * Time.deltaTime*10);
    }
}