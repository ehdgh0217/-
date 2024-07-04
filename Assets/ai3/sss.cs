using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class sss : MonoBehaviour
{
    [SerializeField] InputField field;
    [SerializeField] Text text;
    [SerializeField] string q = "weather";
    // Start is called before the first frame update
    void Start()
    {
        field.text = "";
        text.text = "ask";
    }

    // Update is called once per frame
    void Update()
    {
        if (field.text == q)
        {
            text.text = "good today";
        }
        else
        {
            text.text = "ask";
        }
            
    }
}
