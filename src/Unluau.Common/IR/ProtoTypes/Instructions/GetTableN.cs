﻿namespace Unluau.Common.IR.ProtoTypes.Instructions
{
    public class GetTableN(uint value) : InstructionABC(value)
    {
        /// <inheritdoc/>
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
