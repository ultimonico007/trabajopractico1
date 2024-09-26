using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movXtime : MonoBehaviour
{
    public float X = 10f;
    public float moveSpeed = 2f; 
    public Vector3 posicioninicial;

    // Start is called before the first frame update
    void Start()
    {
        posicioninicial = transform.position;
        StartCoroutine(MoverObjeto());
    }
    IEnumerator MoverObjeto()
    {
        while(transform.position.x< X)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        while (transform.position.x > posicioninicial.x)
        {
            transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            yield return null;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
