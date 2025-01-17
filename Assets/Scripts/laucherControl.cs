using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laucherControl : MonoBehaviour
{

    public Collider bola;
    public KeyCode input;
    public float maxForce;
    public float maxHold;

    private bool isHold = false;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }

    }

    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input)&& !isHold) 
        {
           StartCoroutine(stayHold(collider)); 
        }
    }

    private IEnumerator stayHold(Collider collider)
    {
        isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;
        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxHold);
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }
        
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
