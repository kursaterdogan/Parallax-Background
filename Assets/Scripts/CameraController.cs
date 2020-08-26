using StarterKit.Base;
using UnityEngine;

public class CameraController : BaseObject
{
    [SerializeField] private BoxCollider2D playerBoxCollider2D;
    [SerializeField] private Transform playerPosition;
    private float _characterBoundY;

    public override void BaseObjectStart()
    {
        SetCameraHeight();
    }

    public override void BaseObjectUpdate()
    {
        SetCameraPosition();
    }

    private void SetCameraHeight()
    {
        _characterBoundY = -playerBoxCollider2D.bounds.center.y;
        // Debug.Log(_characterBoundY);
    }

    private void SetCameraPosition()
    {
        transform.position = new Vector3(
            playerPosition.position.x,
            playerPosition.position.y + _characterBoundY,
            transform.position.z);
    }
}