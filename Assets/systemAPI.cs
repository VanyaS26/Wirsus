using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Threading.Tasks;



public class UAC : MonoBehaviour
{
    [SerializeField]private GameObject game;
    [SerializeField]private Text text;
    bool? isAccept = null;

    public void SetBool(bool value) {isAccept = value;}
    public async Task<bool> StartUAC(object app)
    {
        game.SetActive(true);
        text.text = app.ToString();
        isAccept = null;

        // Чекаємо, поки іsAccept змінить значення
        while (isAccept == null)
        {
            await Task.Yield(); // Пропускаємо кадр
        }

        game.SetActive(false);
        return isAccept.Value; // Тепер return поверне реальне значення
    }

    
}


