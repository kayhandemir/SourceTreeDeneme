using UnityEngine;

public class Oyun : MonoBehaviour
{
    float elapsedTime = 20f;
    void Start()
    {
        
    }
    void Update()
    {
        elapsedTime -= Time.deltaTime;
        if (elapsedTime < 0 || Input.anyKeyDown)
            EnumSinifi.Game.OyunuYukle();
    }
}
