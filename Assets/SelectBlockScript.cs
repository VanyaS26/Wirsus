using UnityEngine;

public class SelectBlockScript : MonoBehaviour
{
    [SerializeField] private GameObject _needGameObject;
    [SerializeField]private GameObject cus;
    [SerializeField]private GameObject inter;
    [SerializeField] private GameObject secur;
    [SerializeField] private GameObject sys;
    [SerializeField] private GameObject acc;
    [SerializeField] private GameObject lan;
    void Awake()
    {
        OffAll();
        cus.SetActive(true);
    }

    public void OnBlock() {OffAll(); _needGameObject.SetActive(true); }

    private void OffAll()
    {
        cus.SetActive(false);
        inter.SetActive(false);
        secur.SetActive(false);
        sys.SetActive(false);
        acc.SetActive(false);
        lan.SetActive(false);
    }
    
}
