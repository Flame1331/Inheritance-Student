using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwongWeapon : Weapon
{
    //Swinging Variables
    public float SwingSpeed;
    public float SwingDegrees;

    public override void Attack()
    {
        //Rotate to start pos
        transform.localEulerAngles = new Vector3(0, 0, -SwingDegrees);
        //activate weapon
        EnableWeapon();
        //swing and deactivate
        StartCoroutine(Swing());
    }

    //swinging corutine
    IEnumerator Swing()
    {
        float degrees = 0;
        while(degrees < SwingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, SwingSpeed * Time.deltaTime);
            degrees += SwingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        DisableWeapon();
    }
}
