﻿using System;

namespace PureMVC.Interface
{
    public interface IController
    {
        void RegisterCommand(string notificationName, Func<ICommand> commandFunc);

        void ExecuteCommand(INotification notification);

        void RemoveCommand(string notificationName);

        bool HasCommand(string notificationName);
    }

}

