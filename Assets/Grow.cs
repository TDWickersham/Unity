using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public float timer;
    public Vector3 scale;
    public float rotationSpeed;

    IEnumerator CoroutineScale(GameObject player)
    {
        while(transform.localScale != scale)
        {
            player.transform.localScale += Vector3.one;

            yield return new WaitForSeconds(timer);
        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, 0, rotationSpeed / 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var playerController = other.GetComponent<BallController>();
            if (playerController != null)
            {
                StartCoroutine(CoroutineScale(other.gameObject));
                Destroy(gameObject);
            }
        }
    }
}
