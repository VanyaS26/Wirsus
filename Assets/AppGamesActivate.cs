using UnityEngine;

public class AppActivate : MonoBehaviour
{
    [SerializeField] private GameObject _app;
    [SerializeField] private Animation _anim;
    [SerializeField] private AnimationClip _clipOriginal;
    [SerializeField] private GameObject _indicator;


    void Awake() { _app.SetActive(false); _indicator.SetActive(false); }
    

    public void OpenApp() { _app.SetActive(true); _anim.clip = _clipOriginal;_anim.Play(); _indicator.SetActive(true); }
        
    public void CloseApp() { _app.SetActive(false); _indicator.SetActive(false); }
}
