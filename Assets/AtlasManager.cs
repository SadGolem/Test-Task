using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AtlasManager : MonoBehaviour
{
    [SerializeField] private SpriteAtlas _atlas;
    [SerializeField] private string _nameSprite;

    void Start()
    {
        GetComponent<Image>().sprite = _atlas.GetSprite(_nameSprite);
    }

}
