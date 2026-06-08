using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
public static class EventBus
{
    public static Action<PlayerCore> OnPlayerDie;
    public static Action OnFinish;
}
