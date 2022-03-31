using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public int Magazine;
    public int MagazineMax;
    public int Stash;


    void Start()
    {
        Magazine = 30;
        Stash = 300;
    }

    void Update()
    {
        
    }

    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Magazine -= 1;
        }
    }
    private void reload()
    {
        if (Magazine != 30)
        {
            if (Magazine > Stash)
            {
                Magazine += Stash;
                Stash -= Stash;
            }
            else if (Magazine < Stash)
            {
                int currentammo = Magazine;
                int rest = MagazineMax - currentammo;

                Magazine += rest;
                Stash -= rest;
            }
        }
        else
        {
            Debug.Log("cant reload");
        }
    }
}
