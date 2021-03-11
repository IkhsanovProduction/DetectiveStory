using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public int ammo;
	public GameObject playe;
	public Image image;
	public Collision2D coll;

	void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("Fire1") && ammo>0)
		{
			Shoot();
		}
		else
		{
			StopShoot();
		}
	}

	public void Shoot()
	{
		ammo = ammo - 1;
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}

    public void StopShoot()
    {
		Debug.Log("StopShoot");
    }
}