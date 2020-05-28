using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerManager : MonoBehaviour
{
    public GameObject _enemyPrefab;
    public float _spawnInterval = 5f;
    public float _currentTime = 0f;
    private int xPos;
    
  
   void Start()
    {
       
    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        
        if(_currentTime >= _spawnInterval)
        {

            _currentTime = 0f;
            xPos = Random.Range(-8, 8);


            Instantiate(

                _enemyPrefab,
                new Vector3(xPos, 1, 115),
                Quaternion.identity


                );

        }
    }
}
