using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class MvtPlayer : MonoBehaviour
{
    Animator anim;
    double moveSpeed = 0.2f;
    public NavMeshAgent agent;
    Vector3 targetpos;

    public Transform target;
    private NavMeshHit hit;
    private bool blocked = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        targetpos = transform.position;
    }
    void LateUpdate()
    {
        //anim.SetFloat("speed", 0);

        // direction du joueur vers le point
       
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hite;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           

            if (Physics.Raycast(ray, out hite, Mathf.Infinity))
                     {
             
                //anim.SetFloat("speed", 2);
                //transform.position = hit.point;
                Debug.Log(hite.point);
               

                blocked = NavMesh.Raycast(transform.position, hite.transform.position, out hit, NavMesh.AllAreas);
                Debug.DrawLine(transform.position, hite.transform.position, blocked ? Color.red : Color.green);

                
                    
            }
            Debug.Log(blocked);
            if (blocked)
            {
               
                targetpos = hite.point;
            }
        }
       agent.SetDestination(targetpos);
        
       anim.SetFloat("speed", Vector3.Distance(transform.position, targetpos) * Time.deltaTime*10);
     

        
    }
}