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
    public Text text1;
    public Text Nom;
    public Text prenom;
    public Text grade;
    public Text statut;
    public Text universite;
    public Image image;
    public Image image2;
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

            int index = infos.FindIndex(d => d.tag == hit.transform.tag);
            if (index != -1)
            {
                SetupItem(infos[index]);
            }

        }
    }
    public void SetupItem(Info info)
    {
        text1.text = info.Titre;
        text.text = info.Desc;
        image.sprite = info.Icon;
        Nom.text = info.Nom;
        prenom.text = info.Prenom;
        statut.text = info.statut;
        grade.text = info.grade;
        image2.sprite = info.image;
        InfoPanel.SetActive(true);
    }

    public void closePanel(GameObject _object)
    {
        _object.SetActive(false);
    }
    public void openPanel(GameObject _object)
    {
        _object.SetActive(true);
    }
}
