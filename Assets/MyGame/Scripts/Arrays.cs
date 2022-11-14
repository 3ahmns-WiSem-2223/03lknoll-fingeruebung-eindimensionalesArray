using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    private int[] array;
    private int[] array1= new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = new int[7] { 31, 32,33, 34,35, 36, 37 };
    private string[] array4 = new string[10]{ "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4", "array4" };
    private GameObject[] arrayColorredImageRed = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        arrayColorredImageRed = GameObject.FindGameObjectsWithTag("RedImage");
        //bug.Log(array1.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
