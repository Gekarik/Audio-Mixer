using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{
    [SerializeField] Sprite _unmutedSprite;
    [SerializeField] Sprite _mutedSprite;

    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _unmutedSprite;
    }

    public void SwapSprites()
    {
        if (_image.sprite == _mutedSprite)
            _image.sprite = _unmutedSprite;
        else
            _image.sprite = _mutedSprite;
    }
}
