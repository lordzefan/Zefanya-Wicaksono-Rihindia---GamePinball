using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchControl : MonoBehaviour
{
    private enum SwictState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material onMaterial;
    public Material offMaterial;
    public float score;

    public audioManager audioManager;
    public vfxManager vfxManager;
    public scoreManager scoreManager;

    private SwictState state;
    private Renderer renderer;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        set(false);
        StartCoroutine(BlinkTimerStart(5));
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void set(bool active)
    {
        if (active == true)
        {
            state = SwictState.On;
            renderer.material = onMaterial;
            audioManager.playSfx(transform.position);
            StopAllCoroutines();
            vfxManager.playVfx(transform.position);
        }
        else
        {
            state = SwictState.Off;
            renderer.material = offMaterial;
            audioManager.playSfx(transform.position);
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        if(state == SwictState.On)
        {
            set(false);
        }
        else
        {
            set(true);
        }
        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int time)
    {
        state = SwictState.Blink;
        for (int i = 0; i < time; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwictState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
