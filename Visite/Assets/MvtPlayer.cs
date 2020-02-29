using UnityEngine;
using System.Collections;

public class MvtPlayer : MonoBehaviour
{
    Animator anim;
    double moveSpeed = 0.2f;
    private void Start()
    {
        anim = GetComponent<Animator>();   
    }
    void Update()
    {
        anim.SetFloat("speed", 0);

        // direction du joueur vers le point
   
        if (Input.GetMouseButtonDown(0))
        {
           
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
           
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                     {
                         anim.SetFloat("speed", 2);
                         transform.position = hit.point;
                         Debug.Log(hit.point);

                     }
        }
    }
}