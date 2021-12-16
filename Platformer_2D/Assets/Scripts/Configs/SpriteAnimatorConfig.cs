using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformerMVC
{
    public enum AnimState
    {
        Idle = 0,
        Run = 1,
        Jump = 2
    }//end enum

    [CreateAssetMenu(fileName = "SpriteAnimationConfig", menuName = "Configs / Animation", order = 1)]
    public class SpriteAnimatorConfig : ScriptableObject
    {
        [Serializable]
        public sealed class SpriteSequence
        {
            public AnimState Track; // как называем набор картинок для каждого трека
            public List<Sprite> Sprites = new List<Sprite>();
        }//end class SpriteSequence

        public List<SpriteSequence> Sequence = new List<SpriteSequence>();

    }//end class SpriteAnimatorConfig

}//end namespace PlatformerMVC
