using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Arrays : MonoBehaviour
{
    private int[] array;
    private int[] array1 = new int[4];
    private int[] array2 = new int[4] { 21, 22, 23, 24 };
    private int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    private string[] array4 = new string[10] { "array4.1", "array4.2", "array4.3", "array4.4", "array4.5", "array4.6", "array4.7", "array4.8", "array4.9", "array4.10" };
    private GameObject[] arrayColorredImageRed = new GameObject[4];
    private int[] array5 = new int[50];
    private int[] array6 = new int[498];
    private int[] array7 = new int[499];
    private string[] array8 = new string[100];
    private int[] array9 = new int[1000];
    private int[] array11 = new int[1000];
    private int[] array12 = new int[1000];
    private int randomNumber;
    void Start()
    {
        arrayColorredImageRed = GameObject.FindGameObjectsWithTag("RedImage");
        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }
        DeklarationVonArrays();
        DirekterZugriffHinterstesArray();
        ArrayInEinerZeile();
        ZugriffAufElemente();
        WeitereBeispiele();
    }
    private void DeklarationVonArrays()
    {
        Debug.Log(array1[1]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColorredImageRed[0].gameObject.name);
    }
    private void DirekterZugriffHinterstesArray()
    {
        Debug.Log(array1[array1.Length -1]);
        Debug.Log(array2[array2.Length - 1]);
        Debug.Log(array3[array3.Length -1]);
        Debug.Log(array4[array4.Length -1]);
        Debug.Log(arrayColorredImageRed[3].gameObject.name);
    }
    private void ArrayInEinerZeile()
    {
        string eineZeile = array3[0] + " " + array3[1] + " " + array3[2] + " " + array3[3] + " " + array3[4] + " " + array3[5] + " " + array3[6];
        Debug.Log(eineZeile);
    }
    private void ZugriffAufElemente()
    {
        
        array1[3] = 3;
        Debug.Log(array1[3]);
        array2[2] = 203;
        Debug.Log(array2[2]);
        array3[5] = 333;
        Debug.Log(array3[5]);
        array4[2] = "heute";
        Debug.Log(array4[2]);
        arrayColorredImageRed[2].gameObject.GetComponent<Image>().color = new Color(0, 255, 0, 255);
    }
    private void WeitereBeispiele()
    {
        for (int i = 0; i < array5.Length; i++)
        {
            if (i % 2 == 0)
            {
                array5[i] = i + 20;
            }
        }

        for (int i = 0; i < array6.Length; i++)
        {
            if (i % 2 == 0)
            {
                array6[i] = i + 2;
            }
        }

        for (int i = 0; i < array7.Length; i++)
        {
            if (i % 2 != 0)
            {
                array7[i] = i + 2;
            }
        }

        for (int i = 0; i < array8.Length; i++)
        {
            if (i % 2 == 0)
            {
                array8[i] = "a";
            }
            else
            {
                array8[i] = "b";
            }
        }

        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] =  Random.Range(0,1000);
        }
        System.Array.Sort(array9);
        for (int i = 0; i < array9.Length; i++)
        {
            Debug.Log(array9[i]);
        }

        int[] array10 = array5.Concat(array6).ToArray();

        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(0, 1000);
        }
        System.Array.Sort(array11);
        for (int i = 0; i < array11.Length; i++)
        {
            Debug.Log(array11[0]);
            Debug.Log(array11[999]);
        }

        for (int i = 0; i < array12.Length; i++)
        {
            array12[i] = Random.Range(0, 100);
        }
       randomNumber = Random.Range(0, 100);
       Debug.Log(System.Array.IndexOf(array12, randomNumber));
    }
}