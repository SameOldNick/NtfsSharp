﻿using System;

namespace NtfsSharp.DiskManager.Physical.Exceptions
{
    public class InvalidMasterBootRecord : Exception
    {
        public string FieldName { get; }

        public InvalidMasterBootRecord(string message) : base(message)
        {
            
        }

        public InvalidMasterBootRecord(string message, string fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }
}
