using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceMoves : MonoBehaviour {

    public float scaleSpeed = 0.2f;
    public GameObject granny;
    private Animator animator;

    void Start()
    {
        animator = granny.GetComponent<Animator> ();
    }

        public void Big()
    {
        GameObject.FindWithTag("Granny").transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
    }

    public void Small()
    {
        GameObject.FindWithTag("Granny").transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
    }

    public void Dance1()
    {
        animator.SetTrigger("dance1");
    }

    public void Dance2()
    {
        animator.SetTrigger("dance2");
    }

}
