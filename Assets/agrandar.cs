using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agrandar : MonoBehaviour
{
    public Vector3 tamañoMinimo = new Vector3(1f, 1f, 1f);
    public Vector3 tamañoMaximo = new Vector3(2f, 2f, 2f);
    public float intervalo = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CambiarTamano());
    }
    IEnumerator CambiarTamano()
    {
        while (true)
        {
            transform.localScale = tamañoMinimo;
            yield return new WaitForSeconds(intervalo);
            transform.localScale = tamañoMaximo;
            yield return new WaitForSeconds(intervalo);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
