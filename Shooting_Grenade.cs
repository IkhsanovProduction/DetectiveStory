using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting_Grenade : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public int ammo;
	public Image image;
	public GameObject playe;
	public Collision2D coll;

	void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("Fire1") && ammo > 0)
		{
			Shoot();
		}
		else
		{
		
		}
	}

	public void Shoot()
	{
		
		ammo = ammo - 1;
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        if (ammo <= 0)
        {
			StopShoot();
        }
		
	}

	public void StopShoot()
	{
		image.enabled = false;
		
	}
}
