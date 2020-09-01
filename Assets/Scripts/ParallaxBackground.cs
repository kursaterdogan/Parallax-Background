using StarterKit.Base;
using UnityEngine;

public class ParallaxBackground : BaseObject
{
    private float _startPos, _length, _temp, _dist;
    public GameObject myCamera;
    public float parallaxEffect;

    public override void BaseObjectStart()
    {
        GetBackgroundValues();
    }

    public override void BaseObjectUpdate()
    {
        TriggerParallaxEffect();
    }

    private void GetBackgroundValues()
    {
        _startPos = transform.position.x;
        _length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void TriggerParallaxEffect()
    {
        _temp = myCamera.transform.position.x * (1 - parallaxEffect);
        _dist = myCamera.transform.position.x * parallaxEffect;

        transform.position = new Vector3(_startPos + _dist, transform.position.y, transform.position.z);

        if (_temp > _startPos + _length)
            _startPos += _length;
        else if (_temp < _startPos - _length)
            _startPos -= _length;
    }
}