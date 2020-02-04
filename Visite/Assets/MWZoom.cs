using UnityEngine;
using System.Collections;

public class MWZoom : MonoBehaviour
{

    public float dragSpeed = 2;
    private Vector3 dragOrigin;

    float cameraDistanceMax = 200;
   public float cameraDistanceMin =120;
    float cameraDistance = 80;
    float scrollSpeed = 50f;
    float timepuch = 0;
    bool startDrag;
    public delegate void Affiche();
    public static event Affiche affiche;

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, cameraDistance, transform.position.z);
    }
    void Update()
    {
        cameraDistance += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        cameraDistance = Mathf.Clamp(cameraDistance, cameraDistanceMin, cameraDistanceMax);
        transform.position= new Vector3(transform.position.x,cameraDistance,transform.position.z);


        // set camera position
        
        if (Input.GetMouseButtonDown(0))
        {
            timepuch = 0;
            startDrag = true;

            dragOrigin = Input.mousePosition;
         
        }
        if (Input.GetMouseButtonUp(0))
        {
            startDrag = false;
            if (timepuch<=0.2f)
            {
                if (affiche != null)
                {
                    affiche();
                }
            }
        }
        if (startDrag)
        {
            timepuch += Time.deltaTime;
            //send affiche event

            Debug.Log(timepuch);
        }
        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3( pos.y ,0, -pos.x)* dragSpeed*Time.deltaTime;

        transform.position += move;
       // transform.position += Vector3.Lerp(transform.position, move, 0.2f);
    }
}

 




