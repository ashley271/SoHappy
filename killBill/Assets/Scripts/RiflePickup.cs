using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiflePickup : MonoBehaviour
{
    [Header("Rifles's")]
    public GameObject PlayerRifle;
    public GameObject PickUpRifle;
    public PlayerPunch playerPunch;

    [Header("Rifle Assign Things")]
    public PlayerScript player;
    private float radius = 2.5f;
    private float nextTimeToPunch = 0f;
    public float punchCharge = 15f;
    private void Awake()
    {
        PlayerRifle.SetActive(false);

    }
    private void Update()
    {   if(Input.GetButtonDown("Fire1")&&Time.time>=nextTimeToPunch)
        {
            nextTimeToPunch = Time.time + 1f / punchCharge;
            playerPunch.Punch();
        }
        if (Vector3.Distance(transform.position, player.transform.position)<radius)
        {
            if(Input.GetKeyDown("f"))
            {
                PlayerRifle.SetActive(true);
                PickUpRifle.SetActive(false);
                //sound

                //objective completed
            }
        }
    }
}
