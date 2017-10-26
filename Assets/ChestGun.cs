using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem {
    [RequireComponent(typeof(Interactable))]

    public class ChestGun : MonoBehaviour {
	public GameObject projectile;
	public float speed;
	public float timeBetweenShots;
	private float lastShotTime;
	// Use this for initialization
	void Start () {
		lastShotTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	}

        void Shoot() {

            for (int i = 0; i < Player.instance.handCount; i++)
            {
                Hand hand = Player.instance.GetHand(i);

                if (hand.controller != null)
                {
                    if (hand.controller.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger))
                    {
                        //SHOOT SOMETHING
                        GameObject bullet = (GameObject)Instantiate(projectile, transform.position, Camera.main.transform.rotation);

                        // Add velocity to the bullet
                        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward;
                    }
                }
            }

        }
        
		}

}
