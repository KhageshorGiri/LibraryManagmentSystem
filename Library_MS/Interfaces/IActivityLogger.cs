﻿using System;


namespace Library_MS.Interfaces
{
    public interface IActivityLogger
    {
        void ExceptionLogger(string path, string message, string stackTrace, string user);

        void UserActivityLogger();
    }
}
