﻿using System;

namespace VaccinationSystemApi.Exceptions
{
    public class ModelNotFoundException : Exception
    {
        public ModelNotFoundException()
        {
        }

        public ModelNotFoundException(string message)
            : base(message)
        {
        }

        public ModelNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

