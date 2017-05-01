﻿using System;

namespace NtfsSharp.DiskManager.Physical.Exceptions
{
    public class InvalidGuidPartitionTable : Exception
    {
        public string FieldName { get; }

        public InvalidGuidPartitionTable(string message) : base(message)
        {

        }

        public InvalidGuidPartitionTable(string message, string fieldName) : base(message)
        {
            FieldName = fieldName;
        }
    }
}
