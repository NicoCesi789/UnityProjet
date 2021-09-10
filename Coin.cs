using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ScoreManager MyScoreManager;
    public Vector3 RotationSpeed;
    private void Update() 
    {
        transform.Rotate(RotationSpeed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other) 
    {
        MyScoreManager.UpdateScore();
        Destroy(gameObject);
    }
}
