using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    private int[] array;
    private int[] array1 = new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    private string[] array4 = new string[10] { "array4.1", "array4.2", "array4.3", "array4.4", "array4.5", "array4.6", "array4.7", "array4.8", "array4.9", "array4.10" };
    [SerializeField] private GameObject[] arrayColorredImageRed = new GameObject[4];
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
        //Debug.Log(array2[0], array2[1], array2[2], array2[3]);
        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }
        ArrayInEinerZeile();
        array1[3] = 3;
        Debug.Log(array1[3]);
        array2[2] = 203;
        Debug.Log(array2[2]);
        array3[5] = 333;
        Debug.Log(array3[5]);
        array4[2] = "heute";
        Debug.Log(array4[2]);
        arrayColorredImageRed[2].gameObject.GetComponent<Image>().color = new Color(0, 255, 0, 255); ;
    //EinerZeile();
}


    void ArrayInEinerZeile()
    {
        string eineZeile = array2[0].ToString();
        string eineZeile1 = array2[1].ToString();
        //string AllesZusammen = eineZeile
        Debug.Log(eineZeile);
    }


    /*void EinerZeile()
    {
        string eineZeile = array2[0].ToString();
        string eineZeile1 = array2[1].ToString();
        Debug.Log(eineZeile && eineZeile1);
    }*/

    /*void Zéile()
    {
        string eineZeile = array2[0].ToString();
        int eineZeile1 = array2[1];
        Debug.Log(eineZeile);
    }

    Update is called once per frame
    void Update()
    {
        
    }*/


}