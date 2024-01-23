using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class ClickSpawner: MonoBehaviour {
    [SerializeField] protected InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;

    private float TimeLastShot = 0f;  //time from the last shot

    private float restartTime = 0f; // restart the time after shooting

    [SerializeField] public float TimeCantShot; // deide time that we cant shot

    

    void OnEnable()  {
        spawnAction.Enable();
    }

    void OnDisable()  {
        spawnAction.Disable();
    }

    protected virtual GameObject spawnObject() {
        Debug.Log("Spawning a new object");

        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }

        return newObject;
    }

    // When starting the game it will not delay us in shooting and we can shot right away
    private void Start()
    {
        TimeLastShot = TimeCantShot;
    }


    private void Update() {
        
        TimeLastShot += Time.deltaTime;  // add the time to to check the last time we shot

        if (spawnAction.WasPressedThisFrame() && CanShoot()) {   // checking if the button was press adn we can shoot

            spawnObject();

            TimeLastShot = restartTime;  // then we will restart the time to 0 to start counting all over again the time from the last shot
        }
    }

    // Bool function that check when we can start shot ( meaning if the shot from the last time we shot is higher then the time we decide he cant shot
    private bool CanShoot()
    {
        if(TimeCantShot > TimeLastShot)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
