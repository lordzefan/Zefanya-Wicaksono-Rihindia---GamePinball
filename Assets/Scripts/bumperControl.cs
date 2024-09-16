using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bumperControl : MonoBehaviour
{

   public Collider bola;
    public float multiplier;
    private Color color;
    public float score;
    //public Color warna;

    public audioManager audioManager;
    public vfxManager vfxManager;
    public scoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        GetComponent<Renderer>().material.color = color;
    }


   private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            //GetComponent<Renderer>().material.color = warna;

            //animation
            animator.SetTrigger("hit");

            //play sfx
            audioManager.playSfx(collision.transform.position);

            //play vfx
            vfxManager.playVfx(collision.transform.position);
    
            //score add
            scoreManager.AddScore(score);
        }
       
    }
}
