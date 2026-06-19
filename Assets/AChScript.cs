using UnityEngine;

public class CostScr : MonoBehaviour
{
    public int block;
    public GameObject[] gameObjects;
    void Start()
    {
        block = 0;
        for(int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
        gameObjects[block].SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow)) { 
            if(block < gameObjects.Length - 1)
            {
                block++;
                for(int i = 0; i < gameObjects.Length; i++)
                {
                    gameObjects[i].SetActive(false);
                }
                gameObjects[block].SetActive(true);
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) { 
            if(block > 0)
            {
                block--;
                for(int i = 0; i < gameObjects.Length; i++)
                {
                    gameObjects[i].SetActive(false);
                }
                gameObjects[block].SetActive(true);
            }
        }
    }
}
