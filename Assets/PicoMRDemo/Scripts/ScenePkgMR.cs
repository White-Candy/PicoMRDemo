using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScenePkgMR : MonoBehaviour
{
    public InputActionReference leftTrigger;
    public InputActionReference rightTrigger;

    public Transform leftSpawnPoint;
    public Transform rightSpawnPoint;
    public GameObject redCube;
    public GameObject whiteCube;

    void Start()
    {
        leftTrigger.action.started += OnLeftTriggerAction;
        rightTrigger.action.started += OnRightTriggerAction;
    }

    /// <summary>
    /// 右手Trigger触发
    /// </summary>
    /// <param name="obj"></param>
    private void OnRightTriggerAction(InputAction.CallbackContext obj)
    {
        GameObject go = Object.Instantiate(whiteCube, rightSpawnPoint.position, rightSpawnPoint.rotation);
    }
    
    /// <summary>
    /// 左手Trigger触发
    /// </summary>
    /// <param name="obj"></param>
    private void OnLeftTriggerAction(InputAction.CallbackContext obj)
    {
        GameObject go = Object.Instantiate(redCube, leftSpawnPoint.position, leftSpawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
