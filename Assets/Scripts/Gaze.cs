using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    public GameObject[] array;
    public GameObject[] array1;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in array)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hitInfo,
                100.0f,
                Physics.DefaultRaycastLayers))
        {
            Debug.Log("HIT!!!");

            if (hitInfo.transform.gameObject.CompareTag("0"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[0].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("1"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[1].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("2"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[2].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("3"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[3].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("4"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[4].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("5"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[5].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("6"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[6].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("7"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[7].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("8"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[8].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("9"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[9].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("10"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[10].SetActive(true);
            }
            else
            if (hitInfo.transform.gameObject.CompareTag("11"))
            {
                foreach (GameObject obj in array)
                {
                    obj.SetActive(false);
                }
                array[11].SetActive(true);
            }

            //plata2

            if (hitInfo.transform.gameObject.CompareTag("a0"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[0].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a1"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[1].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a2"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[2].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a3"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[3].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a4"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[4].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a5"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[5].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a6"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[6].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a7"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[7].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a8"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[8].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a9"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[9].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a10"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[10].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a11"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[11].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a12"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[12].SetActive(true);
            }
            else
                if (hitInfo.transform.gameObject.CompareTag("a13"))
            {
                foreach (GameObject obj in array1)
                {
                    obj.SetActive(false);
                }
                array1[13].SetActive(true);
            }

        }
        else
        {
            Debug.Log("Gone!");
            foreach (GameObject obj in array)
            {
                obj.SetActive(false);
            }

            foreach (GameObject obj in array1)
            {
                obj.SetActive(false);
            }
        }
    }
}
