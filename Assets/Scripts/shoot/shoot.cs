using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform spawnBullet;
    public GameObject bullets;
    public Transform player;
    public Animator anim;

    public ammo ammo;

    public AudioClip shootSound, reloadingSound, startSound;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(startSound);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo.ammoInMagaz > 0)
            {
                GetComponent<AudioSource>().PlayOneShot(shootSound);
                Instantiate(bullets, spawnBullet.position, player.rotation);
                ammo.ammoInMagaz--;
            }           
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammo.ammoInMagaz < 30 && ammo.allAmmo > 0)
            {
                anim.Play("Reload Out Of Ammo");
                GetComponent<AudioSource>().PlayOneShot(reloadingSound);
                int needAmmo = 30 - ammo.ammoInMagaz;
                if (needAmmo > ammo.allAmmo)
                {
                    ammo.ammoInMagaz += ammo.allAmmo;
                    ammo.allAmmo = 0;
                }
                else if (ammo.allAmmo > needAmmo)
                {
                    ammo.allAmmo -= needAmmo;
                    ammo.ammoInMagaz += needAmmo;
                }
            }

        }
    }
}
