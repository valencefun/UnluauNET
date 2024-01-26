﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unluau.IL.Values
{
    /// <summary>
    /// Represents a global/imported value.
    /// </summary>
    /// <param name="context">Information about the value.</param>
    /// <param name="value">The name of the global.</param>
    public class Global(Context context, string[] value) : BasicValue<string[]>(context, value)
    {
        /// <summary>
        /// Implements the recursive visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Visit(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
