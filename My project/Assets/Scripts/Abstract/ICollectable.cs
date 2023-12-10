
using System;

internal interface ICollectable
{
    void Initialixed(Action onCollect, Action onNotCollect);
    void Collect();
    void OnNotCollect();

}

