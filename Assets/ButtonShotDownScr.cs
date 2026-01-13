using UnityEngine;

public class ButtonShotDownScr : MonoBehaviour
{
    
    [SerializeField] private GameObject _greyPanel;
    [SerializeField] private Animation _greyPanelAnim;
    [SerializeField] private AnimationClip _greyPanelAnimUp;
    [SerializeField] private AnimationClip _greyPanelAnimDown;
    [SerializeField] private GameObject _acceptPanel;
    [SerializeField] private Animation _acceptPanelAnim;
    [SerializeField] private AnimationClip _acceptPanelAnimUp;
    [SerializeField] private AnimationClip _acceptPanelAnimDown;
    public void AcceptShotDown(GameObject _apps)
    {
        _apps.SetActive(false);
        _greyPanel.SetActive(true);
        _greyPanelAnim.clip = _greyPanelAnimUp;
        _greyPanelAnim.Play();
        _acceptPanel.SetActive(true);
        _acceptPanelAnim.clip = _acceptPanelAnimUp;
        _acceptPanelAnim.Play();
    }
    public void DisableShotDown(GameObject _apps)
    {
        _acceptPanelAnim.clip = _acceptPanelAnimDown;
        _acceptPanelAnim.Play();
        _apps.SetActive(true);
        _greyPanelAnim.clip = _greyPanelAnimDown;
        _greyPanelAnim.Play();
       
    }
    private void FixedUpdate()
    {
        if(_acceptPanelAnim.clip == _acceptPanelAnimDown && !_acceptPanelAnim.isPlaying)
        {
            _acceptPanel.SetActive(false);
        }


        if(_greyPanelAnim.clip == _greyPanelAnimDown && !_greyPanelAnim.isPlaying)
        {
            _greyPanel.SetActive(false);
        }
    }
}
