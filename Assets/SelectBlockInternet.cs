using System.Collections;
using UnityEngine;

public class SelectBlockInternet : MonoBehaviour
{
    [SerializeField] private Animation animation;
    [SerializeField] private AnimationClip clip;
    [SerializeField] private AnimationClip RevClip;
    [SerializeField] private GameObject _gameObject;

    IEnumerator WaitAndDoSomethings()
    {
        yield return new WaitForSeconds(0.25f);
        _gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        animation.gameObject.SetActive(false);
        animation.clip = RevClip;
        animation.Play();
    }
    public void Block()
    {
        animation.clip = clip;
        animation.Play();
        StartCoroutine(WaitAndDoSomethings());
    }

    public void UnBlock()
    {
        _gameObject.SetActive(false);
        animation.gameObject.SetActive(true);
        animation.clip = RevClip;
        animation.Play();
    }
}
