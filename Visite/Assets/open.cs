using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openPanel(GameObject _object)
    {
        _object.SetActive(true);
    }
    public void closePanel(GameObject _object)
    {
        _object.SetActive(false);
    }
}
