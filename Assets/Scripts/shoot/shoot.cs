using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform spawnBullet;
    public GameObject bullets;
    public Transform player;
    public Animator anim;

    public AudioClip shootSound, reloadingSound, startSound;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(startSound);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().PlayOneShot(shootSound);
            Instantiate(bullets, spawnBullet.position, player.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            anim.Play("Reload Out Of Ammo");
            GetComponent<AudioSource>().PlayOneShot(reloadingSound);
        }
    }
}
