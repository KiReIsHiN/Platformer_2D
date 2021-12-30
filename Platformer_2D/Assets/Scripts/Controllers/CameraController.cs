using UnityEngine;

namespace PlatformerMVC
{
    public class CameraController 
    {
        private LevelObjectView _playerView;
        private Transform _playerTransform;
        private Transform _mainCamTransform;

        private float _camSpeed = 1.2f;

        private float X;
        private float Y;

        private float _offsetY;
        private float _offsetX;

        private float _xAxisInput;
        private float _yAxisVelocity;

        public CameraController (LevelObjectView player, Transform camera)
        {
            _playerView = player;
            _playerTransform = _playerView.transform;
            _mainCamTransform = camera;
        }

        public void Update()
        {
            _xAxisInput = Input.GetAxis("Horizontal");
            _yAxisVelocity = _playerView._rigidbody.velocity.y;


            if(_xAxisInput > 0)
            {
                _offsetX = 10;
            }
            else if (_xAxisInput < 0)
            {
                _offsetX = -10;
            }
            else
            {
                _offsetX = 0;
            }





            if(_yAxisVelocity > 0)
            {
                _offsetY = 10;
            }
            else if(_yAxisVelocity < 0)
            {
                _offsetY = -10;
            }
            else
            {
                _offsetY = 0;
            }

            _mainCamTransform.position = Vector3.Lerp(_mainCamTransform.position,
                                                        new Vector3(X+_offsetX,Y+_offsetY,_mainCamTransform.position.z),
                                                        Time.deltaTime*_camSpeed);
        }
    }
}
