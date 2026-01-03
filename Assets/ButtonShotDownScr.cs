using UnityEngine;

public class ButtonShotDownScr : MonoBehaviour
{
    [SerializeField] private GameObject _greyPanel;
    [SerializeField] private Animation _greyPanelAnim;
    [SerializeField] private GameObject _acceptPanel;
    [SerializeField] private Animation _acceptPanelAnim;
    public void AcceptShotDown()
    {
        _greyPanel.SetActive(true);
        _greyPanelAnim.Play();
        _acceptPanel.SetActive(true);
        _acceptPanelAnim.Play();
    }
}
