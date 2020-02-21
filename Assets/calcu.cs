using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class calcu : MonoBehaviour
{
    // inputfield input
    public InputField firstnumber, secondnumber;
    public Text ans;
    private int fnum;
    private int snum;
    public void onAdd()
    {
        int fnum = int.Parse(firstnumber.text);
        int snum = int.Parse(secondnumber.text);
        ans.text = "Result "+" "+(fnum + snum).ToString();
    }
    public void onSub()
    {
        int fnum = int.Parse(firstnumber.text);
        int snum = int.Parse(secondnumber.text);
        ans.text = "Result "+" "+(fnum -  snum).ToString();
    }
    /*  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } */
}
