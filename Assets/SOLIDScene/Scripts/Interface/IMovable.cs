using UnityEngine;

namespace SOLIDScene
{
    /// <summary>
    /// 移動可能なオブジェクトのインターフェース
    /// 拡張性、保守性を持たせる
    /// </summary>
    public interface IMovable
    {
        void Move();
    }
}