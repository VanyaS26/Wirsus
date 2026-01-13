using UnityEngine;

public class AppActivate : MonoBehaviour
{
    [SerializeField] private GameObject _app;
    [SerializeField] private Animation _anim;
    [SerializeField] private AnimationClip _clipOriginal;


    void Awake() { _app.SetActive(false); }
    

    public void OpenApp(GameObject App) { App.SetActive(true); _anim.clip = _clipOriginal;_anim.Play(); }
        
    public void CloseApp(GameObject App) { App.SetActive(false); }
}
