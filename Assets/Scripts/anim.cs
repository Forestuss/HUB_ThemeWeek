using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundOnTriggerEnter;


    private void OnTriggerEnter(Collider other)
    {
        animator.Play("jump");

        audioSource.clip = soundOnTriggerEnter;
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
        animator.Play("idle");
    }

    private void OnTriggerStay(Collider other)
    {
        transform.LookAt(other.transform);
    }
}
