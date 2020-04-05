using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
public class InfoManager : MonoBehaviour
{
    
    public List<Info> infos;

    public GameObject InfoPanel;
    public Text text;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {

    
      


    }
    private void OnEnable()
    {
        MWZoom.affiche += AffchePanel;

    }

    private void OnDisable()
    {
        MWZoom.affiche -= AffchePanel;

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        { // << use GetMouseButton instead of GetMouseButtonDown
            
        }


    }
    void AffchePanel()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 700))
        {
            Debug.Log("You selected the " + hit.transform.name);
            int index = infos.FindIndex(d => d.tag == hit.transform.tag);
            if (index != -1)
            {
                SetupItem(infos[index]);
            }

        }
    }
    public void SetupItem(Info info)
    {
        text.text = info.Desc;
        image.sprite = info.Icon;
        InfoPanel.SetActive(true);
    }

    public void closePanel(GameObject _object)
    {
        _object.SetActive(false);
    }
}
