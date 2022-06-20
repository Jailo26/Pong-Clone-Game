using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(Launch());
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        StartCoroutine(Launch());
    }

    IEnumerator Launch()
    {
        yield return new WaitForSeconds(1f);
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
