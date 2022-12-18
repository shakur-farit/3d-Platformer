using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingDeath : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject timerDeathPrefab;
    private GameObject timerDeath;

    private void Start()
    {
        timerDeath = GameObject.Find("Player");
    }

    private void Update()
    {
        if(timer.currentTime <= timer.timerLimit)
        {
            
            timerDeathPrefab = Instantiate(timerDeathPrefab, new Vector3(timerDeath.transform.position.x, timerDeath.transform.position.y,
                timerDeath.transform.position.z), Quaternion.identity);
        }
    }
}
