﻿namespace AnyStatus.API
{
    public interface ICanRestart : ITask
    {
        bool CanRestart();
    }
}