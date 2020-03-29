using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Users : MonoBehaviour
{
    DatabaseReference reference;
    public InputField inputField;
   

  

     void Start ()
    {
        Debug.Log("bb");
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://visitetechno.firebaseio.com/");

        // Get the root reference location of the database.
         reference = FirebaseDatabase.DefaultInstance.RootReference;
        Debug.Log(reference);
    }


    public void SaveData()
    {

        if (!inputField.text.Equals(""))
        {
            Debug.Log(inputField.text.ToString());
            reference.Child("users1").Child("username").Child("Email").SetValueAsync(inputField.text.ToString());
        }     
    }
    /*public void LoadData()
    {
        FirebaseDatabase.DefaultInstance.GetReference("users1").ValueChanged += FirebaseSaveLoadValue;
    }
    private void FirebaseSaveLoadValue(object sender ,ValueChangedEventArgs e)
    {
        if (e.Snapshot.Child("username").Exists)
        {
            text.text = e.Snapshot.Child("username").Child("Email").GetValue(true).ToString();
        }
    }*/



}
