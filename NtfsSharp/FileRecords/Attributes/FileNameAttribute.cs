﻿using NtfsSharp.FileRecords.Attributes.Base;
using NtfsSharp.FileRecords.Attributes.Shared;

namespace NtfsSharp.FileRecords.Attributes
{
    /// <summary>
    /// This Attribute stores the name of the file attribute and is always resident. 
    /// </summary>
    public class FileNameAttribute : AttributeBodyBase
    {
        public readonly FileName FileName;

        public FileNameAttribute(AttributeHeader header) : base(header, MustBe.Resident)
        {
            FileName = new FileName(Body, CurrentOffset);
            CurrentOffset = FileName.CurrentOffset;
        }
        
    }
}
