using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    private int[] array;
    private int[] array1= new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = new int[7] { 31, 32,33, 34,35, 36, 37 };
    private string[] array4 = new string[10]{ "array4.1", "array4.2", "array4.3", "array4.4", "array4.5", "array4.6", "array4.7", "array4.8", "array4.9", "array4.10" };
    [SerializeField]private GameObject[] arrayColorredImageRed = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        arrayColorredImageRed = GameObject.FindGameObjectsWithTag("RedImage");
        Debug.Log(array1[1]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColorredImageRed[0].gameObject.name);
        Debug.Log(array1[3]);
        Debug.Log(array2[3]);
        Debug.Log(array3[6]);
        Debug.Log(array4[9]);
        Debug.Log(arrayColorredImageRed[3].gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
