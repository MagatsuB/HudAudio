using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
     GameControl _gameControl;
     AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _gameControl = Camera.main.GetComponent<GameControl>();
        _gameControl._somItem.Add(_audioSource);
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(TimeMoveON(true));
    }

    public IEnumerator TimeMoveON(bool value)
    {

        transform.DOMove(_gameControl._posItem[0].position,3);
        yield return new WaitForSeconds(2.8f);
        _audioSource.Play();
    }
}
